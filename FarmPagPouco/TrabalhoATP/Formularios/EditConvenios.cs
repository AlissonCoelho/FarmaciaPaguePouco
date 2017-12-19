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
    public partial class EditConvenios : Form
    {
        string _codigo;
        public EditConvenios()
        {
            InitializeComponent();
            //Atribuir Valores da linha selecionada no datagrid ao formulario de Edição
            texNome.Text = (string)Program._controlConvenios.dataGrid.Rows[Program._controlConvenios.dataGrid.SelectedCells[0].RowIndex].Cells[1].Value;
            texDesconto.Text = (string)Program._controlConvenios.dataGrid.Rows[Program._controlConvenios.dataGrid.SelectedCells[0].RowIndex].Cells[2].Value;

        }

        //Ocorre quando o botão Ok é clicado
        private void botOk_Click(object sender, EventArgs e)
        {
            //obtem o codigo do convenio selecionado pela celula do datagrid
            _codigo = (string)Program._controlConvenios.dataGrid.Rows[Program._controlConvenios.dataGrid.SelectedCells[0].RowIndex].Cells[0].Value;

            //Chama a  função 'EditarConvenio()' dentro do 'if'
            //Verifica se Convenio foi editado
            if (EditarConvenio())
            {
                this.Close(); //Fecha formulario atual
                MessageBox.Show("Convenio Editado", "Ok", MessageBoxButtons.OK, MessageBoxIcon.None);
                Program._controlConvenios.Atualizar();

            }

        }

        //Isso é Função, não é um evento, faz a mesma coisa que o salvar convenio, porem não gera um codigo automatico
        //edita o convenio selecionado
        private bool EditarConvenio()
        {
            //algum campo não for preenchido
            if (texNome.Text == "" || texDesconto.Text == "  %")
            {
                MessageBox.Show("Preencha todos os campos", "Preencher", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }

            long verific1;

            //campo "Desconto" somente com numeros
            if (!long.TryParse(texDesconto.Text.Remove(2, 1), out verific1))
            {
                MessageBox.Show("Preencher campo 'Desconto' somente com números", "Falha", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }

            //Desconto tem de estar entre 10% e 40%
            if (verific1 <10 || verific1>40)
            {
                MessageBox.Show("Desconto tem de estar entre 10% e 40% ", "Falha", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }


            //Monta o Convenio Editado
            _codigo = ("Codigo: " + _codigo);
            string nome = ("Nome: " + texNome.Text);
            string desconto = ("Desconto: " + texDesconto.Text);

            

            string addLinha = (_codigo + "|" + nome + "|" + desconto);


            // edita a linha no arquivo
            Classes.Geral.EditarArquivos(Program.pathConvenios, _codigo, addLinha);

            return true;
        }

       
    }
}
