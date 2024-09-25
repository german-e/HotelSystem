using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelGestSystem.Data.Context
{
    public class SqlServerDbContext : IDbContext
    {

        private readonly string _connectionString;


        public SqlServerDbContext(string connectionString)
        {
            _connectionString = connectionString;
        }
        public IDbConnection CrearConexion()
        {
            return new SqlConnection(_connectionString);
        }

        public bool GuardarCambios()
        {
            throw new NotImplementedException();
        }
    }
}

