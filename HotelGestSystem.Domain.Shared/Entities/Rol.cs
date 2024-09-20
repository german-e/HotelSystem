using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelGestSystem.Domain.Shared.Entities
{
    public class Rol
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public List<Permiso> Permisos { get; private set; }


        public Rol(int id, string nombre) 
        { 
            Id = id;
            Nombre = nombre;            
        }


        public void AgregarPermiso(Permiso permiso)
        {

        } 



    }
}
