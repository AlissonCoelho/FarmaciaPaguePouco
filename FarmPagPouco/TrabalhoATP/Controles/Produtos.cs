using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrabalhoATP.Formularios;
using TrabalhoATP.Classes;

namespace TrabalhoATP.Controles
{
	public partial class Produtos : UserControl
	{
		public int _verificarEstoque;
		public Produtos()
		{
			InitializeComponent();
		}

		//ocorre quando o botão novo é clicado
		private void butNew_Click(object sender, EventArgs e)
		{
			AddProdutos formAddProdutos = new AddProdutos();
			formAddProdutos.ShowDialog();
		}

		//ocorre quando o botão Editar é clicado
		private void Edit_Click(object sender, EventArgs e)
		{
			//verifica o tanto de linha no datagrid, se for zero não executa 
			if (Program._controlProdutos.dataGrid.RowCount == 0)
				return;

			//instacia e chama o novo formulario de editar Produtos
			EditProdutos editProdutos = new EditProdutos();
			editProdutos.ShowDialog();
		}

		//Ocorre quando o botão deletar é clicado
		private void butDel_Click(object sender, EventArgs e)
		{
			//verifica o tanto de linha no datagrid, se for zero não executa 
			if (Program._controlProdutos.dataGrid.RowCount == 0)
				return;

			//obtem o codigo do Produtos selecionado pela celula do datagrid
			string codigo = (string)Program._controlProdutos.dataGrid.Rows[Program._controlProdutos.dataGrid.SelectedCells[0].RowIndex].Cells[0].Value;

			//Escreve: "Codigo: " para poder fazer a busca correta
			codigo = ("Codigo: " + codigo);

			Geral.DeletarLinha(Program.pathProdtos, codigo);
			Atualizar();
		}

