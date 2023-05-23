using CCB_Controle.entidade;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CCB_Controle.controller
{
    internal class AnoController
    {
        public int Inserir(Anos obj)
        {
            using (SqlConnection con = new SqlConnection())
            {
                con.ConnectionString = Properties.Settings.Default.Configuração;
                SqlCommand cn = new SqlCommand();
                cn.CommandType = CommandType.Text;
                con.Open();
                cn.CommandText = "INSERT INTO ANOS (ano) values (@ano)";
                cn.Parameters.Add("ano", SqlDbType.Int).Value = obj.Ano;
                cn.Connection = con;
                int qtd = cn.ExecuteNonQuery();
                return qtd;
            }


            

        }
    }
}
