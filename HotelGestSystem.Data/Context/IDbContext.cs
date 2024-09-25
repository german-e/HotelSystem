using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelGestSystem.Data.Context
{
    public interface IDbContext
    {
        IDbConnection CrearConexion();

        bool GuardarCambios();
    }
}
