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
	public partial class formAddFunc : Form
	{
		public formAddFunc()
		{
			InitializeComponent();
		}

        //ocorre quando clica no botão salva funcionario
        private void botSalvarClient_Click(object sender, EventArgs e)
        {
            //se a função SalvarFuncionario() retornar verdadeiro 
            // mostra um mensagem que o Funcionario foi salvo
            //atualiza o datagrid
            //fecha o formulario
            if (SalvarFuncionario())
            {

                MessageBox.Show("Funcionario Salvo", "Ok", MessageBoxButtons.OK, MessageBoxIcon.None);
                Program._controlfunc.Atualizar();
                this.Close(); //Fecha formulario atual
            }

        }

        //ocorre quando clica no botão novo funcionario
        private void botNewClient_Click(object sender, EventArgs e)
        {
            //se a função SalvarFuncionario() retornar verdadeiro então reseta o formulario
            // mostra um mensagem que o Funcionario foi salvo
            //atualiza o datagrid
            if (SalvarFuncionario())
            {
                MessageBox.Show("Cliente Salvo", "Ok", MessageBoxButtons.OK, MessageBoxIcon.None);
                texNome.Text = "";
                texTel.Text = "";
                texCargo.Text = "";
                texSalario.Text = "";
                texIniEx.Text = null;
                texFimEx.Text = null;
                Program._controlfunc.Atualizar();
            }
        }

        //Isso é Função, não é um evento, adiciona um Funcionario no arquivo Funcionario.txt
        private bool SalvarFuncionario()
        {
            //algum campo não for preenchido
            if (texNome.Text == "" || texTel.Text == "" || texCargo.Text == "" || texSalario.Text == "R$     ." || texIniEx.Text == "" || texFimEx.Text == "")
            {
                MessageBox.Show("Preencha todos os campos", "Preencher", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }

            //campo "Telefone" com 14 ou 15 caracteres
            if (texTel.Text.Length != 14 && texTel.Text.Length != 15)
            {
                MessageBox.Show("Preencher campo 'Telefone': '(xx) xxxx-xxxx'", "Falha", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }

            string nome = ("Nome: " + texNome.Text);
            string telefone = ("Telefone: " + texTel.Text);
            string cargo = ("Cargo: " + texCargo.Text);
            string salario = ("Salario: " + texSalario.Text);
            string horarioChegar = ("horarioChegar: " + texIniEx.Text);
            string horarioSair = ("horarioSair: " + texFimEx.Text);

            ////gerar codigo automatico
            string codigo = ("Codigo: " + Classes.Geral.GerarCodigo("funcionario", "FC"));

            // Função de gerar codigo retorna um string, se a função detectar um excessão
            //retorna uma string que contem "ERRO"
            if (codigo.Contains("ERRO:"))
            {
                MessageBox.Show(codigo, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            string addLinha = (codigo + "|" + nome + "|" +  telefone + "|" + cargo + "|" +  salario + "|" +  horarioChegar + "|" +  horarioSair);

            // adicionada a linha no arquivo
            string AddLinha = Classes.Geral.AddLinha(Program.pathFunc, addLinha);

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
