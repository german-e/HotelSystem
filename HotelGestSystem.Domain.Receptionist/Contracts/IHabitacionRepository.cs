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
        List<Room> ObtenerTodas();
        Room ObtenerHabitacionPorNumero(string numero);
        void AgregarHabitacion();
        
        
        
    }
}
