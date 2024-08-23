using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelGestSystem.Data.Model
{
    public class Rol
    {
        public int Id { get; set; }
        public string NombreRol { get; set; }
        public string Descripcion { get; set; }

        public ICollection<Usuario> Usuarios { get; set; }
    }
}
