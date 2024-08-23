using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelGestSystem.Data.Model
{
    public class Cliente
    {
        public int Id { get; set; }
        [Required]
        public string Nombre { get; set; }
        [Required]
        public string Apellido { get; set; }

        [EmailAddress]
        public string Email { get; set; }
        [StringLength(20)]
        public string Telefono { get; set; }
        [StringLength(80)]
        public string Localidad { get; set; }
        [StringLength(80)]
        public string Provincia { get; set; }


        public ICollection<Reservacion> Reservaciones { get; set; }
    }
}
