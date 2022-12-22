using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Odin
{
    internal class Globais
    {
        public static string versao = "1.0";
        public static Boolean logado = false;
        public static int nivel = 0; // 0=Basico - 1=Gerente - 2=Master

        // Globais para path da conexão com banco
        public static string caminho = System.AppDomain.CurrentDomain.BaseDirectory.ToString();
        public static string nomeBanco = "dados_ODIN.db";
        public static string caminhoBanco = caminho + @"\db\";

        // Adiciona o caminho para Fotos
        public static string caminhoFotos = caminho + @"\fotos\";
    }
}
