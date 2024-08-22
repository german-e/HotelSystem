using HotelGestSystem.Domain.Receptionist.States;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelGestSystem.Domain.Receptionist.Entities
{
    public class Room
    {

        private RoomState _state;
        public string Number { get; set; }
        public string CustomId { get; set; }
        public TypeRoom CategoryRoom { get; set; }
        public int Floor { get; set; }  //0 -> ground floor,  1-> first floor, etc.

        public string Description { get; set; }

        public Room(RoomState state)
        {
            _state = state;
        }
        public void SwitchStateTo(RoomState newState)
        {
            _state = newState;
        }


    }
}
