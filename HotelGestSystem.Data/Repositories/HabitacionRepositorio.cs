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

        public Domain.Receptionist.Entities.Habitacion ObtenerHabitacionPorNumero(string numero)
        {
            throw new NotImplementedException();
        }

        public List<Domain.Receptionist.Entities.Habitacion> ObtenerTodas()
        {
            List<Model.Habitacion> habs = new List<Model.Habitacion>();

            List<Domain.Receptionist.Entities.Habitacion> result = new List<Domain.Receptionist.Entities.Habitacion>();

            //Datos de muestra
            Model.Habitacion hab1 = new Model.Habitacion();
            hab1.Id = 1;
            hab1.Camas = 1;
            hab1.CapacidadPersonas = 2;
            hab1.Descripcion = "Habitación Simple para dos personas, 1 cama matrimonial - baños - TV AA";
            hab1.Precio = 12542.25M;
            hab1.CategoriaId = 1;

            Model.Habitacion hab2 = new Model.Habitacion();
            hab2.Camas = 2;
            hab2.CapacidadPersonas = 4;
            hab2.Descripcion = "Habitación Doble, 1 cama matrimonial y una cama 1 plaza - baños - TV AA";
            hab2.Precio = 2255.25M;
            hab2.CategoriaId = 2;

            Model.Habitacion hab3 = new Model.Habitacion();
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
                    CategoryRoom = new Domain.Receptionist.Entities.Categoria { Capacidad = 2, Descripcion = hab.Descripcion, Nombre = "Simple", Precio = 125.25M },
                    Description = hab.Descripcion,
                    Floor = 0, CustomId = "102A"
                    
                });
            }


            return result;
        }

       
    }
}
