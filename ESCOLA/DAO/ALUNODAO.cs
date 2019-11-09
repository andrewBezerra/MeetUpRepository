using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace ESCOLA.DAO
{
    public class ALUNODAO
    {
        public MySqlConnection con = new MySqlConnection(@"SERVER=ANDREW-SURFACE\ANDREWSQL; INITIAL CATALOG=ESCOLA; USER ID=sa;PASSWORD=123");
       
        public int ID { get; set; }
        public string Nome { get; set; }
        public string CPF { get; set; }

        public List<ALUNODAO> Alunos { get; set; }

        public void INCLUIR(string Nome, string CPF,string endereco,string numero,string bairro)
        {
            if(con.State==ConnectionState.Closed)
                con.Open();

            MySqlCommand com = new MySqlCommand("INSERT INTO ALUNO (NOME,CPF,ENDERECO,NUMERO,BAIRRO) VALUES(@NOME,@CPF,@ENDERECO,@NUMERO,@BAIRRO)",con);
            com.Parameters.AddWithValue("@NOME", Nome);
            com.Parameters.AddWithValue("@CPF", CPF);
            com.Parameters.AddWithValue("@ENDERECO", endereco);
            com.Parameters.AddWithValue("@NUMERO", numero);
            com.Parameters.AddWithValue("@BAIRRO", bairro);
            com.ExecuteNonQuery();

            if (con.State==ConnectionState.Open)
                con.Close();
        }
        public void ALTERAR(int ID,string Nome, string CPF)
        {
            con.Open();
            MySqlCommand com = new MySqlCommand("UPDATE ALUNO SET NOME='" + Nome + "', CPF='" + CPF + "' WHERE ID="+ID+" )", con);
            com.ExecuteNonQuery();
            con.Close();
        }
        public void DELETAR(int ID)
        {
            con.Open();
            MySqlCommand com = new MySqlCommand("DELETE FROM ALUNO WHERE ID=" + ID + " )", con);
            com.ExecuteNonQuery();
            con.Close();
        }
        public DataSet LISTAR()
        {
            con.Open();
            MySqlCommand com = new MySqlCommand("SELECT * FROM ALUNO ORDER BY NOME ", con);
            MySqlDataAdapter Da = new MySqlDataAdapter(com);
            DataSet ds = new DataSet();
            Da.Fill(ds, "Alunos");
            con.Close();
            return ds;

        }
        public DataRow BUSCARPORID(int ID)
        {
            con.Open();
            MySqlCommand com = new MySqlCommand("SELECT * FROM ALUNO WHERE ID = "+ID, con);
            MySqlDataAdapter Da = new MySqlDataAdapter(com);
            DataSet ds = new DataSet();
            Da.Fill(ds, "Alunos");
            con.Close();
            return ds.Tables["Aluno"].Rows[0];

        }
    }
}
