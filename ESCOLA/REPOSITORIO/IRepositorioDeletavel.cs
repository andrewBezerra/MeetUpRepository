using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ESCOLA.REPOSITORIO
{
    public interface IRepositorioDeletavel<T>
    {
        void Deletar(T item);
      
    }
}
