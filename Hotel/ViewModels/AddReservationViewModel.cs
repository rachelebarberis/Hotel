﻿using System.ComponentModel.DataAnnotations;
using Hotel.Models;

namespace Hotel.ViewModels
{
    public class AddReservationViewModel
    {
       
        public Guid ClienteId { get; set; }


        public Guid CameraId { get; set; }


        [DataType(DataType.Date)]
        public DateTime DataInizio { get; set; }


        [DataType(DataType.Date)]
        public DateTime DataFine { get; set; }



        public required string Stato { get; set; }



        public virtual Cliente? Cliente { get; set; }


        public virtual Camera? Camera { get; set; }


        public int DurataGiorni => (DataFine - DataInizio).Days;



        public decimal CostoTotale => Camera != null ? Camera.PrezzoPerNotte * DurataGiorni : 0;
    }
}
