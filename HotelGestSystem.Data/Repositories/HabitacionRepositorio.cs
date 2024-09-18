using HotelGestSystem.Data.Model;
using HotelGestSystem.Domain.Receptionist.Contracts;
using HotelGestSystem.Domain.Receptionist.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelGestSystem.Data.Repositories
{
    public class HabitacionRepositorio :IHabitacionRepository
    {
        public void AgregarHabitacion()
        {
            throw new NotImplementedException();
        }

        public Room ObtenerHabitacionPorNumero(string numero)
        {
            throw new NotImplementedException();
        }

        public List<Room> ObtenerTodas()
        {
            List<Habitacion> habs = new List<Habitacion>();

            List<Room> result = new List<Room>();

            //Datos de muestra
            Habitacion hab1 = new Habitacion();
            hab1.Id = 1;
            hab1.Camas = 1;
            hab1.CapacidadPersonas = 2;
            hab1.Descripcion = "Habitación Simple para dos personas, 1 cama matrimonial - baños - TV AA";
            hab1.Precio = 12542.25M;
            hab1.CategoriaId = 1;

            Habitacion hab2 = new Habitacion();
            hab2.Camas = 2;
            hab2.CapacidadPersonas = 4;
            hab2.Descripcion = "Habitación Doble, 1 cama matrimonial y una cama 1 plaza - baños - TV AA";
            hab2.Precio = 2255.25M;
            hab2.CategoriaId = 2;

            Habitacion hab3 = new Habitacion();
            hab3.Camas = 2;
            hab3.CapacidadPersonas = 3;
            hab3.Descripcion = "Habitación 3 cama 1 plaza - baños - TV AA";
            hab3.Precio = 3055.25M;
            hab3.CategoriaId = 2;


            habs.Add(hab1 );
            habs.Add( hab2 );
            habs.Add(hab3);

            foreach (var hab in habs)
            {
                result.Add(new Room
                {
                    Number = hab.Numero,
                    CategoryRoom = new TypeRoom { Capacity = 2, Description = hab.Descripcion, Name = "Simple", Price = 125.25M },
                    Description = hab.Descripcion,
                    Floor = 0, CustomId = "102A"
                    
                });
            }


            return result;
        }

       
    }
}
