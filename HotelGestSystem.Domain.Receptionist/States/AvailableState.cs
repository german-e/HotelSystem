using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelGestSystem.Domain.Receptionist.States
{
    public class AvailableState : RoomState
    {
        public override void Handle()
        {
            
        }

        

        public override string ShowState()
        {
            return "Disponible";
        }
    }
}
