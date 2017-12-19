using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrabalhoATP.Formularios;
using TrabalhoATP.Classes;

namespace TrabalhoATP.Controles
{
	public partial class Funcionarios : UserControl
	{

		public Funcionarios()
		{
			InitializeComponent();
		}

        //ocorre quando o botão novo funcionario é clicado
        private void butNewFunc_Click(object sender, EventArgs e)
		{
			formAddFunc formAddFunc = new formAddFunc();
			formAddFunc.ShowDialog();
		}

        //Função de atualizar o data grid do evento
        //Essa função retorna um 'Classes.Funcionarios[]'
        //Estou fazendo isso para poder pegar os valores desse controle no controle de vendas
        public Classes.Funcionarios[] Atualizar()
        {
            //Declara um vetor de classe do tipo 'Classes.Funcionarios'
            Classes.Funcionarios[] funcionario;

            //Declrar vetor de string vai conter as linhas do arquivo
            string[] linhas = null;


            //Declrar vetor de string vai conter os dados do cliente (Codigo, Nome, Endereço, Telefone)
            string[] dadosFuncionario = new string[4];

            //obtem os linhas do arquivo separada po vetor
            linhas = Classes.Geral.LerArquivo(Program.pathFunc);

            //instancia o vetor da calsse funcionario
            funcionario = new Classes.Funcionarios[linhas.Length - 1];

            for (int i = 0; i < (linhas.Length - 1); i++)
            {
                //dadosFuncionario[0] = Codigo
                //dadosFuncionario[1] = Nome
                //dadosFuncionario[2] = Telefone
                //dadosFuncionario[3] = Cargo
                //dadosFuncionario[4] = Salario
                //dadosFuncionario[5] = Horario de Chegadar
                //dadosFuncionario[6] = Horario de Sair
                dadosFuncionario = linhas[i].Split('|');

                //para funcionar é necessario instaciar cada menbro do vetor de clase 
                funcionario[i] = new Classes.Funcionarios();

                funcionario[i].codigo = dadosFuncionario[0].Remove(0, 8);//dadosFuncionario[0] = Codigo
                funcionario[i].nome = dadosFuncionario[1].Remove(0, 6);//dadosFuncionario[1] = Nome
                funcionario[i].telefone = dadosFuncionario[2].Remove(0, 10);//dadosFuncionario[2] = Telefone
                funcionario[i].cargo = dadosFuncionario[3].Remove(0, 7);//dadosFuncionario[3] = Cargo
                funcionario[i].salario = dadosFuncionario[4].Remove(0, 9);//dadosFuncionario[4] = Salario
                funcionario[i].horarioChegar = dadosFuncionario[5].Remove(0, 15);//dadosFuncionario[5] = Horario de Chegadar
                funcionario[i].horarioSair = dadosFuncionario[6].Remove(0, 13);//dadosFuncionario[6] = Horario de Sair
            }

            //Atualiza o datagrid
            funcionariosBindingSource.DataSource = funcionario;
            return funcionario;
        }

        //ocorre quando o botão Editar Funcionario é clicado
        private void EditFunc_Click(object sender, EventArgs e)
        {
            //verifica o tanto de linha no datagrid, se for zero não executa 
            if (Program._controlfunc.dataGridViewFunc.RowCount == 0)
                return;

            //instacia e chama o novo formulario de editar Funcionario
            EditFunc editfunc = new EditFunc();
            editfunc.ShowDialog();
        }

        //Ocorre quando o botão deletar é clicado
        private void butDelFunc_Click(object sender, EventArgs e)
        {
            //verifica o tanto de linha no datagrid, se for zero não executa 
            if (Program._controlfunc.dataGridViewFunc.RowCount == 0)
                return;

            //obtem o codigo do Funcionario selecionado pela celula do datagrid
            string codigo = (string)Program._controlfunc.dataGridViewFunc.Rows[Program._controlfunc.dataGridViewFunc.SelectedCells[0].RowIndex].Cells[0].Value;

            //Escreve: "Codigo: " para poder fazer a busca correta
            codigo = ("Codigo: " + codigo);

            Geral.DeletarLinha(Program.pathFunc, codigo);
            Atualizar();
        }

        //Ocorre quando o botão pesquisar é clicado
        private void pesquisar_Click(object sender, EventArgs e)
        {

            {
                //Verifica se o textBox pesquisar esta em branco
                if (texPesquisar.Text == "")
                {
                    //Se tiver em branco atualiza o datagrid
                    Atualizar();
                    return;
                }

                //Declara um vetor de classe do tipo 'Classes.Funcionarios'
                Classes.Funcionarios[] resultPesquisa;

                //Declrar vetor de string vai conter as linhas da pesquisa
                string[] linhas = null;


                //Declrar vetor de string vai conter os dados do cliente (Codigo, Nome, Endereço, Telefone)
                string[] dadosFuncionario = new string[7];

				//obtem os linhas do arquivo separada po vetor
				//Numero '1' significa o indice para pesquisar pela propriedade nome
				linhas = Geral.PesquisaArquivo(Program.pathFunc, ("Nome: " + texPesquisar.Text),1);

                //se o resultado da pesquisa for vazio exibe uma mensagem para o usuario
                if (linhas == null)
                {
                    MessageBox.Show("Nome não encontrado", "Pesquisa", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                //instancia o vetor da calsse clientes
                resultPesquisa = new Classes.Funcionarios[linhas.Length - 1];

                for (int i = 0; i < (linhas.Length - 1); i++)
                {
                    //dadosFuncionario[0] = Codigo
                    //dadosFuncionario[1] = Nome
                    //dadosFuncionario[2] = Telefone
                    //dadosFuncionario[3] = Cargo
                    //dadosFuncionario[4] = Salario
                    //dadosFuncionario[5] = Horario de Chegadar
                    //dadosFuncionario[6] = Horario de Sair
                    dadosFuncionario = linhas[i].Split('|');

                    //para funcionar é necessario instaciar cada menbro do vetor de clase 
                    resultPesquisa[i] = new Classes.Funcionarios();

                    resultPesquisa[i].codigo = dadosFuncionario[0].Remove(0, 8);//dadosFuncionario[0] = Codigo
                    resultPesquisa[i].nome = dadosFuncionario[1].Remove(0, 6);//dadosFuncionario[1] = Nome
                    resultPesquisa[i].telefone = dadosFuncionario[2].Remove(0, 10);//dadosFuncionario[2] = Telefone
                    resultPesquisa[i].cargo = dadosFuncionario[3].Remove(0, 7);//dadosFuncionario[3] = Cargo
                    resultPesquisa[i].salario = dadosFuncionario[4].Remove(0, 9);//dadosFuncionario[4] = Salario
                    resultPesquisa[i].horarioChegar = dadosFuncionario[5].Remove(0, 15);//dadosFuncionario[5] = Horario de Chegadar
                    resultPesquisa[i].horarioSair = dadosFuncionario[6].Remove(0, 13);//dadosFuncionario[6] = Horario de Sair
                }

                //Atualiza o datagrid
                funcionariosBindingSource.DataSource = resultPesquisa;

            }
        }
    }
}
