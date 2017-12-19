namespace TrabalhoATP.Formularios
{
    partial class EditVendas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
			this.components = new System.ComponentModel.Container();
			this.botOk = new System.Windows.Forms.Button();
			this.produtosBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.funcionariosBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.clientesBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.texProduto = new System.Windows.Forms.ComboBox();
			this.texConvenios = new System.Windows.Forms.ComboBox();
			this.conveniosBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.texFuncionario = new System.Windows.Forms.ComboBox();
			this.texCliente = new System.Windows.Forms.ComboBox();
			this.texValor = new System.Windows.Forms.TextBox();
			this.labelCidade = new System.Windows.Forms.Label();
			this.labelNum = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.labelBairro = new System.Windows.Forms.Label();
			this.labeLogradouro = new System.Windows.Forms.Label();
			this.labelNome = new System.Windows.Forms.Label();
			this.texValorFinal = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.texQuantidade = new System.Windows.Forms.TextBox();
			((System.ComponentModel.ISupportInitialize)(this.produtosBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.funcionariosBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.conveniosBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// botOk
			// 
			this.botOk.Location = new System.Drawing.Point(151, 222);
			this.botOk.Name = "botOk";
			this.botOk.Size = new System.Drawing.Size(53, 32);
			this.botOk.TabIndex = 8;
			this.botOk.Text = "Ok";
			this.botOk.UseVisualStyleBackColor = true;
			this.botOk.Click += new System.EventHandler(this.botOk_Click);
			// 
			// produtosBindingSource
			// 
			this.produtosBindingSource.DataSource = typeof(TrabalhoATP.Classes.Produtos);
			// 
			// funcionariosBindingSource
			// 
			this.funcionariosBindingSource.DataSource = typeof(TrabalhoATP.Classes.Funcionarios);
			// 
			// clientesBindingSource
			// 
			this.clientesBindingSource.DataSource = typeof(TrabalhoATP.Classes.Clientes);
			// 
			// texProduto
			// 
			this.texProduto.DataSource = this.produtosBindingSource;
			this.texProduto.DisplayMember = "descricao";
			this.texProduto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.texProduto.Enabled = false;
			this.texProduto.FormattingEnabled = true;
			this.texProduto.Location = new System.Drawing.Point(102, 4);
			this.texProduto.Name = "texProduto";
			this.texProduto.Size = new System.Drawing.Size(238, 21);
			this.texProduto.TabIndex = 1;
			this.texProduto.SelectedIndexChanged += new System.EventHandler(this.texProduto_SelectedIndexChanged);
			// 
			// texConvenios
			// 
			this.texConvenios.DataSource = this.conveniosBindingSource;
			this.texConvenios.DisplayMember = "nome";
			this.texConvenios.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.texConvenios.FormattingEnabled = true;
			this.texConvenios.Location = new System.Drawing.Point(102, 159);
			this.texConvenios.Name = "texConvenios";
			this.texConvenios.Size = new System.Drawing.Size(238, 21);
			this.texConvenios.TabIndex = 6;
			this.texConvenios.SelectedIndexChanged += new System.EventHandler(this.texConvenios_SelectedIndexChanged);
			// 
			// conveniosBindingSource
			// 
			this.conveniosBindingSource.DataSource = typeof(TrabalhoATP.Classes.Convenios);
			// 
			// texFuncionario
			// 
			this.texFuncionario.DataSource = this.funcionariosBindingSource;
			this.texFuncionario.DisplayMember = "nome";
			this.texFuncionario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.texFuncionario.FormattingEnabled = true;
			this.texFuncionario.Location = new System.Drawing.Point(102, 128);
			this.texFuncionario.Name = "texFuncionario";
			this.texFuncionario.Size = new System.Drawing.Size(238, 21);
			this.texFuncionario.TabIndex = 5;
			// 
			// texCliente
			// 
			this.texCliente.DataSource = this.clientesBindingSource;
			this.texCliente.DisplayMember = "nome";
			this.texCliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.texCliente.FormattingEnabled = true;
			this.texCliente.Location = new System.Drawing.Point(102, 97);
			this.texCliente.Name = "texCliente";
			this.texCliente.Size = new System.Drawing.Size(238, 21);
			this.texCliente.TabIndex = 4;
			// 
			// texValor
			// 
			this.texValor.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.texValor.Enabled = false;
			this.texValor.Location = new System.Drawing.Point(102, 67);
			this.texValor.Name = "texValor";
			this.texValor.Size = new System.Drawing.Size(152, 20);
			this.texValor.TabIndex = 3;
			// 
			// labelCidade
			// 
			this.labelCidade.AutoSize = true;
			this.labelCidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelCidade.Location = new System.Drawing.Point(9, 102);
			this.labelCidade.Name = "labelCidade";
			this.labelCidade.Size = new System.Drawing.Size(52, 16);
			this.labelCidade.TabIndex = 51;
			this.labelCidade.Text = "Cliete:";
			this.labelCidade.UseWaitCursor = true;
			// 
			// labelNum
			// 
			this.labelNum.AutoSize = true;
			this.labelNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelNum.Location = new System.Drawing.Point(9, 71);
			this.labelNum.Name = "labelNum";
			this.labelNum.Size = new System.Drawing.Size(89, 16);
			this.labelNum.TabIndex = 50;
			this.labelNum.Text = "Valor Total:";
			this.labelNum.UseWaitCursor = true;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(9, 164);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(77, 16);
			this.label1.TabIndex = 48;
			this.label1.Text = "Convenio:";
			this.label1.UseWaitCursor = true;
			// 
			// labelBairro
			// 
			this.labelBairro.AutoSize = true;
			this.labelBairro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelBairro.Location = new System.Drawing.Point(9, 133);
			this.labelBairro.Name = "labelBairro";
			this.labelBairro.Size = new System.Drawing.Size(85, 16);
			this.labelBairro.TabIndex = 49;
			this.labelBairro.Text = "Fucionario:";
			this.labelBairro.UseWaitCursor = true;
			// 
			// labeLogradouro
			// 
			this.labeLogradouro.AutoSize = true;
			this.labeLogradouro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labeLogradouro.Location = new System.Drawing.Point(9, 40);
			this.labeLogradouro.Name = "labeLogradouro";
			this.labeLogradouro.Size = new System.Drawing.Size(92, 16);
			this.labeLogradouro.TabIndex = 47;
			this.labeLogradouro.Text = "Quantidade:";
			// 
			// labelNome
			// 
			this.labelNome.AutoSize = true;
			this.labelNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelNome.Location = new System.Drawing.Point(9, 9);
			this.labelNome.Name = "labelNome";
			this.labelNome.Size = new System.Drawing.Size(66, 16);
			this.labelNome.TabIndex = 46;
			this.labelNome.Text = "Produto:";
			// 
			// texValorFinal
			// 
			this.texValorFinal.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.texValorFinal.Enabled = false;
			this.texValorFinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.texValorFinal.Location = new System.Drawing.Point(102, 191);
			this.texValorFinal.Name = "texValorFinal";
			this.texValorFinal.Size = new System.Drawing.Size(152, 20);
			this.texValorFinal.TabIndex = 7;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(9, 195);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(87, 16);
			this.label2.TabIndex = 53;
			this.label2.Text = "Valor Final:";
			this.label2.UseWaitCursor = true;
			// 
			// texQuantidade
			// 
			this.texQuantidade.Location = new System.Drawing.Point(102, 36);
			this.texQuantidade.Name = "texQuantidade";
			this.texQuantidade.Size = new System.Drawing.Size(152, 20);
			this.texQuantidade.TabIndex = 2;
			this.texQuantidade.TextChanged += new System.EventHandler(this.texQuantidade_TextChanged);
			// 
			// EditVendas
			// 
			this.AcceptButton = this.botOk;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(354, 261);
			this.Controls.Add(this.texQuantidade);
			this.Controls.Add(this.texValorFinal);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.texProduto);
			this.Controls.Add(this.texConvenios);
			this.Controls.Add(this.texFuncionario);
			this.Controls.Add(this.texCliente);
			this.Controls.Add(this.texValor);
			this.Controls.Add(this.labelCidade);
			this.Controls.Add(this.labelNum);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.labelBairro);
			this.Controls.Add(this.labeLogradouro);
			this.Controls.Add(this.labelNome);
			this.Controls.Add(this.botOk);
			this.Name = "EditVendas";
			this.Text = "Editar Venda";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.EditVendas_FormClosed);
			this.Load += new System.EventHandler(this.EditVendas_Load);
			((System.ComponentModel.ISupportInitialize)(this.produtosBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.funcionariosBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.conveniosBindingSource)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button botOk;
        private System.Windows.Forms.BindingSource produtosBindingSource;
        private System.Windows.Forms.BindingSource funcionariosBindingSource;
        private System.Windows.Forms.BindingSource clientesBindingSource;
        private System.Windows.Forms.ComboBox texProduto;
        private System.Windows.Forms.ComboBox texConvenios;
        private System.Windows.Forms.ComboBox texFuncionario;
        private System.Windows.Forms.ComboBox texCliente;
        private System.Windows.Forms.TextBox texValor;
        private System.Windows.Forms.Label labelCidade;
        private System.Windows.Forms.Label labelNum;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelBairro;
        private System.Windows.Forms.Label labeLogradouro;
        private System.Windows.Forms.Label labelNome;
        private System.Windows.Forms.BindingSource conveniosBindingSource;
		private System.Windows.Forms.TextBox texValorFinal;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox texQuantidade;
	}
}