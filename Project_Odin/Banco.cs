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
    }
}
