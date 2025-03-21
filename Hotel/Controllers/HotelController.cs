using Hotel.Data;
using Hotel.Models;
using Hotel.Services;
using Hotel.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Threading.Tasks;

namespace Hotel.Controllers
{
    public class HotelController : Controller
    {
        private readonly HotelService _hotelService;
        private readonly HotelDbContext _context;

        public HotelController(HotelService hotelService, HotelDbContext context)
        {
            _hotelService = hotelService;
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet("Prenotazioni/get-all")]
        public async Task<IActionResult> ListReservations()
        {
            var reservationsList = await _hotelService.GetAllReservationsAsync();
            return PartialView("_ReservationsList", reservationsList);
        }

        public async Task<IActionResult> Edit(Guid id)
        {
            var res = await _hotelService.GetReservationByIdAsync(id);

            if (res == null)
            {
                return RedirectToAction("Index");
            }

            ViewBag.Camere = await _context.Camere
                .ToListAsync();

            ViewBag.Clienti = await _context.Cliente
      
                .ToListAsync();

            var editReservationViewModel = new EditReservationViewModel()
            {
                PrenotazioneId = res.PrenotazioneId,
                ClienteId = res.ClienteId,
                CameraId = res.CameraId,
                DataInizio = res.DataInizio,
                DataFine = res.DataFine,
                Stato = res.Stato
            };

            return PartialView("_EditForm", editReservationViewModel);
        }

        [HttpPost("Hotel/Edit/Save")]
        public async Task<IActionResult> Edit(EditReservationViewModel editReservationViewModel)
        {
            if (!ModelState.IsValid)
            {
                var errors = ModelState.Values.SelectMany(v => v.Errors).Select(e => e.ErrorMessage).ToList();

                return Json(new
                {
                    success = false,
                    message = "Errore nei dati inseriti",
                    errors
                });
            }

            var result = await _hotelService.UpdateReservationAsync(editReservationViewModel);

            if (!result)
            {
                return Json(new
                {
                    success = false,
                    message = "Errore durante l'aggiornamento nel database"
                });
            }

            return Json(new
            {
                success = true,
                message = "Prenotazione aggiornata con successo"
            });
        }

        public async Task<IActionResult> Delete(Guid id)
        {
            var result = await _hotelService.DeleteReservationByIdAsync(id);

            if (!result)
            {
                return Json(new
                {
                    success = false,
                    message = "Errore"
                });
            }
            return Json(new
            {
                success = true,
                message = "Avvenuto con successo"
            });
        }
        [HttpGet]
        public async Task<IActionResult> Add()
        {
            ViewBag.Camere = await _context.Camere
                .Select(c => new { c.CameraId, Info = $"N° {c.NumeroCamera} - {c.Tipo}" })
                .ToListAsync();

            ViewBag.Clienti = await _context.Cliente
                .Select(c => new { c.ClienteId, NomeCompleto = $"{c.Nome} {c.Cognome}" })
                .ToListAsync();

            return PartialView("_AddForm");
        }

        [HttpPost("Hotel/Add")]
        public async Task<IActionResult> Add(AddReservationViewModel addReservationViewModel)
        {
            if (!ModelState.IsValid)
            {
                return Json(new
                {
                    success = false,
                    message = "Errore nei dati inseriti"
                });
            }

            var result = await _hotelService.AddReservationAsync(addReservationViewModel);

            if (!result)
            {
                return Json(new
                {
                    success = false,
                    message = "Errore durante l'aggiunta"
                });
            }

            return Json(new
            {
                success = true,
                message = "Prenotazione aggiunta con successo"
            });
        }
    }
}
