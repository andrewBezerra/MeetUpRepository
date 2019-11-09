using ESCOLA.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ESCOLA.REPOSITORIO
{
    public interface IAlunoRepositorio
    {
        void Adicionar(Aluno item);
        void Alterar(Aluno item);
        Aluno BuscarporID(int ID);
        IEnumerable<Aluno> Listar();
    }
}
