using HotelGestSystem.Domain.Receptionist.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelGestSystem.Domain.Receptionist.States
{
    public abstract class EstadoHabitacion
    {
        
        public abstract string MostrarEstado();

        public abstract void Handle();
       
    }
}
