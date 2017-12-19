using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrabalhoATP
{
    static class Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        /// 

        //declarados controles como globais para serem acesiveis de qualquer parte do programa
        public static Controles.Clientes _controlCliente;
        public static Controles.Funcionarios _controlfunc;
        public static Controles.Produtos _controlProdutos;
        public static Controles.Convenios _controlConvenios;
        public static Controles.Vendas _controlVendas;

        //Declarado path globais para não correr o risco de erra e facilitar casso precise mudar o caminho
        public static string pathClientes = "Arquivos/clientes.txt";
        public static string pathFunc = "Arquivos/funcionarios.txt";
        public static string pathProdtos = "Arquivos/produtos.txt";
        public static string pathConvenios = "Arquivos/convenios.txt";
        public static string pathVenda = "Arquivos/venda.txt";

        [STAThread]

        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new principal());
        }

    }
}
