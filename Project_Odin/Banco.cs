using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SQLite;
using System.Data.SqlClient;

namespace Project_Odin
{
    internal class Banco
    {
        private static SQLiteConnection conexao;

        // Abre a conexão com Banco de dados
        private static SQLiteConnection ConexaoBanco()
        {
            conexao= new SQLiteConnection("Data Source=" + Globais.caminhoBanco + Globais.nomeBanco);
            conexao.Open();
            return conexao;
        }

        public static DataTable dql(string sql)
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();
            try
            {
                var vcon = ConexaoBanco();
                var cmd = vcon.CreateCommand();
                cmd.CommandText = sql;
                da = new SQLiteDataAdapter(cmd.CommandText, vcon);
                da.Fill(dt);
                vcon.Close();
                return dt;
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        public static void dml(string q, string msgOK = null, string msgError = null)
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();
            try
            {
                var vcon = ConexaoBanco();
                var cmd = vcon.CreateCommand();
                cmd.CommandText = q;
                da = new SQLiteDataAdapter(cmd.CommandText, vcon);
                cmd.ExecuteNonQuery();
                vcon.Close();
                if (msgOK != null)
                {
                    MessageBox.Show(msgOK);
                }
            }
            catch (Exception ex)
            {
                if (msgError != null)
                {
                    MessageBox.Show(msgError + "\n" + ex.Message);
                }
                throw ex;
            }
        }
    }
}
