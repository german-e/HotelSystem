using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelGestSystem.Domain.Shared.Entities
{
    public class Usuario
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Email { get; set; }
        public string Telefono { get; set; }
        public bool EsAdmin { get; set; } = false;
        public bool EsActivo { get; set; } = true;

        public List<Rol> Roles { get; private set ; }
        
        public void AgregarRol(Rol rol) 
        {
            Roles.Add(rol);            
        } 

        public void RemoverRol(Rol rol)
        {
            Roles.Remove(rol);
        }

       


    }
}
