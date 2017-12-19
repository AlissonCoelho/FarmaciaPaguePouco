using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace TrabalhoATP
{
    public partial class principal : Form
    {
        //declara variavel tipo color
        //para obter a cor atual do controle
        Color _sistema;

        public principal()
        {
            //os controles de usuario foram declarados globais na classe 'Programa'
            //pois srão utilizados em muitas partes do projeto
            // instancia os controle
            Program._controlCliente = new Controles.Clientes();
            Program._controlfunc = new Controles.Funcionarios();
            Program._controlProdutos = new Controles.Produtos();
            Program._controlConvenios = new Controles.Convenios();
            Program._controlVendas = new Controles.Vendas();

            InitializeComponent();

            //inicia com o cliente selecionado
            //muda a cor do botão para 'Aqua'
            botClientes.BackColor = Color.Aqua;

            //no formulario principal foi declarado um panel
            //esse panel é onde vai ser chamado os controles de usuarios

            // aki ele limpa o panel
            panelControles.Controls.Clear();

            // aki é chamado o controle 'Clientes' no painel 'panelControles'
            panelControles.Controls.Add(Program._controlCliente);

            //Atualiza o datagrid no controle clientes
            Program._controlCliente.Atualizar();

            //obtem a cor atual do sistema
            _sistema = SystemColors.Control;

			//Atualiza Tela
			Application.DoEvents();
		}

        //chama o controle Clientes
        private void botClientes_Click(object sender, EventArgs e)
        {
            //muda a cor do botão para 'Aqua'
            botClientes.BackColor = Color.Aqua;

            //no formulario principal foi declarado um panel
            //esse panel é onde vai ser chamado os controles de usuarios

            // aki ele limpa o panel
            panelControles.Controls.Clear();

            // aki é chamado o controle 'Clientes' no painel 'panelControles'
            panelControles.Controls.Add(Program._controlCliente);

            //retorna a cor dos botões para cor do sistema
            botFuncionarios.BackColor = _sistema;
            botProdutos.BackColor = _sistema;
            botConvenios.BackColor = _sistema;
            botVendas.BackColor = _sistema;


            //Atualiza o datagrid no controle clientes
            Program._controlCliente.Atualizar();

            //Atualiza Tela
            Application.DoEvents();
        }

        //chama o controle Fucionarios
        private void botFuncionarios_Click(object sender, EventArgs e)
        {
            //muda a cor do botão para 'Aqua'
            botFuncionarios.BackColor = Color.Aqua;

            //retorna a cor dos botões para cor do sistema
            botClientes.BackColor = _sistema;
            botProdutos.BackColor = _sistema;
            botConvenios.BackColor = _sistema;
            botVendas.BackColor = _sistema;


            //no formulario principal foi declarado um panel
            //esse panel é onde vai ser chamado os controles de usuarios

            // aki ele limpa o panel
            panelControles.Controls.Clear();

            // aki é chamado o controle 'Funcionarios' no painel 'panelControles'
            panelControles.Controls.Add(Program._controlfunc);

            //Atualiza o datagrid no controle Funcionarios
            Program._controlfunc.Atualizar();

            //Atualiza Tela
            Application.DoEvents();
        }

        //chama o controle Produtos
        private void botVrodutos_Click(object sender, EventArgs e)
        {
            //muda a cor do botão para 'Aqua'
            botProdutos.BackColor = Color.Aqua;

            //no formulario principal foi declarado um panel
            //esse panel é onde vai ser chamado os controles de usuarios

            // aki ele limpa o panel
            panelControles.Controls.Clear();

            // aki é chamado o controle 'Produtos' no painel 'panelControles'
            panelControles.Controls.Add(Program._controlProdutos);

            //retorna a cor dos botões para cor do sistema
            botFuncionarios.BackColor = _sistema;
            botClientes.BackColor = _sistema;
            botConvenios.BackColor = _sistema;
            botVendas.BackColor = _sistema;

            //Atualiza o datagrid no controle clientes
            Program._controlProdutos.Atualizar();

            //Atualiza Tela
            Application.DoEvents();
        }

        //chama o controle Convenios
        private void botConvenios_Click(object sender, EventArgs e)
        {
            //muda a cor do botão para 'Aqua'
            botConvenios.BackColor = Color.Aqua;

            //no formulario principal foi declarado um panel
            //esse panel é onde vai ser chamado os controles de usuarios

            // aki ele limpa o panel
            panelControles.Controls.Clear();

            // aki é chamado o controle 'Produtos' no painel 'panelControles'
            panelControles.Controls.Add(Program._controlConvenios);


            //retorna a cor dos botões para cor do sistema
            botFuncionarios.BackColor = _sistema;
            botClientes.BackColor = _sistema;
            botProdutos.BackColor = _sistema;
            botVendas.BackColor = _sistema;


            //Atualiza o datagrid no controle clientes
            Program._controlConvenios.Atualizar();

            //Atualiza Tela
            Application.DoEvents();
        }

        //chama o controle Vendas
        private void botVendas_Click(object sender, EventArgs e)
        {
            //muda a cor do botão para 'Aqua'
            botVendas.BackColor = Color.Aqua;

            //no formulario principal foi declarado um panel
            //esse panel é onde vai ser chamado os controles de usuarios

            // aki ele limpa o panel
            panelControles.Controls.Clear();

            // aki é chamado o controle 'Produtos' no painel 'panelControles'
            panelControles.Controls.Add(Program._controlVendas);


            //retorna a cor dos botões para cor do sistema
            botFuncionarios.BackColor = _sistema;
            botClientes.BackColor = _sistema;
            botProdutos.BackColor = _sistema;
            botConvenios.BackColor = _sistema;

            //Remove filtros do controle Produtos como 'false'
            Program._controlProdutos.checkBoxMedicamentos.Checked = false;
            Program._controlProdutos.checkBoxPerfumaria.Checked = false;
            Program._controlProdutos.checkBoxOutros.Checked = false;
			Program._controlProdutos._verificarEstoque = 2147483647;

			//zera os filtros do controle vendas
			Program._controlVendas.boxCliente.SelectedItem = null;
			Program._controlVendas.boxFuncionario.SelectedItem = null;

            Program._controlVendas.clientesBindingSource.DataSource = Program._controlCliente.Atualizar();
            Program._controlVendas.funcionariosBindingSource.DataSource = Program._controlfunc.Atualizar();

            //Atualiza o datagrid no controle clientes
            Program._controlVendas.Atualizar();

            Program._controlVendas.boxCliente.SelectedItem = null;
            Program._controlVendas.boxFuncionario.SelectedItem = null;

            //Atualiza Tela
            Application.DoEvents();
        }
    }
}
