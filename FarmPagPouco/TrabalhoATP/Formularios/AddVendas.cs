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
	public partial class AddVendas : Form
	{

		int quantidadeVenda;
		double valorVenda = 0;
		double desconto = 1;

		//Obtem os dados do produto selecionado
		Produtos _produto;

		//Obtem os dados do produto selecionado
		Convenios _convenio;

		//Imitialize Component
		public AddVendas()
		{

			InitializeComponent();
			produtosBindingSource.DataSource = Program._controlProdutos.Atualizar();
			clientesBindingSource.DataSource = Program._controlCliente.Atualizar();
			funcionariosBindingSource.DataSource = Program._controlfunc.Atualizar();
			conveniosBindingSource.DataSource = Program._controlConvenios.Atualizar();


			//Reseta todos os campo para obrigar o usuario a selecionar um
			texProduto.Text = null;
			texCliente.Text = null;
			texFuncionario.Text = null;
			texConvenios.Text = null;
			

		}

		//ocorre quando o campo quantidade é alterado
		private void texQuantidade_TextChanged(object sender, EventArgs e)
		{
			//Verifica se o campo contém so numero e se é interio
			if (!int.TryParse(texQuantidade.Text, out quantidadeVenda))
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

			//verifica se a quantidade de produtos é suficiente para vender
			if (quantidadeProdutosAtual - quantidadeVenda < 0)
			{
				MessageBox.Show("Quantidade insuficiente", "Produtos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				return;
			}

			//realiza a operação de calcular a venda
			texValor.Text = "R$:" + (valorVenda * quantidadeVenda);

			//realiza a operação de calcular o valor final
			decimal valorFinal = Convert.ToDecimal(valorVenda * quantidadeVenda * desconto);
			texValorFinal.Text = "R$:" + Decimal.Round(valorFinal, 2);

		}

		//ocorre quando o campo Produto é alterado
		private void texProduto_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (texProduto.Text == "")
				return;
			//Obtem as propriedades do produto selecionado
			_produto = (Produtos)texProduto.SelectedValue;

			//Converte o valor do preço venda para double
			valorVenda = double.Parse(_produto.precoVenda.Substring(2));

			//realiza a operação de calcular a venda
			texValor.Text = "R$:" + (valorVenda * quantidadeVenda);

			//realiza a operação de calcular o valor final
			decimal valorFinal = Convert.ToDecimal(valorVenda * quantidadeVenda * desconto);
			texValorFinal.Text = "R$:" + Decimal.Round(valorFinal, 2);


		}

		//Ocorre quando o formulario é carregado
		private void AddVendas_Load(object sender, EventArgs e)
		{
			//desabilita o botão nova venda 
			Program._controlVendas.butNew.Enabled = false;

			//escreve zero no campo da quantidade
			texQuantidade.Text = "0";

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

			string addLinha = (codigo + "|" + Descricao + "|" + Quantidade + "|" + precoCusto + "|" + precoVenda +  "|" + tipo);

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
			desconto = 1 - double.Parse(_convenio.desconto.Substring(0,2)) / 100;

			//realiza a operação de calcular o valor final
			decimal valorFinal = Convert.ToDecimal(valorVenda * quantidadeVenda * desconto);
			texValorFinal.Text = "R$:" + Decimal.Round(valorFinal, 2);

		}

		//ocorre quando o formulario é fehchado
		private void AddVendas_FormClosed(object sender, FormClosedEventArgs e)
		{
			//habilita o botão nova venda 
			Program._controlVendas.butNew.Enabled = true;
		}

		//ocorre quando o botão salvar é clicado
		private void botSalvar_Click(object sender, EventArgs e)
		{
			//se a função SalvarVenda() retornar verdadeiro 
			// mostra um mensagem que o cliente foi salvo
			//atualiza o datagrid
			//fecha o formulario
			if (SalvarVenda())
			{
				MessageBox.Show("Venda Salvo", "Ok", MessageBoxButtons.OK, MessageBoxIcon.None);
				Program._controlVendas.Atualizar();
				this.Close(); //Fecha formulario atual
			}
		}

		//Isso é Função, não é um evento, adiciona uma venda no arquivo Venda.txt
		private bool SalvarVenda()
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
			string dataVenda = ("dataVenda: " + DateTime.Now.ToString("dd/MM/yyyy"));

			////gerar codigo automatico
			string codigo = ("Codigo: " + Classes.Geral.GerarCodigo("vendas", "VD"));

			// Função de gerar codigo retorna um string, se a função detectar um excessão
			//retorna uma string que contem "ERRO"
			if (codigo.Contains("ERRO:"))
			{
				MessageBox.Show(codigo, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return false;
			}

			string addLinha = (codigo + "|" + produto + "|" + quantidade + "|" + valorTotal + "|" + codigoCliente + "|" + codigoFuncionario + "|" + convenios + "|" + valorFinal + "|" + dataVenda);

			// adicionada a linha no arquivo
			string AddLinha = Classes.Geral.AddLinha(Program.pathVenda, addLinha);

			//Obtem a quantidade de produtos atual
			int quantidadeProdutosAtual = int.Parse(_produto.quantidade);

			//escreve a nova quantidade de produtos
			_produto.quantidade = ("Quantidade: " + (quantidadeProdutosAtual - quantidadeVenda));

			//Arualiza no arquivo a quantidade de produtos
			AtualizarQuantidadeProduto();

			//Função adicionar linha retorna uma string que se tiver algum erro retorna diferete de ""
			//Se ouve alguma falha ao adicionar a linha mostra um mensagem ao usuario
			if (AddLinha != "")
			{
				MessageBox.Show(AddLinha, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return false;
			}
			return true;
		}

		//Ocorre quando o botão nova venda é clicado
		private void botNew_Click(object sender, EventArgs e)
		{
			//se a função SalvarVenda() retornar verdadeiro então reseta o formulario
			// mostra um mensagem que o venda foi salva
			//atualiza o datagrid
			if (SalvarVenda())
			{
				MessageBox.Show("Venda Salva", "Ok", MessageBoxButtons.OK, MessageBoxIcon.None);
				//Reseta todos os campo
				texProduto.Text = null;
				texCliente.Text = null;
				texFuncionario.Text = null;
				texConvenios.Text = null;
				texQuantidade.Text = "";
				texValor.Text = "";
				texValorFinal.Text = "";
				Program._controlVendas.Atualizar();
			}
		}
	}

}
