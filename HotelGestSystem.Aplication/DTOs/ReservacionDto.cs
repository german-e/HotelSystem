using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelGestSystem.Aplication.DTOs
{
    public class ReservacionDto
    {
        public DateTime Desde { get; set; }
        public DateTime Hasta { get; set; }

        private int dias;

        public int Dias
        {
            get { return dias; }
            set 
            { 
                int dateDiff = (Hasta - Desde).Days;

                dias = dateDiff;
            }
        }

        public  GuestDto Huesped { get; set; }

        public HabitacionDto Room { get; set; }

        public decimal Prepayment { get; set; }
    }
}
