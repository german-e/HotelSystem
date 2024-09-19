using HotelGestSystem.Domain.Receptionist.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelGestSystem.Domain.Receptionist.Contracts
{
    public interface IHabitacionRepository
    {
        List<Habitacion> ObtenerTodas();
        Habitacion ObtenerHabitacionPorNumero(string numero);
        void AgregarHabitacion();
        
        
        
    }
}
