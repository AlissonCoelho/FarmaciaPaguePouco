using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrabalhoATP.Classes;

namespace TrabalhoATP.Formularios
{
	public partial class EditVendas : Form
	{

		int _quantidadeEditada;
		double valorVenda = 0;
		double desconto = 1;

		//Obtem os dados do produto selecionado
		Produtos _produto;

		//Obtem os dados do produto selecionado
		Convenios _convenio;

		string _codigo;
		string _dataVenda;
		int _quantidadeProdutosAnterior;

		//Initialize Component
		public EditVendas()
		{
			InitializeComponent();

			produtosBindingSource.DataSource = Program._controlProdutos.Atualizar();
			clientesBindingSource.DataSource = Program._controlCliente.Atualizar();
			funcionariosBindingSource.DataSource = Program._controlfunc.Atualizar();
			conveniosBindingSource.DataSource = Program._controlConvenios.Atualizar();

			//Atribuir Valores da linha selecionada no datagrid ao formulario de Edição
			texProduto.Text = (string)Program._controlVendas.dataGrid.Rows[Program._controlVendas.dataGrid.SelectedCells[0].RowIndex].Cells[1].Value;
			texProduto.SelectedItem = (string)Program._controlVendas.dataGrid.Rows[Program._controlVendas.dataGrid.SelectedCells[0].RowIndex].Cells[1].Value;

			//Obtem as propriedades do produto selecionado
			_produto = (Produtos)texProduto.SelectedValue;

			texQuantidade.Text = (string)Program._controlVendas.dataGrid.Rows[Program._controlVendas.dataGrid.SelectedCells[0].RowIndex].Cells[2].Value;
			texValor.Text = (string)Program._controlVendas.dataGrid.Rows[Program._controlVendas.dataGrid.SelectedCells[0].RowIndex].Cells[3].Value;
			texCliente.Text = (string)Program._controlVendas.dataGrid.Rows[Program._controlVendas.dataGrid.SelectedCells[0].RowIndex].Cells[4].Value;
			texCliente.SelectedItem = (string)Program._controlVendas.dataGrid.Rows[Program._controlVendas.dataGrid.SelectedCells[0].RowIndex].Cells[4].Value;
			texFuncionario.Text = (string)Program._controlVendas.dataGrid.Rows[Program._controlVendas.dataGrid.SelectedCells[0].RowIndex].Cells[5].Value;
			texFuncionario.SelectedItem = (string)Program._controlVendas.dataGrid.Rows[Program._controlVendas.dataGrid.SelectedCells[0].RowIndex].Cells[5].Value;
			if ((string)Program._controlVendas.dataGrid.Rows[Program._controlVendas.dataGrid.SelectedCells[0].RowIndex].Cells[6].Value == "")
				texConvenios.Text = null;
			else
			{
                //Obtem as propriedades do convenio selecionado
                _convenio = (Convenios)texConvenios.SelectedValue;

                texConvenios.Text = (string)Program._controlVendas.dataGrid.Rows[Program._controlVendas.dataGrid.SelectedCells[0].RowIndex].Cells[6].Value;
				//Converte o valor do desconto para double
				desconto = 1 - double.Parse(_convenio.desconto.Substring(0, 2)) / 100;
			}
			

			texConvenios.SelectedItem = (string)Program._controlVendas.dataGrid.Rows[Program._controlVendas.dataGrid.SelectedCells[0].RowIndex].Cells[6].Value;
			texValorFinal.Text = (string)Program._controlVendas.dataGrid.Rows[Program._controlVendas.dataGrid.SelectedCells[0].RowIndex].Cells[7].Value;

			//Obtem o valor de vanda do produto
			valorVenda = double.Parse(_produto.precoVenda.Substring(2));



		}

		//ocorre quando o formulario é fehchado
		private void EditVendas_FormClosed(object sender, FormClosedEventArgs e)
		{
			Program._controlVendas.Edit.Enabled = true;
		}

