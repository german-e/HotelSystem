using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelGestSystem.Data.Model
{
    public class Tarifa
    {
        public int Id { get; set; }
        
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }
        public int DescuentoPorcentaje { get; set; }
        public decimal DescuentoMonto { get; set; }


    }
}
