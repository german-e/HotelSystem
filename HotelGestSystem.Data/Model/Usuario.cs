using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelGestSystem.Data.Model
{
    public class Usuario
    {
        public int Id { get; set; }
        [Required]
        public string Username { get; set; }
        [Required]
        public string Nombre { get; set; }

        [EmailAddress]
        public string Email { get; set; }
        public string Password { get; set; }
        public bool EstaActivo { get; set; } = true;

        public int RolId { get; set; }
        public Rol Rol { get; set; }

    }
}
