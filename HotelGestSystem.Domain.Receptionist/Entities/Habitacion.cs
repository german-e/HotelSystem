using HotelGestSystem.Domain.Receptionist.Contracts;
using HotelGestSystem.Domain.Receptionist.States;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelGestSystem.Domain.Receptionist.Entities
{
    public class Habitacion
    {
        private readonly IHabitacionRepository _repository;


        private EstadoHabitacion _state;

        public string Numero { get; set; }
        public string Codigo { get; set; }
        public Categoria Categoria { get; set; }
        public int Piso { get; set; }  //0 -> ground floor,  1-> first floor, etc.

        public string Descripcion { get; set; }

        public Habitacion(EstadoHabitacion state)
        {
            _state = state;
        }
        public void CambiarEstadoA(EstadoHabitacion nuevoEstado)
        {
            _state = nuevoEstado;
        }

        public List<Habitacion> ObtenerHabitaciones()
        {

            return new List<Habitacion>(); 
    
        }

        public void AgregarHabitacion(Habitacion habitacion)
        {

        }


    }
}
