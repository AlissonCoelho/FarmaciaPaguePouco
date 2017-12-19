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
using TrabalhoATP.Formularios;

namespace TrabalhoATP.Controles
{
    public partial class Clientes : UserControl
    {

        public Clientes()
        {
            InitializeComponent();
        }

        //ocorre quando o botão novo cliente é clicado
        private void butNewClient_Click(object sender, EventArgs e)
        {
            formAddClient formAddClient = new formAddClient();
            formAddClient.ShowDialog();
        }

        //Função de atualizar o data grid do controle
        //Essa função retorna um 'Classes.Clientes[]'
        //Estou fazendo isso para poder pegar os valores desse controle no controle de vendas
        public Classes.Clientes[] Atualizar()
        {
            //Declara um vetor de classe do tipo 'Classes.Clientes'
            Classes.Clientes[] clientes;

            //Declrar vetor de string vai conter as linhas do arquivo
            string[] linhas = null;


            //Declrar vetor de string vai conter os dados do cliente (Codigo, Nome, Endereço, Telefone)
            string[] dadosCliente; 

            //obtem os linhas do arquivo separada po vetor
            linhas = Geral.LerArquivo(Program.pathClientes);

            //instancia o vetor da calsse clientes
            clientes = new Classes.Clientes[linhas.Length - 1];

            for (int i = 0; i < (linhas.Length - 1); i++)
            {
				//dadosCliente[0] = Codigo
				//dadosCliente[1] = Nome
				//dadosCliente[2] = Logradouro
				//dadosCliente[3] = Numero
				//dadosCliente[4] = Cidade
				//dadosCliente[5] = Bairro
				//dadosCliente[6] = Estado
				//dadosCliente[7] = Telefone
				dadosCliente = linhas[i].Split('|');

                //para funcionar é necessario instaciar cada menbro do vetor de clase 
                clientes[i] = new Classes.Clientes();

                clientes[i].codigo = dadosCliente[0].Remove(0, 8);//dadosCliente[0] = Codigo
                clientes[i].nome = dadosCliente[1].Remove(0, 6);//dadosCliente[1] = Nome
                clientes[i].logradouro = dadosCliente[2].Remove(0,12);//dadosCliente[2] = Logradouro
				clientes[i].numero = dadosCliente[3].Remove(0, 8);//dadosCliente[3] = Numero
				clientes[i].cidade = dadosCliente[4].Remove(0, 8);//dadosCliente[4] = Cidade
				clientes[i].bairro = dadosCliente[5].Remove(0, 8);//dadosCliente[5] = Bairro
				clientes[i].estado = dadosCliente[6].Remove(0, 8);//dadosCliente[6] = Estado
				clientes[i].telefone = dadosCliente[7].Remove(0, 10);//dadosCliente[7] = Telefone
            }

            //Atualiza o datagrid
            clientesBindingSource.DataSource = clientes;
            return clientes;
        }

        //ocorre quando o botão Editar cliente é clicado
        private void EditClient_Click(object sender, EventArgs e)
        {
            //verifica o tanto de linha no datagrid, se for zero não executa 
            if (Program._controlCliente.dataGridViewClient.RowCount == 0)
                return;

            //instacia e chama o novo formulario de editar clientes
            EditClientes editClient = new EditClientes();
            editClient.ShowDialog();
        }

        //Ocorre quando o botão deletar é clicado
        private void butDelClient_Click(object sender, EventArgs e)
        {
			//verifica o tanto de linha no datagrid, se for zero não executa 
			if (Program._controlCliente.dataGridViewClient.RowCount == 0)
				return;

			//obtem o codigo do cliente selecionado pela celula do datagrid
			string codigo = (string)Program._controlCliente.dataGridViewClient.Rows[Program._controlCliente.dataGridViewClient.SelectedCells[0].RowIndex].Cells[0].Value;
            
            //Escreve: "Codigo: " para poder fazer a busca correta
            codigo = ("Codigo: " + codigo);

            Geral.DeletarLinha(Program.pathClientes, codigo);
            Atualizar();
        }

        //Ocorre quando o botão pesquisar é clicado
        private void pesquisar_Click(object sender, EventArgs e)
        {
            //Verifica se o textBox pesquisar esta em branco
            if (texPesquisar.Text == "")
            {
                //Se tiver em branco atualiza o datagrid
                Atualizar();
                return;
            }

            //Declara um vetor de classe do tipo 'Classes.Clientes'
            Classes.Clientes[] resultPesquisa;

            //Declrar vetor de string vai conter as linhas da pesquisa
            string[] linhas = null;


            //Declrar vetor de string vai conter os dados do cliente (Codigo, Nome, Endereço, Telefone)
            string[] dadosCliente = new string[4];

            //obtem os linhas do arquivo separada po vetor
			//Numero '1' significa o indice para pesquisar pela propriedade nome
            linhas = Geral.PesquisaArquivo(Program.pathClientes, ("Nome: " + texPesquisar.Text),1);

            //se o resultado da pesquisa for vazio exibe uma mensagem para o usuario
            if (linhas == null)
            {
                MessageBox.Show("Nome não encontrado", "Pesquisa", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            //instancia o vetor da calsse clientes
            resultPesquisa = new Classes.Clientes[linhas.Length - 1];

            for (int i = 0; i < (linhas.Length - 1); i++)
            {
                //dadosCliente[0] = Codigo
                //dadosCliente[1] = Nome
                //dadosCliente[2] = Endereço
                //dadosCliente[3] = Telefone
                dadosCliente = linhas[i].Split('|');

                //para funcionar é necessario instaciar cada menbro do vetor de clase 
                resultPesquisa[i] = new Classes.Clientes();

                resultPesquisa[i].codigo = dadosCliente[0].Remove(0, 8);//dadosCliente[0] = Codigo
                resultPesquisa[i].nome = dadosCliente[1].Remove(0, 6);//dadosCliente[1] = Nome
                resultPesquisa[i].logradouro = dadosCliente[2].Remove(0, 12);//dadosCliente[2] = Logradouro
                resultPesquisa[i].numero = dadosCliente[3].Remove(0, 8);//dadosCliente[3] = Numero
                resultPesquisa[i].cidade = dadosCliente[4].Remove(0, 8);//dadosCliente[4] = Cidade
                resultPesquisa[i].bairro = dadosCliente[5].Remove(0, 8);//dadosCliente[5] = Bairro
                resultPesquisa[i].estado = dadosCliente[6].Remove(0, 8);//dadosCliente[6] = Estado
                resultPesquisa[i].telefone = dadosCliente[7].Remove(0, 10);//dadosCliente[7] = Telefone
            }

            //Atualiza o datagrid
            clientesBindingSource.DataSource = resultPesquisa;

        }
    }
}
