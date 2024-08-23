using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelGestSystem.Data.Model
{
    public class Categoria
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal BasePrice { get; set; }

        public ICollection<Habitacion> Habitaciones { get; set; }
    }
}
