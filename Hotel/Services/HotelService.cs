using Hotel.Data;
using Hotel.Models;
using Hotel.ViewModels;
using Microsoft.EntityFrameworkCore;

namespace Hotel.Services
{
    public class HotelService
    {


        private readonly HotelDbContext _context;

        public HotelService(HotelDbContext context)
        {
            this._context = context;
        }

        public async Task<ReservationsListViewModel> GetAllReservationsAsync()
        {
            var reservationsList = new ReservationsListViewModel();

            try
            {
                reservationsList.Prenotazioni = await _context.Prenotazioni
                    .Include(p => p.Camera)  
                    .Include(p => p.Cliente) 
                    .ToListAsync();
            }
            catch
            {
                reservationsList.Prenotazioni = null;
            }

            return reservationsList;
        }

        public async Task<Prenotazione?> GetReservationByIdAsync(Guid id)
        {
            var prenotazione = await _context.Prenotazioni.FindAsync(id);

            try { return prenotazione; } catch { return null; }
        }

        public async Task<bool> UpdateReservationAsync(EditReservationViewModel editReservationViewModel)
        {
            var res = await _context.Prenotazioni.FindAsync(editReservationViewModel.PrenotazioneId);

            if (res == null)
            {
                return false;
            }

            res.PrenotazioneId = editReservationViewModel.PrenotazioneId;
            res.CameraId = editReservationViewModel.CameraId;
            res.ClienteId = editReservationViewModel.ClienteId;
            res.DataInizio = editReservationViewModel.DataInizio;
            res.DataFine = editReservationViewModel.DataFine;
          

            return await _context.SaveChangesAsync() > 0;
        }

        public async Task<bool> DeleteReservationByIdAsync(Guid id)
        {
            var res = await _context.Prenotazioni.FindAsync(id);
            if (res == null) { return false; }
            _context.Prenotazioni.Remove(res);
            return await _context.SaveChangesAsync() > 0;

        }

        public async Task<bool> AddReservationAsync(AddReservationViewModel addReservationViewModel)
        {
            var res = new Prenotazione()
            {
                PrenotazioneId = Guid.NewGuid(), 
                ClienteId = addReservationViewModel.ClienteId,
                CameraId = addReservationViewModel.CameraId,
                DataInizio = addReservationViewModel.DataInizio,
                DataFine = addReservationViewModel.DataFine,
                Stato = addReservationViewModel.Stato

            };
            _context.Prenotazioni.Add(res);
            return await _context.SaveChangesAsync() > 0;
        }
    }
}

   
