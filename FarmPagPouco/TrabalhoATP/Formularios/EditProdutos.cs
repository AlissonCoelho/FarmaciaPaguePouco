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
    public partial class EditProdutos : Form
    {

        string _codigo;

        public EditProdutos()
        {
            InitializeComponent();
            //Atribuir Valores da linha selecionada no datagrid ao formulario de Edição
            texDescricao.Text = (string)Program._controlProdutos.dataGrid.Rows[Program._controlProdutos.dataGrid.SelectedCells[0].RowIndex].Cells[1].Value;
            texQuantidade.Text = (string)Program._controlProdutos.dataGrid.Rows[Program._controlProdutos.dataGrid.SelectedCells[0].RowIndex].Cells[2].Value;
            texCusto.Text = (string)Program._controlProdutos.dataGrid.Rows[Program._controlProdutos.dataGrid.SelectedCells[0].RowIndex].Cells[3].Value;
            texVenda.Text = (string)Program._controlProdutos.dataGrid.Rows[Program._controlProdutos.dataGrid.SelectedCells[0].RowIndex].Cells[4].Value;
            texTipo.Text = (string)Program._controlProdutos.dataGrid.Rows[Program._controlProdutos.dataGrid.SelectedCells[0].RowIndex].Cells[5].Value;

        }


        //Ocorre quando o botão ok é clicado
        private void botOk_Click(object sender, EventArgs e)
        {
            //obtem o codigo do produt selecionado pela celula do datagrid
            _codigo = (string)Program._controlProdutos.dataGrid.Rows[Program._controlProdutos.dataGrid.SelectedCells[0].RowIndex].Cells[0].Value;

            //Chama a  função 'EditarProduto()' dentro do 'if'
            //Verifica se cliente foi editado
            if (EditarProduto())
            {
                this.Close(); //Fecha formulario atual
                MessageBox.Show("Produto Editado", "Ok", MessageBoxButtons.OK, MessageBoxIcon.None);
                Program._controlProdutos.Atualizar();
            }

        }

        //Isso é Função, não é um evento, faz a mesma coisa que o salvar produto
        //porem não gera um codigo automatico
        //edita o produto selecionado
        private bool EditarProduto()
        {
            //algum campo não for preenchido
            if (texDescricao.Text == "" || texQuantidade.Text == "" || texCusto.Text == "R$     ." || texVenda.Text == "R$     ." || texTipo.Text == "")
            {
                MessageBox.Show("Preencha todos os campos", "Preencher", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }

            long verific1;

            //campo "Numero" somente com numeros
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

            _codigo = ("Codigo: " + _codigo);

            string addLinha = (_codigo + "|" + Descricao + "|" + Quantidade + "|" + precoCusto + "|" + precoVenda + "|" + tipo);

            // edita a linha no arquivo
            Classes.Geral.EditarArquivos(Program.pathProdtos, _codigo, addLinha);

            return true;
        }
    }
}
