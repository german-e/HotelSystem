using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelGestSystem.Domain.Shared.Contracts
{
    public interface IBaseRepositorio<TEntity> where TEntity : class
    {
        void Agregar(TEntity entity);
        bool Elimnar(TEntity entity);
        List<TEntity> ObtenerTodos();
        TEntity ObtenerPorId(object Id);
    }
}
