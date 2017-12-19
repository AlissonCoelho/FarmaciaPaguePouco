using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrabalhoATP.Formularios
{
    public partial class AddProdutos : Form
    {
        public AddProdutos()
        {
            InitializeComponent();
        }

        //ocorre quando clica no botão salvar
        private void botSalvar_Click(object sender, EventArgs e)
        {
            //se a função SalvarProduto() retornar verdadeiro 
            // mostra um mensagem que o Funcionario foi salvo
            //atualiza o datagrid
            //fecha o formulario
            if (SalvarProduto())
            {

                MessageBox.Show("Produto Salvo", "Ok", MessageBoxButtons.OK, MessageBoxIcon.None);
                Program._controlProdutos.Atualizar();
                this.Close(); //Fecha formulario atual
            }

        }

        //ocorre quando clica no botão novo
        private void botNew_Click(object sender, EventArgs e)
        {
            //se a função SalvarProduto() retornar verdadeiro então reseta o formulario
            // mostra um mensagem que o Funcionario foi salvo
            //atualiza o datagrid
            if (SalvarProduto())
            {
                MessageBox.Show("Produto Salvo", "Ok", MessageBoxButtons.OK, MessageBoxIcon.None);
                texDescricao.Text = "";
                texQuantidade.Text = "";
                texCusto.Text = null;
                texVenda.Text = null;
                texTipo.Text = "";
                Program._controlProdutos.Atualizar();
            }
        }

        //Isso é Função, não é um evento, adiciona um Produto no arquivo Produto.txt
        private bool SalvarProduto()
        {
            //algum campo não for preenchido
            if (texDescricao.Text == "" || texQuantidade.Text == "" || texCusto.Text == "R$     ." || texVenda.Text == "R$     ." || texTipo.Text == "")
            {
                MessageBox.Show("Preencha todos os campos", "Preencher", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }

            long verific1;

			//campo "Quantidade" somente com numeros
			if (!long.TryParse(texQuantidade.Text, out verific1))
            {
                MessageBox.Show("Preencher campo 'Quantidade' somente com números", "Falha", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }

            string Descricao = ("Descricao: " + texDescricao.Text);
            string Quantidade = ("Quantidade: " + texQuantidade.Text);
            string precoCusto = ("precoCusto: " + texCusto.Text);
            string precoVenda = ("precoVenda: " + texVenda.Text);
            string tipo = ("tipo: " + texTipo.Text);

            ////gerar codigo automatico
            string codigo = ("Codigo: " + Classes.Geral.GerarCodigo("produto", "PR"));

            // Função de gerar codigo retorna um string, se a função detectar um excessão
            //retorna uma string que contem "ERRO"
            if (codigo.Contains("ERRO:"))
            {
                MessageBox.Show(codigo, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            string addLinha = (codigo + "|" + Descricao + "|" + Quantidade + "|" + precoCusto + "|" + precoVenda + "|" + tipo);

            // adicionada a linha no arquivo
            string AddLinha = Classes.Geral.AddLinha(Program.pathProdtos, addLinha);

            //Função adicionar linha retorna uma string que se tiver algum erro retorna diferete de ""
            //Se ouve alguma falha ao adicionar a linha mostra um mensagem ao usuario
            if (AddLinha != "")
            {
                MessageBox.Show(AddLinha, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

		private void texTipo_SelectedIndexChanged(object sender, EventArgs e)
		{

		}

		
	}
}

