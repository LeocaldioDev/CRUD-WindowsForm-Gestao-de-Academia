using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projecto_Gestão_de_Academia
{
    internal class Globais
    {
        public static string versao = "1.0";
        public static bool logado = false;
        public static int nivel = 0;

        // public static string conexao = System.Environment.CurrentDirectory;
        public static string conexao = System.AppDomain.CurrentDomain.BaseDirectory.ToString();
        public static string nomeBanco = "BD_ACADEMIA.db";
        public static string caminhoBanco = conexao + @"\banco\";
        public static string caminhoFoto = conexao + @"\foto\";
    }
}
