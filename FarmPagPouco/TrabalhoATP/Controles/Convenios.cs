using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrabalhoATP.Classes;

namespace TrabalhoATP.Controles
{
    public partial class Convenios : UserControl
    {
        public Convenios()
        {
            InitializeComponent();
        }

        //ocorre quando o botão novo é clicado
        private void butNew_Click(object sender, EventArgs e)
        {
            Formularios.AddConvenios formAddConvenio = new Formularios.AddConvenios();
            formAddConvenio.ShowDialog();
        }

        //Função de atualizar o data grid do controle
        //Essa função retorna um 'Classes.Convenios[]'
        //Estou fazendo isso para poder pegar os valores desse controle no controle de vendas
        public Classes.Convenios[] Atualizar()
        {
            //Declara um vetor de classe do tipo 'Classes.Convenios'
            Classes.Convenios[] convenios;

            //Declrar vetor de string vai conter as linhas do arquivo
            string[] linhas = null;


            //Declrar vetor de string vai conter os dados do dadosConvenios (Codigo, Nome, Desconto)
            string[] dadosConvenios = new string[4];

            //obtem os linhas do arquivo separada po vetor
            linhas = Geral.LerArquivo(Program.pathConvenios);

            //instancia o vetor da calsse Convenios
            //o "-1" é por que o aruivo sempre fica com uma linha vazia no final
            //então com o "-1" essa linha é desconsiderada
            convenios = new Classes.Convenios[linhas.Length - 1];

            for (int i = 0; i < (linhas.Length - 1); i++)
            {
                //dadosConvenios[0] = Codigo
                //dadosConvenios[1] = Nome
                //dadosConvenios[2] = Desconto
                dadosConvenios = linhas[i].Split('|');

                //para funcionar é necessario instaciar cada menbro do vetor de clase 
                convenios[i] = new Classes.Convenios();

                convenios[i].codigo = dadosConvenios[0].Remove(0, 8);//dadosConvenios[0] = Codigo
                convenios[i].nome = dadosConvenios[1].Remove(0, 6);//dadosConvenios[1] = Nome
                convenios[i].desconto = dadosConvenios[2].Remove(0, 10);//dadosConvenios[2] = Desconto
            }

            //Atualiza o datagrid
            BindingSource.DataSource = convenios;
            return convenios;
        }

        //ocorre quando o botão Editar é clicado
        private void Edit_Click(object sender, EventArgs e)
        {
            //verifica o tanto de linha no datagrid, se for zero não executa 
            if (Program._controlConvenios.dataGrid.RowCount == 0)
                return;

            //instacia e chama o novo formulario de editar Convenios
            Formularios.EditConvenios editConvenios = new Formularios.EditConvenios();
            editConvenios.ShowDialog();
        }

        //Ocorre quando o botão deletar é clicado
        private void butDel_Click(object sender, EventArgs e)
        {
            //verifica o tanto de linha no datagrid, se for zero não executa 
            if (Program._controlConvenios.dataGrid.RowCount == 0)
                return;

            //obtem o codigo do cliente selecionado pela celula do datagrid
            string codigo = (string)Program._controlConvenios.dataGrid.Rows[Program._controlConvenios.dataGrid.SelectedCells[0].RowIndex].Cells[0].Value;

            //Escreve: "Codigo: " para poder fazer a busca correta
            codigo = ("Codigo: " + codigo);

            Geral.DeletarLinha(Program.pathConvenios, codigo);
            Atualizar();

        }
    }
}

