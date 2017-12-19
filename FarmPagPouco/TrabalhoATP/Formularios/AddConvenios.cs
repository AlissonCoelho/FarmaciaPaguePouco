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
    public partial class AddConvenios : Form
    {
        public AddConvenios()
        {
            InitializeComponent();
        }

        //ocorre quando clica no botão Salvae
        private void botSalvar_Click(object sender, EventArgs e)
        {
            //se a função SalvarConvenio() retornar verdadeiro 
            // mostra um mensagem que o cliente foi salvo
            //atualiza o datagrid
            //fecha o formulario
            if (SalvarConvenio())
            {

                MessageBox.Show("Convenio Salvo", "Ok", MessageBoxButtons.OK, MessageBoxIcon.None);
                Program._controlConvenios.Atualizar();
                this.Close(); //Fecha formulario atual
            }

        }

        //ocorre quando clica no botão Novo
        private void botNew_Click(object sender, EventArgs e)
        {
            //se a função SalvarConvenio() retornar verdadeiro então reseta o formulario
            // mostra um mensagem que o cliente foi salvo
            //atualiza o datagrid
            if (SalvarConvenio())
            {
                MessageBox.Show("Convenio Salvo", "Ok", MessageBoxButtons.OK, MessageBoxIcon.None);
                texNome.Text = "";
                texDesconto.Text = null;
                Program._controlConvenios.Atualizar();
            }

        }

        //Isso é Função, não é um evento, adiciona um cliete no arquivo Convenio.txt
        private bool SalvarConvenio()
        {
            //algum campo não for preenchido
            if (texNome.Text == "" || texDesconto.Text == "  %" )
            {
                MessageBox.Show("Preencha todos os campos", "Preencher", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }

            long verific1;

            //campo "Numero" somente com numeros
            if (!long.TryParse(texDesconto.Text.Remove(2,1), out verific1))
            {
                MessageBox.Show("Preencher campo 'Desconto' somente com números", "Falha", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }

            //Desconto tem de estar entre 10% e 40%
            if (verific1 < 10 || verific1 > 40)
            {
                MessageBox.Show("Desconto tem de estar entre 10% e 40% ", "Falha", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }

            string nome = ("Nome: " + texNome.Text);
            string desconto = ("Desconto: " + texDesconto.Text);
            
            ////gerar codigo automatico
            string codigo = ("Codigo: " + Classes.Geral.GerarCodigo("convenio", "CV"));

            // Função de gerar codigo retorna um string, se a função detectar um excessão
            //retorna uma string que contem "ERRO"
            if (codigo.Contains("ERRO:"))
            {
                MessageBox.Show(codigo, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            string addLinha = (codigo + "|" + nome + "|" + desconto);

            // adicionada a linha no arquivo
            string AddLinha = Classes.Geral.AddLinha(Program.pathConvenios, addLinha);

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
