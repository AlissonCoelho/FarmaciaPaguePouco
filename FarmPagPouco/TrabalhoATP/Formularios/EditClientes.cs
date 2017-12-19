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
    public partial class EditClientes : Form
    {
        string _codigo;

        //Evento ocorre na chamada do formulario
        public EditClientes()
        {
            InitializeComponent();

            //Atribuir Valores da linha selecionada no datagrid ao formulario de Edição
            texNome.Text = (string)Program._controlCliente.dataGridViewClient.Rows[Program._controlCliente.dataGridViewClient.SelectedCells[0].RowIndex].Cells[1].Value;
            texLogra.Text = (string)Program._controlCliente.dataGridViewClient.Rows[Program._controlCliente.dataGridViewClient.SelectedCells[0].RowIndex].Cells[2].Value;
			texNum.Text = (string)Program._controlCliente.dataGridViewClient.Rows[Program._controlCliente.dataGridViewClient.SelectedCells[0].RowIndex].Cells[3].Value;
			texCidade.Text = (string)Program._controlCliente.dataGridViewClient.Rows[Program._controlCliente.dataGridViewClient.SelectedCells[0].RowIndex].Cells[4].Value;
			texBairro.Text = (string)Program._controlCliente.dataGridViewClient.Rows[Program._controlCliente.dataGridViewClient.SelectedCells[0].RowIndex].Cells[5].Value;
			texEstado.Text = (string)Program._controlCliente.dataGridViewClient.Rows[Program._controlCliente.dataGridViewClient.SelectedCells[0].RowIndex].Cells[6].Value;
			texTel.Text = (string)Program._controlCliente.dataGridViewClient.Rows[Program._controlCliente.dataGridViewClient.SelectedCells[0].RowIndex].Cells[7].Value;

        }

        //Evento ocorre no click do botão Ok
        private void botOk_Click(object sender, EventArgs e)
        {
            //obtem o codigo do cliente selecionado pela celula do datagrid
            _codigo = (string)Program._controlCliente.dataGridViewClient.Rows[Program._controlCliente.dataGridViewClient.SelectedCells[0].RowIndex].Cells[0].Value;

            //Chama a  função 'EditarClientes()' dentro do 'if'
            //Verifica se cliente foi editado
            if (EditarClientes())
            {
                this.Close(); //Fecha formulario atual
                MessageBox.Show("Cliente Editado", "Ok", MessageBoxButtons.OK, MessageBoxIcon.None);
                Program._controlCliente.Atualizar();

            }
        }

        //Isso é Função, não é um evento, faz a mesma coisa que o salvar clientes, porem não gera um codigo automatico
        //edita o cliente selecionado
        private bool EditarClientes()
        {
            //algum campo não for preenchido
            if (texNome.Text == "" || texLogra.Text == "" || texNum.Text == "" || texCidade.Text == "" || texBairro.Text == "" || texEstado.Text == "" || texTel.Text == "")
            {
                MessageBox.Show("Preencha todos os campos", "Preencher", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }

            long verific1;

            //campo "Numero" somente com numeros
            if (!long.TryParse(texNum.Text, out verific1))
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

            _codigo = ("Codigo: " + _codigo);
			string nome = ("Nome: " + texNome.Text);
			string logradouro = ("Logradouro: " + texLogra.Text);
			string numero = ("Numero: " + texNum.Text);
			string cidade = ("Cidade: " + texCidade.Text);
			string bairro = ("Bairro: " + texBairro.Text);
			string estado = ("Estado: " + texEstado.Text);
			string telefone = ("Telefone: " + texTel.Text);

			string addLinha = (_codigo + "|" + nome + "|" + logradouro + "|" + numero + "|" + cidade + "|" + bairro + "|" + estado + "|" + telefone);

			// edita a linha no arquivo
			Classes.Geral.EditarArquivos(Program.pathClientes, _codigo, addLinha);

            return true;
        }
    }
}
