using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoATP.Classes
{
    class Geral
    {
        //Adiciona qualquer item(Cliente. Funcionario, Covenio, Produto ou Venda)
        public static string AddLinha(string path, string textoLinha)
        {
            //Declara o FileStream e o StreamWriter fora do try cath
            //para que se o arquivo for aberto e der um excessão
            //ele possa ser fechado no cath
            FileStream arq1 = null;
            StreamWriter escreve = null;
            try
            {
                //declara instancia do FileStream, obtem o path no parametro da chamada da função
                arq1 = new FileStream(path, FileMode.OpenOrCreate);

                //faz uma leitura do arquivo para ir ao fina do arquivo e assim nhão sobreescrever nenhum dado
                StreamReader ler = new StreamReader(arq1);
                ler.ReadToEnd();

                // declara instancia do StreamWriter 
                escreve = new StreamWriter(arq1);

                //obtem o texto no parametro da chamada da função
                escreve.WriteLine(textoLinha);
                escreve.Close();

                //Retorna vazio pois não ocorreu nenhum erro
                return "";

            }
            catch (Exception e)
            {
                //se chegar ate aki é porque ouve algum erro
                //se o FileStream ou StreamWriter foi aberto manda fechar
                if (arq1 != null)
                    arq1.Close();
                if (escreve != null)
                    escreve.Close();
                //Retorna 'ERRO' e o motivo do erro
                // um posivel erro seria não ter o caminho do arquivo
                return ("Erro" + e.Message);
            }

        }

        //Le todo o arquivo e retorna cada linha em uma posiçao do vetor
        public static string[] LerArquivo(string path)
        {

            //Declara o FileStream e o resultado fora do try cath
            //para que se o arquivo for aberto e der um excessão
            //ele possa ser fechado no cath
            //e o resultado retorna vaio
            string[] resultado = null;
            FileStream arq1 = null;
            try
            {
                //declara instancia do FileStream, obtem o path no parametro da chamada da função
                arq1 = new FileStream(path, FileMode.OpenOrCreate);

                // declara instancia do StreamWriter 
                StreamReader ler = new StreamReader(arq1);

                //Variavel que recebe todo conteudo do arquivo
                string tudo = null;

                tudo = ler.ReadToEnd();

                if (tudo == null)
                    return resultado; //Se arquivo estiver vazio retorna string[] vazia

                //'string[] resultado' recebe os valores pelo 'Split' de "/r"(tabulação)
                resultado = tudo.Split('\r');

                //Cada vetor ainda fica com um "\n"(saltar linha) no inicio, aki é removido esse "\n"
                for (int i = 1; i < resultado.Length; i++)
                {
                    resultado[i] = resultado[i].Remove(0, 1);
                }

                //fecha a instancia do FileStream e  retorna a string[] com os valores
                arq1.Close();
                return resultado;

            }
            catch (Exception e)
            {
                if (arq1 != null)
                    arq1.Close();

                resultado = new string[1];
                resultado[0] = ("ERRO:" + e.Message);
                return resultado;
            }

        }

        // a função sobrescreve o texto do arquivo
        public static void SobreEscrever(string path, string texto)
        {
            //Função StreamWriter(string path, bool append), caso o parametro 'append' seja declarado 'false'
            // a função sobrescreve o texto do arquivo
            // caso o parametro 'append' seja declarado 'true'
            //a função adiciona texto ao arquivo
            // achei na internet
            StreamWriter escreve = new StreamWriter(path, false);
            escreve.Write(texto);
            escreve.Close();
        }

        //Gera o codigo de qualquer item(Cliente. Funcionario, Covenio, Produto ou Venda)
        public static string GerarCodigo(string nomeArquivo, string sigla)
        {
            //obtem a leitura do arquivo
            //cada posição do vetor corresponde a uma linha do arquivo
            string[] lerCodigo = LerArquivo($"Codigos/{nomeArquivo}.txt");

            //Sigla é o inicio do codio:
            //Se Cliente = "CL"
            //Se Funcionario = "FC"
            //Se Convenio = "CV"
            //Se Produto = "PR"
            //Se Venda = "VD"
            string codigo = sigla;

            //Declara codigo = 1
            // se a leitura do arquivo que contem o codigo for vazia, atribiu "1"
            int contCodigo = 1;

            //Verifica se a leitura é null ou vazia e screve codigo com valor "1" e 
            // cria o aruivo '.txt' escrito "2" dentro dele
            //obs o nome do arquivo será de acordo com o parametro 'string nomeArquivo' 
            //esse parametro é pasado na chamada da função
            if (lerCodigo == null || lerCodigo[0] == "")
            {
                codigo += ("000" + contCodigo);
                contCodigo++;
                AddLinha($"Codigos/{nomeArquivo}.txt", Convert.ToString(contCodigo));
            }

            //Se leitura estiver con erro retora a mensagem do erro n vetor de indice '0'
            //um posivel erro seria não ter o camiho do arquivo para cria-lo
            else if (lerCodigo[0].Contains("ERRO:"))
                return lerCodigo[0];

            //Gera o codigo do Item
            //Codigo será o texto escrito no arquivo
            // So chega ate aki se a leitura não for vazia
            //e se leitura não conter erro
            else
            {
                contCodigo = int.Parse(lerCodigo[0]);


                // verifica quantos caracteres tem o numero para acresentar 'zeros' a esquerda
                if (lerCodigo[0].Length == 1)
                    codigo += ("000" + contCodigo);
                else if (lerCodigo[0].Length == 2)
                    codigo += ("00" + contCodigo);
                else if (lerCodigo[0].Length == 3)
                    codigo += ("0" + contCodigo);
                else
                    codigo += contCodigo;      //se nuero ja tiver mais de 4 algarismos
                                               //não ha necessidade de colocar 'zeros' a esquerda 
                contCodigo++;


                //chama função de sobrescrever o arquivo
                SobreEscrever($"Codigos/{nomeArquivo}.txt", Convert.ToString(contCodigo));
            }
            return codigo;
        }

        //Edita o arquivo na linha em que o cidigo é igual a o parametro "codigo" passado na chamada da função
        public static void EditarArquivos(string path, string codigo, string linhaAtualizar)
        {
            //obtem a leitura do arquivo
            //cada posição do vetor corresponde a uma linha do arquivo
            string[] lerArquivo = LerArquivo(path);


            //Declara vertor de string dados, cada posição do vetor sera um dado
            // Ex: se for um cliente:
            //dados[0] = Codigo
            //dados[1] = Nome
            //dados[2] = Endereço
            //dados[3] = Telefone
            string[] dados = null;


            //faz a busca do codigo
            for (int i = 0; i < lerArquivo.Length; i++)
            {
                dados = lerArquivo[i].Split('|');

                //Em todas os itens dados[0] será referente ao codigo
                if (dados[0] == codigo)
                {
                    lerArquivo[i] = linhaAtualizar;
                    break; // se identificar o codigo sai do for
                }
            }

            //declara string para novo texto
            string novoTexo = null;

            // monta o novo texto que terá o arquivo, agora com a lunha atualizada
            for (int i = 0; i < (lerArquivo.Length -1); i++)
            {
                novoTexo += lerArquivo[i] + "\r\n"; //Acressenta '/r/n' para tabular e pular a linha
            }

            //Chama função sobreEscrever para atualizar o arquivo
            SobreEscrever(path, novoTexo);
        }

        //Deleta a linha em que o cidigo é igual a o parametro "codigo" passado na chamada da função
        public static void DeletarLinha(string path, string codigo)
        {
            //obtem a leitura do arquivo
            //cada posição do vetor corresponde a uma linha do arquivo
            string[] lerArquivo = LerArquivo(path);


            //Declara vertor de string dados, cada posição do vetor sera um dado
            string[] dados = null;

            //declara string para novo texto
            string novoTexo = null;

            //faz a busca do codigo
            for (int i = 0; i < lerArquivo.Length-1; i++)
            {
                // Ex: se for um cliente:
                //dados[0] = Codigo
                //dados[1] = Nome
                //dados[2] = Endereço
                //dados[3] = Telefone
                dados = lerArquivo[i].Split('|');

                //Em todas os itens dados[0] será referente ao codigo
                //Se o codigo for igual ele não acressenta o a posição do vetor 'lerArquivo[i]' a string 'novoTexo'
                if (dados[0] != codigo)
                {
                    // monta o novo texto que terá o arquivo, agora com a lunha deletada
                    novoTexo += lerArquivo[i] + "\r\n"; //Acressenta '/r/n' para tabular e pular a linha
                }

            }

            //Chama função sobreEscrever para atualizar o arquivo
            SobreEscrever(path, novoTexo);
        }

        //Pesquisa os nomes digitados, somente para Clientes e funcionarios
        public static string[] PesquisaArquivo(string path, string pesquisa,int indice)
        {
            //obtem a leitura do arquivo
            //cada posição do vetor corresponde a uma linha do arquivo
            //Chama o metodo 'LerArquivo' dentro dessa classe geral
            string[] lerArquivo = LerArquivo(path);

            //Declara vertor de string dados, cada posição do vetor sera um dado
            string[] dados = null;

            //Recebe o resultado da pesquisa
            string resultado = null;

            //faz a busca da pesquisa
            for (int i = 0; i < lerArquivo.Length - 1; i++)
            {
                // Ex: se for um cliente:
                //dados[0] = Codigo
                //dados[1] = Nome
                //dados[2] = Endereço
                //dados[3] = Telefone
                dados = lerArquivo[i].Split('|');

                //Em todas os itens dados[0] será referente ao codigo
                //Se o codigo for igual ele não acressenta o a posição do vetor 'lerArquivo[i]' a string 'novoTexo'
                if (dados[indice] == pesquisa)
                {
                    // monta o novo texto que terá o arquivo, agora com a lunha deletada
                    resultado += lerArquivo[i] + "#"; //Acressenta '#' para poder quebar a linha nesse ponto
                }
            }

            //verifica e a pesquisa encontrou algum resultado
            if (resultado != null)
                //retorna o resultado da pesquisa, cada split quera o resultado em uma posição do vetor
                //ao inves de declarar uma variavel do tipo string[]
                //ja fiz direto no retorno
                return resultado.Split('#');
            //se não encontrou retorna uma 'srting[] null'
            else
                return null;
        }
    }
}
