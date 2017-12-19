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
    public partial class EditFunc : Form
    {

        string _codigo;

        //Evento ocorre na chamada do formulario
        public EditFunc()
        {
            InitializeComponent();
            //Atribuir Valores da linha selecionada no datagrid ao formulario de Edição
            texNome.Text = (string)Program._controlfunc.dataGridViewFunc.Rows[Program._controlfunc.dataGridViewFunc.SelectedCells[0].RowIndex].Cells[1].Value;
            texTel.Text = (string)Program._controlfunc.dataGridViewFunc.Rows[Program._controlfunc.dataGridViewFunc.SelectedCells[0].RowIndex].Cells[2].Value;
            texCargo.Text = (string)Program._controlfunc.dataGridViewFunc.Rows[Program._controlfunc.dataGridViewFunc.SelectedCells[0].RowIndex].Cells[3].Value;
            texSalario.Text = (string)Program._controlfunc.dataGridViewFunc.Rows[Program._controlfunc.dataGridViewFunc.SelectedCells[0].RowIndex].Cells[4].Value;
            texIniEx.Text = (string)Program._controlfunc.dataGridViewFunc.Rows[Program._controlfunc.dataGridViewFunc.SelectedCells[0].RowIndex].Cells[5].Value;
            texFimEx.Text = (string)Program._controlfunc.dataGridViewFunc.Rows[Program._controlfunc.dataGridViewFunc.SelectedCells[0].RowIndex].Cells[6].Value;
        }

        //Evento ocorre no click do botão Ok
        private void botOk_Click(object sender, EventArgs e)
        {
            //obtem o codigo do cliente selecionado pela celula do datagrid
            _codigo = (string)Program._controlfunc.dataGridViewFunc.Rows[Program._controlfunc.dataGridViewFunc.SelectedCells[0].RowIndex].Cells[0].Value;

            //Chama a  função 'EditarFuncionario()' dentro do 'if'
            //Verifica se cliente foi editado
            if (EditarFuncionario())
            {
                this.Close(); //Fecha formulario atual
                MessageBox.Show("Funcionario Editado", "Ok", MessageBoxButtons.OK, MessageBoxIcon.None);
                Program._controlfunc.Atualizar();

            }
        }

        //Isso é Função, não é um evento, faz a mesma coisa que o salvar funcionario
        //porem não gera um codigo automatico
        //edita o funcionario selecionado
        private bool EditarFuncionario()
        {
            //algum campo não for preenchido
            if (texNome.Text == "" || texTel.Text == "" || texCargo.Text == "" || texSalario.Text == "R$" || texIniEx.Text == "" || texFimEx.Text == "")
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

            _codigo = ("Codigo: " + _codigo);

            string addLinha = (_codigo + "|" + nome + "|" + telefone + "|" + cargo + "|" + salario + "|"  + horarioChegar + "|" + horarioSair);

            // edita a linha no arquivo
            Classes.Geral.EditarArquivos(Program.pathFunc, _codigo, addLinha);

            return true;
        }
    }
}