		//ocorre quando o campo quantidade é alterado
		private void texQuantidade_TextChanged(object sender, EventArgs e)
		{
			//Verifica se o campo contém so numero e se é interio //Obtem a quantidade de produtos atual
			if (!int.TryParse(texQuantidade.Text, out _quantidadeEditada))
			{
				MessageBox.Show("Digite somente numeros", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			int quantidadeProdutosAtual = 0;

			//verifica se tem algum texto no campo Produto
			if (texProduto.Text != "")
			{
				//Obtem a quantidade de produtos
				quantidadeProdutosAtual = int.Parse(_produto.quantidade);

			}
			else
				return;


			//operação para saber se adicionou ou removeu produtos, referente a quantidade anterior
			//como esta editando, se o valor que estava la era 5, ai começou a editar e colocou 6,
			//quer dizer que tem que subtrair somente uma unidade do estoque 
			int quantidadeProdutosModificada = _quantidadeProdutosAnterior - _quantidadeEditada;

			//verifica se a quantidade de produtos é suficiente para realizar a venda
			if (quantidadeProdutosAtual + quantidadeProdutosModificada < 0)
			{
				MessageBox.Show("Quantidade insuficiente", "Produtos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				return;
			}

			//realiza a operação de calcular a venda
			texValor.Text = "R$:" + (valorVenda * _quantidadeEditada);

			//realiza a operação de calcular o valor final
			decimal valorFinal = Convert.ToDecimal(valorVenda * _quantidadeEditada * desconto);
			texValorFinal.Text = "R$:" + Decimal.Round(valorFinal, 2);

		}

		//ocorre quando o campo Produto é alterado
		private void texProduto_SelectedIndexChanged(object sender, EventArgs e)
		{

			//verifica se tem algum produto selecionado
			if (texProduto.Text == "")
				return;

			//Obtem as propriedades do produto selecionado
			_produto = (Produtos)texProduto.SelectedValue;

			//Converte o valor da venda para double
			valorVenda = double.Parse(_produto.precoVenda.Substring(2));

			//realiza a operação de calcular a venda
			texValor.Text = "R$:" + (valorVenda * _quantidadeEditada);

			//realiza a operação de calcular o valor final
			decimal valorFinal = Convert.ToDecimal(valorVenda * _quantidadeEditada * desconto);
			texValorFinal.Text = "R$:" + Decimal.Round(valorFinal, 2);


		}

		//função para atualizar a quantidade de produtos
		private void AtualizarQuantidadeProduto()
		{
			string codigo = ("Codigo: " + _produto.codigo);
			string Descricao = ("Descricao: " + _produto.descricao);
			string Quantidade = (_produto.quantidade); //é formatado em baixo
			string precoCusto = ("precoCusto: " + _produto.precoCusto);
			string precoVenda = ("precoVenda: " + _produto.precoVenda);
			string tipo = ("tipo: " + _produto.tipo);

			string addLinha = (codigo + "|" + Descricao + "|" + Quantidade + "|" + precoCusto + "|" + precoVenda + "|" + tipo);

			// edita a linha no arquivo
			Geral.EditarArquivos(Program.pathProdtos, codigo, addLinha);
		}

		//Ocorre quando seleciona um convenio
		private void texConvenios_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (texConvenios.Text == "")
				return;


			//Obtem as propriedades do convenio selecionado
			_convenio = (Convenios)texConvenios.SelectedValue;

			//Converte o valor do desconto para double
			desconto = 1 - double.Parse(_convenio.desconto.Substring(0, 2)) / 100;

			//realiza a operação de calcular o valor final
			decimal valorFinal = Convert.ToDecimal(valorVenda * _quantidadeEditada * desconto);
			texValorFinal.Text = "R$:" + Decimal.Round(valorFinal, 2);

		}

		//Isso é Função, não é um evento, edita uma venda no arquivo Venda.txt
		private bool EditarVenda()
		{
			//algum campo não for preenchido 
			if (texQuantidade.Text == "0" || texQuantidade.Text == "")
			{
				MessageBox.Show("Preencha a quantidade de produtos", "Preencher", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				return false;
			}

			long verific1;

			//campo "Quantidade" somente com numeros 
			if (!long.TryParse(texQuantidade.Text, out verific1))
			{
				MessageBox.Show("Preencher campo 'Quantidade' somente com números", "Falha", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				return false;
			}

			if (texProduto.Text == "")
			{
				MessageBox.Show("Selecione um produto", "Preencher", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				return false;
			}

			if (texCliente.Text == "")
			{
				MessageBox.Show("Selecione um cliente", "Preencher", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				return false;
			}

			if (texFuncionario.Text == "")
			{
				MessageBox.Show("Selecione um funcionario", "Preencher", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				return false;
			}


			string produto = ("produto: " + texProduto.Text);
			string quantidade = ("quantidade: " + texQuantidade.Text);
			string valorTotal = ("valorTotal: " + texValor.Text);
			string codigoCliente = ("codigoCliente: " + texCliente.Text);
			string codigoFuncionario = ("codigoFuncionario: " + texFuncionario.Text);
			string convenios = ("convenios: " + texConvenios.Text);
			string valorFinal = ("valorFinal: " + texValorFinal.Text);

			_codigo = ("Codigo: " + _codigo);
			_dataVenda = ("dataVenda: " + _dataVenda);

			string addLinha = (_codigo + "|" + produto + "|" + quantidade + "|" + valorTotal + "|" + codigoCliente + "|" + codigoFuncionario + "|" + convenios + "|" + valorFinal + "|" + _dataVenda);

			// edita a linha no arquivo
			Geral.EditarArquivos(Program.pathVenda, _codigo, addLinha);

			//Obtem a quantidade de produtos no arquivo produto
			int quantidadeProdutosAtual = int.Parse(_produto.quantidade);

			//operação para saber se adicionou ou removeu produtos, referente a quantidade anterior
			//como esta editando, se o valor que estava la era 5, ai começou a editar e colocou 6,
			//quer dizer que tem que subtrair somente uma unidade do estoque 
			int quantidadeProdutosModificada = _quantidadeProdutosAnterior - _quantidadeEditada;

			if (quantidadeProdutosModificada != 0)
			{
				//escreve a nova quantidade de produtos
				_produto.quantidade = ("Quantidade: " + (quantidadeProdutosAtual + quantidadeProdutosModificada));

				//Arualiza no arquivo a quantidade de produtos
				AtualizarQuantidadeProduto();
			}


			return true;
		}

		//ocorre quando o botão ok é clicado
		private void botOk_Click(object sender, EventArgs e)
		{
			//obtem o codigo do produt selecionado pela celula do datagrid
			_codigo = (string)Program._controlVendas.dataGrid.Rows[Program._controlVendas.dataGrid.SelectedCells[0].RowIndex].Cells[0].Value;
			_dataVenda = (string)Program._controlVendas.dataGrid.Rows[Program._controlVendas.dataGrid.SelectedCells[0].RowIndex].Cells[8].Value;

			//Chama a  função 'EditarVenda()' dentro do 'if'
			//Verifica se cliente foi editado
			if (EditarVenda())
			{
				this.Close(); //Fecha formulario atual
				MessageBox.Show("Venda Editado", "Ok", MessageBoxButtons.OK, MessageBoxIcon.None);
				Program._controlProdutos.Atualizar();
			}
		}

		//ocorre quando carrega o formulario
		private void EditVendas_Load(object sender, EventArgs e)
		{
			//Obtem a quantidade antes de editar a vendas
			_quantidadeProdutosAnterior = int.Parse(texQuantidade.Text);
		}


	}
}
