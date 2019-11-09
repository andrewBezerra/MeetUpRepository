using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ESCOLA.INFRA;
using ESCOLA.Models;
using Dapper;  //MICRO ORM

namespace ESCOLA.REPOSITORIO
{
    //SOLID - 
    public class AlunoRepositorio : IAlunoRepositorio
    {
       private readonly IDB db;

        public AlunoRepositorio(IDB db)
        {
            this.db = db;
        }

        public void Adicionar(Aluno item)
        {
            using (var con = db.GetConnection())
            {
                con.Execute("INSERT INTO ALUNO (NOME,CPF) " +
                            " VALUES(@NOME,@CPF)",
                            new { NOME = item.Nome, CPF = item.CPF });
            }
        }

        public void Alterar(Aluno item)
        {
            throw new NotImplementedException();
        }

        public Aluno BuscarporID(int ID)
        {
            using (var con = db.GetConnection())
            {
                return con.QueryFirst<Aluno>("SELECT * FROM ALUNO WHERE ID=@ID",new {ID });
            }
        }

        public void Deletar(Aluno item)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Aluno> Listar()
        {
            using (var con = db.GetConnection())
            {
                return  con.Query<Aluno>("SELECT * FROM ALUNO ORDER BY NOME");
            }
        }
    }
}
