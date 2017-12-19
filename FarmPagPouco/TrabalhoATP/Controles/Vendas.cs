using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrabalhoATP.Classes;
using TrabalhoATP.Formularios;

namespace TrabalhoATP.Controles
{
    public partial class Vendas : UserControl
    {


		public Vendas()
        {
            InitializeComponent();

		}

        //ocorre quando o botão novo é clicado
        private void butNew_Click(object sender, EventArgs e)
        {
            AddVendas formAddVendas = new AddVendas();
            formAddVendas.Show();
        }

        //ocorre quando o botão Deletar é clicado
        private void butDel_Click(object sender, EventArgs e)
        {
            //verifica o tanto de linha no datagrid, se for zero não executa 
            if (Program._controlVendas.dataGrid.RowCount == 0)
                return;

            //obtem o codigo da vanda selecionado pela celula do datagrid
            string codigo = (string)Program._controlVendas.dataGrid.Rows[Program._controlVendas.dataGrid.SelectedCells[0].RowIndex].Cells[0].Value;

            //Escreve: "Codigo: " para poder fazer a busca correta
            codigo = ("Codigo: " + codigo);

            Geral.DeletarLinha(Program.pathVenda, codigo);
            Atualizar();

        }

		//Função de atualizar o data grid do controle
		public void Atualizar()
		{
			//Declara um vetor de classe do tipo 'Classes.Clientes'
			Classes.Vendas[] vendas;

			//Declrar vetor de string vai conter as linhas do arquivo
			string[] linhas = null;

			int cont = 0;

			//Declrar vetor de string vai conter os dados do cliente (Codigo, produto, quantidade, valorTotal, codigoCliente, codigoFuncionario, convenios, dataVenda)
			string[] dadosVenda = new string[4];

			//obtem os linhas do arquivo separada po vetor
			linhas = Geral.LerArquivo(Program.pathVenda);

			//instancia o vetor da calsse clientes
			vendas = new Classes.Vendas[linhas.Length - 1];

			if (boxFuncionario.Text == "" && boxCliente.Text == "")
				for (int i = 0; i < (linhas.Length - 1); i++)
				{
					//dadosVenda[0] = codigo
					//dadosVenda[1] = produto
					//dadosVenda[2] = quantidade
					//dadosVenda[3] = valorTotal
					//dadosVenda[4] = codigoCliente
					//dadosVenda[5] = codigoFuncionario
					//dadosVenda[6] = convenios
					//dadosVenda[7] = valorFinal
					//dadosVenda[8] = dataVenda
					dadosVenda = linhas[i].Split('|');

					//para funcionar é necessario instaciar cada menbro do vetor de clase 
					vendas[i] = new Classes.Vendas();

					vendas[i].codigo = dadosVenda[0].Remove(0, 8);//dadosVenda[0] = Codigo
					vendas[i].produto = dadosVenda[1].Remove(0, 9);//dadosVenda[1] = produto
					vendas[i].quantidade = dadosVenda[2].Remove(0, 12);//dadosVenda[2] = quantidade
					vendas[i].valorTotal = dadosVenda[3].Remove(0, 12);//dadosVenda[3] = valorTotal
					vendas[i].codigoCliente = dadosVenda[4].Remove(0, 15);//dadosVenda[4] = codigoCliente
					vendas[i].codigoFuncionario = dadosVenda[5].Remove(0, 19);//dadosVenda[5] = codigoFuncionario
					vendas[i].convenios = dadosVenda[6].Remove(0, 11);//dadosVenda[6] = convenios
					vendas[i].valorFinal = dadosVenda[7].Remove(0, 12);//dadosVenda[7] = valorFinal
					vendas[i].dataVenda = dadosVenda[8].Remove(0, 11);//dadosVenda[8] = dataVenda
				}

			//selecionado Funcionario
			if (boxFuncionario.Text != "" && boxCliente.Text == "")
				for (int i = 0; i < (linhas.Length - 1); i++)
				{
					//dadosVenda[0] = codigo
					//dadosVenda[1] = produto
					//dadosVenda[2] = quantidade
					//dadosVenda[3] = valorTotal
					//dadosVenda[4] = codigoCliente
					//dadosVenda[5] = codigoFuncionario
					//dadosVenda[6] = convenios
					//dadosVenda[7] = valorFinal
					//dadosVenda[8] = dataVenda
					dadosVenda = linhas[i].Split('|');
					if (dadosVenda[5].Remove(0, 19) == boxFuncionario.Text)
					{
						//para funcionar é necessario instaciar cada menbro do vetor de clase 
						vendas[i - cont] = new Classes.Vendas();

						vendas[i - cont].codigo = dadosVenda[0].Remove(0, 8);//dadosVenda[0] = Codigo
						vendas[i - cont].produto = dadosVenda[1].Remove(0, 9);//dadosVenda[1] = produto
						vendas[i - cont].quantidade = dadosVenda[2].Remove(0, 12);//dadosVenda[2] = quantidade
						vendas[i - cont].valorTotal = dadosVenda[3].Remove(0, 12);//dadosVenda[3] = valorTotal
						vendas[i - cont].codigoCliente = dadosVenda[4].Remove(0, 15);//dadosVenda[4] = codigoCliente
						vendas[i - cont].codigoFuncionario = dadosVenda[5].Remove(0, 19);//dadosVenda[5] = codigoFuncionario
						vendas[i - cont].convenios = dadosVenda[6].Remove(0, 11);//dadosVenda[6] = convenios
						vendas[i - cont].valorFinal = dadosVenda[7].Remove(0, 12);//dadosVenda[7] = valorFinal
						vendas[i - cont].dataVenda = dadosVenda[8].Remove(0, 11);//dadosVenda[8] = dataVenda
					}
					else
						cont++;
				}

			//Selecionado Cliente
			if (boxFuncionario.Text == "" && boxCliente.Text != "")
				for (int i = 0; i < (linhas.Length - 1); i++)
				{
					//dadosVenda[0] = codigo
					//dadosVenda[1] = produto
					//dadosVenda[2] = quantidade
					//dadosVenda[3] = valorTotal
					//dadosVenda[4] = codigoCliente
					//dadosVenda[5] = codigoFuncionario
					//dadosVenda[6] = convenios
					//dadosVenda[7] = valorFinal
					//dadosVenda[8] = dataVenda
					dadosVenda = linhas[i].Split('|');
					if (dadosVenda[4].Remove(0, 15) == boxCliente.Text)
					{
						//para funcionar é necessario instaciar cada menbro do vetor de clase 
						vendas[i - cont] = new Classes.Vendas();

						vendas[i - cont].codigo = dadosVenda[0].Remove(0, 8);//dadosVenda[0] = Codigo
						vendas[i - cont].produto = dadosVenda[1].Remove(0, 9);//dadosVenda[1] = produto
						vendas[i - cont].quantidade = dadosVenda[2].Remove(0, 12);//dadosVenda[2] = quantidade
						vendas[i - cont].valorTotal = dadosVenda[3].Remove(0, 12);//dadosVenda[3] = valorTotal
						vendas[i - cont].codigoCliente = dadosVenda[4].Remove(0, 15);//dadosVenda[4] = codigoCliente
						vendas[i - cont].codigoFuncionario = dadosVenda[5].Remove(0, 19);//dadosVenda[5] = codigoFuncionario
						vendas[i - cont].convenios = dadosVenda[6].Remove(0, 11);//dadosVenda[6] = convenios
						vendas[i - cont].valorFinal = dadosVenda[7].Remove(0, 12);//dadosVenda[7] = valorFinal
						vendas[i - cont].dataVenda = dadosVenda[8].Remove(0, 11);//dadosVenda[8] = dataVenda
					}
					else
						cont++;
				}

			//Selecionado Cliente e Funcionario
			if (boxFuncionario.Text != "" && boxCliente.Text != "")
				for (int i = 0; i < (linhas.Length - 1); i++)
				{
					//dadosVenda[0] = codigo
					//dadosVenda[1] = produto
					//dadosVenda[2] = quantidade
					//dadosVenda[3] = valorTotal
					//dadosVenda[4] = codigoCliente
					//dadosVenda[5] = codigoFuncionario
					//dadosVenda[6] = convenios
					//dadosVenda[7] = valorFinal
					//dadosVenda[8] = dataVenda
					dadosVenda = linhas[i].Split('|');
					if (dadosVenda[4].Remove(0, 15) == boxCliente.Text || dadosVenda[5].Remove(0, 19) == boxFuncionario.Text)
					{
						//para funcionar é necessario instaciar cada menbro do vetor de clase 
						vendas[i - cont] = new Classes.Vendas();

						vendas[i - cont].codigo = dadosVenda[0].Remove(0, 8);//dadosVenda[0] = Codigo
						vendas[i - cont].produto = dadosVenda[1].Remove(0, 9);//dadosVenda[1] = produto
						vendas[i - cont].quantidade = dadosVenda[2].Remove(0, 12);//dadosVenda[2] = quantidade
						vendas[i - cont].valorTotal = dadosVenda[3].Remove(0, 12);//dadosVenda[3] = valorTotal
						vendas[i - cont].codigoCliente = dadosVenda[4].Remove(0, 15);//dadosVenda[4] = codigoCliente
						vendas[i - cont].codigoFuncionario = dadosVenda[5].Remove(0, 19);//dadosVenda[5] = codigoFuncionario
						vendas[i - cont].convenios = dadosVenda[6].Remove(0, 11);//dadosVenda[6] = convenios
						vendas[i - cont].valorFinal = dadosVenda[7].Remove(0, 12);//dadosVenda[7] = valorFinal
						vendas[i - cont].dataVenda = dadosVenda[8].Remove(0, 11);//dadosVenda[8] = dataVenda
					}
					else
						cont++;
				}
			//Atualiza o datagrid
			BindingSource.DataSource = vendas;
		}

		//ocorre quando o botão Editar é clicado
		private void Edit_Click(object sender, EventArgs e)
		{
			//verifica o tanto de linha no datagrid, se for zero não executa

			if (Program._controlVendas.dataGrid.RowCount == 0)
				return;

			
			//instacia e chama o novo formulario de editar clientes
			EditVendas editVendas = new EditVendas();
			Edit.Enabled = false;
			editVendas.ShowDialog();
			Atualizar();
		}

		private void removCliente_Click(object sender, EventArgs e)
		{
			boxCliente.SelectedItem = null;
			Atualizar();
		}

		private void removeFuncionario_Click(object sender, EventArgs e)
		{
			boxFuncionario.SelectedItem = null;
			Atualizar();
		}

		private void boxCliente_SelectedIndexChanged(object sender, EventArgs e)
		{
			Atualizar();
		}

		private void boxFuncionario_SelectedIndexChanged(object sender, EventArgs e)
		{
			Atualizar();
		}
	}
}
