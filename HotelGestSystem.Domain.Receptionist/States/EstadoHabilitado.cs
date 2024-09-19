using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelGestSystem.Domain.Receptionist.States
{
    public class EstadoHabilitado : EstadoHabitacion
    {
        public override void Handle()
        {
            
        }

        

        public override string MostrarEstado()
        {
            return "Disponible";
        }
    }
}
