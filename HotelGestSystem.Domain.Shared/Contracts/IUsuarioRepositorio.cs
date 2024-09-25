using HotelGestSystem.Domain.Shared.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelGestSystem.Domain.Shared.Contracts
{
    public interface IUsuarioRepositorio : IBaseRepositorio<Usuario>
    {
        Usuario BuscarPorUsername(string username);


        
    }
}
