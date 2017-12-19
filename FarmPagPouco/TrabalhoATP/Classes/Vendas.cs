using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoATP.Classes
{
	public class Vendas
	{
		public string codigo { get; set; }
        public string produto { get; set; }
        public string quantidade { get; set; }
        public string valorTotal { get; set; }
        public string codigoCliente { get; set; }
        public string codigoFuncionario { get; set; }
        public string convenios { get; set; }
		public string valorFinal { get; set; }
		public string dataVenda { get; set; }
	}
}
