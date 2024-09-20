﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelGestSystem.Aplication.DTOs.Auth
{
    public class RegistrarNuevoUsuarioDto
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string Telefono { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public bool EstaActivo { get; set; } = true;
        public bool EsAdmin { get; set; } = false;

    }
}
