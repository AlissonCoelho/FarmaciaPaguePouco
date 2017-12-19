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
	public partial class formAddClient : Form
	{
		public formAddClient()
		{
			InitializeComponent();
			texNome.Focus();
		}

        //ocorre quando clica no botão salvar cliente
        private void botSalvarClient_Click(object sender, EventArgs e)
		{
            //se a função SalvarClientes() retornar verdadeiro 
            // mostra um mensagem que o cliente foi salvo
            //atualiza o datagrid
            //fecha o formulario
			if (SalvarClientes())
			{
				
                MessageBox.Show("Cliente Salvo", "Ok", MessageBoxButtons.OK, MessageBoxIcon.None);
                Program._controlCliente.Atualizar();
                this.Close(); //Fecha formulario atual
            }
		}

        //ocorre quando clica no botão novo cliente
		private void botNewClient_Click(object sender, EventArgs e)
		{
            //se a função SalvarClientes() retornar verdadeiro então reseta o formulario
            // mostra um mensagem que o cliente foi salvo
            //atualiza o datagrid
            if (SalvarClientes())
			{
                MessageBox.Show("Cliente Salvo", "Ok", MessageBoxButtons.OK, MessageBoxIcon.None);
                texNome.Text = "";
				texLogra.Text = "";
				texNum.Text = "";
				texCidade.Text = "";
				texBairro.Text = "";
				texEstado.Text = null;
				texTel.Text = "";
                Program._controlCliente.Atualizar();
            }
		}

        //Isso é Função, não é um evento, adiciona um cliete no arquivo Cliente.txt
        private bool SalvarClientes()
		{
			//algum campo não for preenchido
			if (texNome.Text == "" || texLogra.Text == "" || texNum.Text == "" || texCidade.Text == "" || texBairro.Text == "" || texEstado.Text == "" || texTel.Text == "")
			{
				MessageBox.Show("Preencha todos os campos", "Preencher", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				return false;
			}

            long verific1;

            //campo "Numero" somente com numeros
            if (!long.TryParse(texNum.Text, out  verific1))
			{
				MessageBox.Show("Preencher campo 'Número' somente com números", "Falha", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				return false;
			}

			//campo "Telefone" com 14 ou 15 caracteres
			if (texTel.Text.Length != 14 && texTel.Text.Length != 15)
			{
				MessageBox.Show("Preencher campo 'Telefone': '(xx) xxxx-xxxx'", "Falha", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				return false;
			}

			string nome = ("Nome: " + texNome.Text);
			string logradouro = ("Logradouro: " + texLogra.Text);
			string numero = ("Numero: " + texNum.Text);
			string cidade = ("Cidade: " + texCidade.Text);
			string bairro = ("Bairro: " + texBairro.Text);
			string estado = ("Estado: " + texEstado.Text);
			string telefone = ("Telefone: " + texTel.Text);

			////gerar codigo automatico
			string codigo = ("Codigo: " + Classes.Geral.GerarCodigo("clientes", "CL"));

            // Função de gerar codigo retorna um string, se a função detectar um excessão
            //retorna uma string que contem "ERRO"
			if (codigo.Contains("ERRO:"))
			{
				MessageBox.Show(codigo, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return false;
			}

			string addLinha = (codigo + "|" + nome + "|" + logradouro + "|" + numero + "|" + cidade + "|" + bairro + "|" + estado + "|" + telefone);

			// adicionada a linha no arquivo
			string AddLinha = Classes.Geral.AddLinha(Program.pathClientes, addLinha);

            //Função adicionar linha retorna uma string que se tiver algum erro retorna diferete de ""
			//Se ouve alguma falha ao adicionar a linha mostra um mensagem ao usuario
			if (AddLinha != "")
			{
				MessageBox.Show(AddLinha, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return false;
			}
			return true;
		}

	}
}
