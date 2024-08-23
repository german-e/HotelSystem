using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelGestSystem.Data.Model
{
    public class Reservacion
    {
        public long Id { get; set; }
        public DateTime Desde { get; set; }
        public DateTime Hasta { get; set; }
        public decimal TotalPrice { get; set; }
        public int ClienteId { get; set; }
        public Cliente Cliente { get; set; }        
        public int HabitacionId { get; set; }
        public Habitacion Habitacion { get; set; }

    }
}