		//Função de atualizar o data grid do controle
		//Essa função retorna um 'Classes.Produtos[]'
		//Estou fazendo isso para poder pegar os valores desse controle no controle de vendas
		public Classes.Produtos[] Atualizar()
		{
			//Declara um vetor de classe
			Classes.Produtos[] produtos;

			//Declrar vetor de string vai conter as linhas do arquivo
			string[] linhas = null;


			//Declrar vetor de string vai conter os dados do Produtos (Codigo, Nome, Endereço, Telefone)
			string[] dadosProdutos;

			//obtem os linhas do arquivo separada po vetor
			linhas = Geral.LerArquivo(Program.pathProdtos);

			int cont = 0;

			int estoque;

			//instancia o vetor da calsse Produtos
			produtos = new Classes.Produtos[linhas.Length - 1];

			//Todos Check Box Todos ou nenhum
			if ((checkBoxMedicamentos.Checked == true && checkBoxPerfumaria.Checked == true && checkBoxOutros.Checked == true) || (checkBoxMedicamentos.Checked == false && checkBoxPerfumaria.Checked == false && checkBoxOutros.Checked == false))
				for (int i = 0; i < (linhas.Length - 1); i++)
				{
					//dadosProdutose[0] = codigo
					//dadosProdutose[1] = descricao
					//dadosProdutose[2] = quantidade
					//dadosProdutose[3] = precoCusto
					//dadosProdutose[4] = precoVenda
					//dadosProdutose[5] = tipo
					dadosProdutos = linhas[i].Split('|');

					//Obtem a quantidade de produtos para filtrar
					estoque = int.Parse(dadosProdutos[2].Remove(0, 12));

					if (estoque <= _verificarEstoque) 
					{
						//para funcionar é necessario instaciar cada menbro do vetor de clase 
						produtos[i - cont] = new Classes.Produtos();

						produtos[i - cont].codigo = dadosProdutos[0].Remove(0, 8);
						produtos[i - cont].descricao = dadosProdutos[1].Remove(0, 11);
						produtos[i - cont].quantidade = dadosProdutos[2].Remove(0, 12);
						produtos[i - cont].precoCusto = dadosProdutos[3].Remove(0, 12);
						produtos[i - cont].precoVenda = dadosProdutos[4].Remove(0, 12);
						produtos[i - cont].tipo = dadosProdutos[5].Remove(0, 6);
					}
					else
						cont++;
				}

			//Check Box Medicamentos e Perfumaria
			else if (checkBoxMedicamentos.Checked == true && checkBoxPerfumaria.Checked == true)
				for (int i = 0; i < (linhas.Length - 1); i++)
				{

					//Medicamentos
					//Perfumaria
					//Outros

					//dadosProdutose[0] = codigo
					//dadosProdutose[1] = descricao
					//dadosProdutose[2] = quantidade
					//dadosProdutose[3] = precoCusto
					//dadosProdutose[4] = precoVenda
					//dadosProdutose[5] = tipo
					dadosProdutos = linhas[i].Split('|');

					//Obtem a quantidade de produtos para filtrar
					estoque = int.Parse(dadosProdutos[2].Remove(0, 12));

					if (dadosProdutos[5].Remove(0, 6) == "Medicamentos" || dadosProdutos[5].Remove(0, 6) == "Perfumaria" && estoque <= _verificarEstoque)
					{
						//para funcionar é necessario instaciar cada menbro do vetor de clase 
						produtos[i - cont] = new Classes.Produtos();

						produtos[i - cont].codigo = dadosProdutos[0].Remove(0, 8);
						produtos[i - cont].descricao = dadosProdutos[1].Remove(0, 11);
						produtos[i - cont].quantidade = dadosProdutos[2].Remove(0, 12);
						produtos[i - cont].precoCusto = dadosProdutos[3].Remove(0, 12);
						produtos[i - cont].precoVenda = dadosProdutos[4].Remove(0, 12);
						produtos[i - cont].tipo = dadosProdutos[5].Remove(0, 6);
					}
					else
						cont++;
				}

			//Check Box Medicamentos e Outros
			else if (checkBoxMedicamentos.Checked == true && checkBoxOutros.Checked == true)
				for (int i = 0; i < (linhas.Length - 1); i++)
				{
					//dadosProdutose[0] = codigo
					//dadosProdutose[1] = descricao
					//dadosProdutose[2] = quantidade
					//dadosProdutose[3] = precoCusto
					//dadosProdutose[4] = precoVenda
					//dadosProdutose[5] = tipo
					dadosProdutos = linhas[i].Split('|');

					//Obtem a quantidade de produtos para filtrar
					estoque = int.Parse(dadosProdutos[2].Remove(0, 12));

					if (dadosProdutos[5].Remove(0, 6) == "Medicamentos" || dadosProdutos[5].Remove(0, 6) == "Outros" && estoque <= _verificarEstoque)
					{
						//para funcionar é necessario instaciar cada menbro do vetor de clase 
						produtos[i - cont] = new Classes.Produtos();


						produtos[i - cont].codigo = dadosProdutos[0].Remove(0, 8);
						produtos[i - cont].descricao = dadosProdutos[1].Remove(0, 11);
						produtos[i - cont].quantidade = dadosProdutos[2].Remove(0, 12);
						produtos[i - cont].precoCusto = dadosProdutos[3].Remove(0, 12);
						produtos[i - cont].precoVenda = dadosProdutos[4].Remove(0, 12);
						produtos[i - cont].tipo = dadosProdutos[5].Remove(0, 6);
					}
					else
						cont++;
				}

			//Check Box Outros e Perfumaria
			else if (checkBoxOutros.Checked == true && checkBoxPerfumaria.Checked == true)
				for (int i = 0; i < (linhas.Length - 1); i++)
				{
					//dadosProdutose[0] = codigo
					//dadosProdutose[1] = descricao
					//dadosProdutose[2] = quantidade
					//dadosProdutose[3] = precoCusto
					//dadosProdutose[4] = precoVenda
					//dadosProdutose[5] = tipo
					dadosProdutos = linhas[i].Split('|');

					//Obtem a quantidade de produtos para filtrar
					estoque = int.Parse(dadosProdutos[2].Remove(0, 12));


					if (dadosProdutos[5].Remove(0, 6) == "Perfumaria" || dadosProdutos[5].Remove(0, 6) == "Outros" && estoque <= _verificarEstoque)
					{
						//para funcionar é necessario instaciar cada menbro do vetor de clase 
						produtos[i - cont] = new Classes.Produtos();


						produtos[i - cont].codigo = dadosProdutos[0].Remove(0, 8);
						produtos[i - cont].descricao = dadosProdutos[1].Remove(0, 11);
						produtos[i - cont].quantidade = dadosProdutos[2].Remove(0, 12);
						produtos[i - cont].precoCusto = dadosProdutos[3].Remove(0, 12);
						produtos[i - cont].precoVenda = dadosProdutos[4].Remove(0, 12);
						produtos[i - cont].tipo = dadosProdutos[5].Remove(0, 6);
					}
					else
						cont++;
				}
			//Check Box Medicamentos
			else if (checkBoxMedicamentos.Checked == true)
				for (int i = 0; i < (linhas.Length - 1); i++)
				{
					//dadosProdutose[0] = codigo
					//dadosProdutose[1] = descricao
					//dadosProdutose[2] = quantidade
					//dadosProdutose[3] = precoCusto
					//dadosProdutose[4] = precoVenda
					//dadosProdutose[5] = tipo
					dadosProdutos = linhas[i].Split('|');

					//Obtem a quantidade de produtos para filtrar
					estoque = int.Parse(dadosProdutos[2].Remove(0, 12));


					if (dadosProdutos[5].Remove(0, 6) == "Medicamentos" && estoque <= _verificarEstoque)
					{
						//para funcionar é necessario instaciar cada menbro do vetor de clase 
						produtos[i - cont] = new Classes.Produtos();

						produtos[i - cont].codigo = dadosProdutos[0].Remove(0, 8);
						produtos[i - cont].descricao = dadosProdutos[1].Remove(0, 11);
						produtos[i - cont].quantidade = dadosProdutos[2].Remove(0, 12);
						produtos[i - cont].precoCusto = dadosProdutos[3].Remove(0, 12);
						produtos[i - cont].precoVenda = dadosProdutos[4].Remove(0, 12);
						produtos[i - cont].tipo = dadosProdutos[5].Remove(0, 6);
					}
					else
						cont++;
				}

			//Check Box Perfumaria
			else if (checkBoxPerfumaria.Checked == true)
				for (int i = 0; i < (linhas.Length - 1); i++)
				{
					//dadosProdutose[0] = codigo
					//dadosProdutose[1] = descricao
					//dadosProdutose[2] = quantidade
					//dadosProdutose[3] = precoCusto
					//dadosProdutose[4] = precoVenda
					//dadosProdutose[5] = tipo
					dadosProdutos = linhas[i].Split('|');


					//Obtem a quantidade de produtos para filtrar
					estoque = int.Parse(dadosProdutos[2].Remove(0, 12));


					if (dadosProdutos[5].Remove(0, 6) == "Perfumaria" && estoque <= _verificarEstoque)
					{
						//para funcionar é necessario instaciar cada menbro do vetor de clase 
						produtos[i - cont] = new Classes.Produtos();

						produtos[i - cont].codigo = dadosProdutos[0].Remove(0, 8);
						produtos[i - cont].descricao = dadosProdutos[1].Remove(0, 11);
						produtos[i - cont].quantidade = dadosProdutos[2].Remove(0, 12);
						produtos[i - cont].precoCusto = dadosProdutos[3].Remove(0, 12);
						produtos[i - cont].precoVenda = dadosProdutos[4].Remove(0, 12);
						produtos[i - cont].tipo = dadosProdutos[5].Remove(0, 6);
					}
					else
						cont++;
				}

			//Check Box Outros
			else if (checkBoxOutros.Checked == true)
				for (int i = 0; i < (linhas.Length - 1); i++)
				{
					//dadosProdutose[0] = codigo
					//dadosProdutose[1] = descricao
					//dadosProdutose[2] = quantidade
					//dadosProdutose[3] = precoCusto
					//dadosProdutose[4] = precoVenda
					//dadosProdutose[5] = tipo
					dadosProdutos = linhas[i].Split('|');

					//Obtem a quantidade de produtos para filtrar
					estoque = int.Parse(dadosProdutos[2].Remove(0, 12));


					if (dadosProdutos[5].Remove(0, 6) == "Outros" && estoque <= _verificarEstoque)
					{
						//para funcionar é necessario instaciar cada menbro do vetor de clase 
						produtos[i - cont] = new Classes.Produtos();

						produtos[i - cont].codigo = dadosProdutos[0].Remove(0, 8);
						produtos[i - cont].descricao = dadosProdutos[1].Remove(0, 11);
						produtos[i - cont].quantidade = dadosProdutos[2].Remove(0, 12);
						produtos[i - cont].precoCusto = dadosProdutos[3].Remove(0, 12);
						produtos[i - cont].precoVenda = dadosProdutos[4].Remove(0, 12);
						produtos[i - cont].tipo = dadosProdutos[5].Remove(0, 6);
					}
					else
						cont++;
				}


			//Atualiza o datagrid
			BindingSource.DataSource = produtos;
			return produtos;
		}

		//Ocorre quando clica no check box medicamentos
		private void checkBoxMedicamentos_CheckedChanged(object sender, EventArgs e)
		{
			Atualizar();
		}

		//Ocorre quando clica no check box perfumaria
		private void checkBoxPerfumaria_CheckedChanged(object sender, EventArgs e)
		{
			Atualizar();
		}

		//Ocorre quando clica no check box outros
		private void checkBoxOutros_CheckedChanged(object sender, EventArgs e)
		{
			Atualizar();
		}

        //Ocorre quando o texto do campo Verificar estoque é alterado
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(textBox1.Text, out _verificarEstoque))
            {
                Atualizar();
            }
            else if (textBox1.Text == "")
            {
                _verificarEstoque = 2147483647;
                Atualizar();
                return;
            }
            else
            {
                MessageBox.Show("Digite somente numeros", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox1.Text = "";
            }
        }

        private void Produtos_Load(object sender, EventArgs e)
		{
			_verificarEstoque = 2147483647;
		}

        private void removEstoque_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            _verificarEstoque = 2147483647;
        }
    }
}
