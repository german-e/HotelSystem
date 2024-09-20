using HotelGestSystem.Domain.Shared.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelGestSystem.Aplication.Seguridad
{
    public class UserManager
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string Salt { get; set; }
        public string Hash { get; set; }
        public UserManager()
        {
            DatosPrueba();
        }

        private void DatosPrueba()
        {
            var salt = Seguridad.PasswordHelper.GenerarSalt();

            Salt = Convert.ToBase64String(salt);

            Username = "german_e";

            Hash = Seguridad.PasswordHelper.HashPassword("esunsecreto", salt);
        }

        public bool Login(string username, string password)
        {

            bool usernameEsValido = string.Equals(username, Username,StringComparison.OrdinalIgnoreCase);
            if (!usernameEsValido) 
                return false;

            bool passwordIsValid = Seguridad.PasswordHelper.VerificarPassword(password, Hash, Salt);

            if (!passwordIsValid)
                return false;


            return true;
        }


        public bool TienePermiso(Usuario usuario, string permiso)
        {
            if (usuario.EsAdmin) return true;

            foreach (Rol rol in usuario.Roles)
            {
                rol.Per
            }
            
        }

    }
}
