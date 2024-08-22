using HotelGestSystem.Domain.Receptionist.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelGestSystem.Domain.Receptionist.States
{
    public abstract class RoomState
    {
        
        public abstract string ShowState();

        public abstract void Handle();
       
    }
}
