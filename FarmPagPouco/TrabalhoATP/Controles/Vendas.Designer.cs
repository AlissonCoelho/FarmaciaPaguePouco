namespace TrabalhoATP.Controles
{
    partial class Vendas
    {
        /// <summary> 
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
			this.components = new System.ComponentModel.Container();
			this.BindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.panel4 = new System.Windows.Forms.Panel();
			this.label2 = new System.Windows.Forms.Label();
			this.boxFuncionario = new System.Windows.Forms.ComboBox();
			this.funcionariosBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.removeFuncionario = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.boxCliente = new System.Windows.Forms.ComboBox();
			this.clientesBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.removCliente = new System.Windows.Forms.Button();
			this.Edit = new System.Windows.Forms.Button();
			this.butDel = new System.Windows.Forms.Button();
			this.butNew = new System.Windows.Forms.Button();
			this.dataGrid = new System.Windows.Forms.DataGridView();
			this.codigoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.produto = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.quantidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.valorTotalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.codigoClienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.codigoFuncionarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.convenios = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.valorFinal = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataVendaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			((System.ComponentModel.ISupportInitialize)(this.BindingSource)).BeginInit();
			this.panel4.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.funcionariosBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGrid)).BeginInit();
			this.SuspendLayout();
			// 
			// BindingSource
			// 
			this.BindingSource.DataSource = typeof(TrabalhoATP.Classes.Vendas);
			// 
			// panel4
			// 
			this.panel4.Controls.Add(this.label2);
			this.panel4.Controls.Add(this.boxFuncionario);
			this.panel4.Controls.Add(this.removeFuncionario);
			this.panel4.Controls.Add(this.label1);
			this.panel4.Controls.Add(this.boxCliente);
			this.panel4.Controls.Add(this.removCliente);
			this.panel4.Controls.Add(this.Edit);
			this.panel4.Controls.Add(this.butDel);
			this.panel4.Controls.Add(this.butNew);
			this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel4.Location = new System.Drawing.Point(0, 0);
			this.panel4.Name = "panel4";
			this.panel4.Size = new System.Drawing.Size(1093, 33);
			this.panel4.TabIndex = 31;
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(493, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(121, 12);
			this.label2.TabIndex = 19;
			this.label2.Text = "Funcionario";
			this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// boxFuncionario
			// 
			this.boxFuncionario.DataSource = this.funcionariosBindingSource;
			this.boxFuncionario.DisplayMember = "nome";
			this.boxFuncionario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.boxFuncionario.FormattingEnabled = true;
			this.boxFuncionario.Location = new System.Drawing.Point(493, 12);
			this.boxFuncionario.Name = "boxFuncionario";
			this.boxFuncionario.Size = new System.Drawing.Size(121, 21);
			this.boxFuncionario.TabIndex = 18;
			this.boxFuncionario.SelectedIndexChanged += new System.EventHandler(this.boxFuncionario_SelectedIndexChanged);
			// 
			// funcionariosBindingSource
			// 
			this.funcionariosBindingSource.DataSource = typeof(TrabalhoATP.Classes.Funcionarios);
			// 
			// removeFuncionario
			// 
			this.removeFuncionario.BackgroundImage = global::TrabalhoATP.Properties.Resources.filter_delete;
			this.removeFuncionario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.removeFuncionario.Location = new System.Drawing.Point(615, 0);
			this.removeFuncionario.Name = "removeFuncionario";
			this.removeFuncionario.Size = new System.Drawing.Size(32, 33);
			this.removeFuncionario.TabIndex = 17;
			this.removeFuncionario.UseVisualStyleBackColor = true;
			this.removeFuncionario.Click += new System.EventHandler(this.removeFuncionario_Click);
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(333, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(121, 12);
			this.label1.TabIndex = 16;
			this.label1.Text = "Cliente";
			this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// boxCliente
			// 
			this.boxCliente.DataSource = this.clientesBindingSource;
			this.boxCliente.DisplayMember = "nome";
			this.boxCliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.boxCliente.FormattingEnabled = true;
			this.boxCliente.Location = new System.Drawing.Point(333, 12);
			this.boxCliente.Name = "boxCliente";
			this.boxCliente.Size = new System.Drawing.Size(121, 21);
			this.boxCliente.TabIndex = 15;
			this.boxCliente.SelectedIndexChanged += new System.EventHandler(this.boxCliente_SelectedIndexChanged);
			// 
			// clientesBindingSource
			// 
			this.clientesBindingSource.DataSource = typeof(TrabalhoATP.Classes.Clientes);
			// 
			// removCliente
			// 
			this.removCliente.BackgroundImage = global::TrabalhoATP.Properties.Resources.filter_delete;
			this.removCliente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.removCliente.Location = new System.Drawing.Point(455, 0);
			this.removCliente.Name = "removCliente";
			this.removCliente.Size = new System.Drawing.Size(32, 33);
			this.removCliente.TabIndex = 14;
			this.removCliente.UseVisualStyleBackColor = true;
			this.removCliente.Click += new System.EventHandler(this.removCliente_Click);
			// 
			// Edit
			// 
			this.Edit.Dock = System.Windows.Forms.DockStyle.Left;
			this.Edit.Location = new System.Drawing.Point(222, 0);
			this.Edit.Name = "Edit";
			this.Edit.Size = new System.Drawing.Size(111, 33);
			this.Edit.TabIndex = 2;
			this.Edit.Text = "Edit Venda";
			this.Edit.UseVisualStyleBackColor = true;
			this.Edit.Click += new System.EventHandler(this.Edit_Click);
			// 
			// butDel
			// 
			this.butDel.Dock = System.Windows.Forms.DockStyle.Left;
			this.butDel.Location = new System.Drawing.Point(111, 0);
			this.butDel.Name = "butDel";
			this.butDel.Size = new System.Drawing.Size(111, 33);
			this.butDel.TabIndex = 1;
			this.butDel.Text = "Deletar Venda";
			this.butDel.UseVisualStyleBackColor = true;
			this.butDel.Click += new System.EventHandler(this.butDel_Click);
			// 
			// butNew
			// 
			this.butNew.Dock = System.Windows.Forms.DockStyle.Left;
			this.butNew.Location = new System.Drawing.Point(0, 0);
			this.butNew.Name = "butNew";
			this.butNew.Size = new System.Drawing.Size(111, 33);
			this.butNew.TabIndex = 0;
			this.butNew.Text = "Nova Venda";
			this.butNew.UseVisualStyleBackColor = true;
			this.butNew.Click += new System.EventHandler(this.butNew_Click);
			// 
			// dataGrid
			// 
			this.dataGrid.AllowUserToAddRows = false;
			this.dataGrid.AllowUserToDeleteRows = false;
			this.dataGrid.AutoGenerateColumns = false;
			this.dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigoDataGridViewTextBoxColumn,
            this.produto,
            this.quantidade,
            this.valorTotalDataGridViewTextBoxColumn,
            this.codigoClienteDataGridViewTextBoxColumn,
            this.codigoFuncionarioDataGridViewTextBoxColumn,
            this.convenios,
            this.valorFinal,
            this.dataVendaDataGridViewTextBoxColumn});
			this.dataGrid.DataSource = this.BindingSource;
			this.dataGrid.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dataGrid.Location = new System.Drawing.Point(0, 33);
			this.dataGrid.Name = "dataGrid";
			this.dataGrid.ReadOnly = true;
			this.dataGrid.Size = new System.Drawing.Size(1093, 339);
			this.dataGrid.TabIndex = 32;
			this.dataGrid.Tag = "";
			// 
			// codigoDataGridViewTextBoxColumn
			// 
			this.codigoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
			this.codigoDataGridViewTextBoxColumn.DataPropertyName = "codigo";
			this.codigoDataGridViewTextBoxColumn.HeaderText = "Código";
			this.codigoDataGridViewTextBoxColumn.MinimumWidth = 100;
			this.codigoDataGridViewTextBoxColumn.Name = "codigoDataGridViewTextBoxColumn";
			this.codigoDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// produto
			// 
			this.produto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
			this.produto.DataPropertyName = "produto";
			this.produto.HeaderText = "Produto";
			this.produto.MinimumWidth = 100;
			this.produto.Name = "produto";
			this.produto.ReadOnly = true;
			// 
			// quantidade
			// 
			this.quantidade.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
			this.quantidade.DataPropertyName = "quantidade";
			this.quantidade.HeaderText = "Quantidade";
			this.quantidade.MinimumWidth = 100;
			this.quantidade.Name = "quantidade";
			this.quantidade.ReadOnly = true;
			// 
			// valorTotalDataGridViewTextBoxColumn
			// 
			this.valorTotalDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
			this.valorTotalDataGridViewTextBoxColumn.DataPropertyName = "valorTotal";
			this.valorTotalDataGridViewTextBoxColumn.HeaderText = "Valor Total";
			this.valorTotalDataGridViewTextBoxColumn.MinimumWidth = 100;
			this.valorTotalDataGridViewTextBoxColumn.Name = "valorTotalDataGridViewTextBoxColumn";
			this.valorTotalDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// codigoClienteDataGridViewTextBoxColumn
			// 
			this.codigoClienteDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
			this.codigoClienteDataGridViewTextBoxColumn.DataPropertyName = "codigoCliente";
			this.codigoClienteDataGridViewTextBoxColumn.HeaderText = "Cliente";
			this.codigoClienteDataGridViewTextBoxColumn.MinimumWidth = 100;
			this.codigoClienteDataGridViewTextBoxColumn.Name = "codigoClienteDataGridViewTextBoxColumn";
			this.codigoClienteDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// codigoFuncionarioDataGridViewTextBoxColumn
			// 
			this.codigoFuncionarioDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
			this.codigoFuncionarioDataGridViewTextBoxColumn.DataPropertyName = "codigoFuncionario";
			this.codigoFuncionarioDataGridViewTextBoxColumn.HeaderText = "Funcionario";
			this.codigoFuncionarioDataGridViewTextBoxColumn.MinimumWidth = 100;
			this.codigoFuncionarioDataGridViewTextBoxColumn.Name = "codigoFuncionarioDataGridViewTextBoxColumn";
			this.codigoFuncionarioDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// convenios
			// 
			this.convenios.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
			this.convenios.DataPropertyName = "convenios";
			this.convenios.HeaderText = "Convenios";
			this.convenios.MinimumWidth = 100;
			this.convenios.Name = "convenios";
			this.convenios.ReadOnly = true;
			// 
			// valorFinal
			// 
			this.valorFinal.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
			this.valorFinal.DataPropertyName = "valorFinal";
			this.valorFinal.HeaderText = "Valor Final";
			this.valorFinal.MinimumWidth = 100;
			this.valorFinal.Name = "valorFinal";
			this.valorFinal.ReadOnly = true;
			// 
			// dataVendaDataGridViewTextBoxColumn
			// 
			this.dataVendaDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
			this.dataVendaDataGridViewTextBoxColumn.DataPropertyName = "dataVenda";
			this.dataVendaDataGridViewTextBoxColumn.HeaderText = "Data Venda";
			this.dataVendaDataGridViewTextBoxColumn.MinimumWidth = 100;
			this.dataVendaDataGridViewTextBoxColumn.Name = "dataVendaDataGridViewTextBoxColumn";
			this.dataVendaDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// Vendas
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.dataGrid);
			this.Controls.Add(this.panel4);
			this.Name = "Vendas";
			this.Size = new System.Drawing.Size(1093, 372);
			((System.ComponentModel.ISupportInitialize)(this.BindingSource)).EndInit();
			this.panel4.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.funcionariosBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGrid)).EndInit();
			this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource BindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantidadeTotalDataGridViewTextBoxColumn;
		public System.Windows.Forms.Panel panel4;
		public System.Windows.Forms.Button Edit;
		public System.Windows.Forms.Button butDel;
		public System.Windows.Forms.Button butNew;
        public System.Windows.Forms.BindingSource funcionariosBindingSource;
        public System.Windows.Forms.BindingSource clientesBindingSource;
		private System.Windows.Forms.Label label2;
		public System.Windows.Forms.ComboBox boxFuncionario;
		private System.Windows.Forms.Button removeFuncionario;
		private System.Windows.Forms.Label label1;
		public System.Windows.Forms.ComboBox boxCliente;
		private System.Windows.Forms.Button removCliente;
		public System.Windows.Forms.DataGridView dataGrid;
		private System.Windows.Forms.DataGridViewTextBoxColumn codigoDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn produto;
		private System.Windows.Forms.DataGridViewTextBoxColumn quantidade;
		private System.Windows.Forms.DataGridViewTextBoxColumn valorTotalDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn codigoClienteDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn codigoFuncionarioDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn convenios;
		private System.Windows.Forms.DataGridViewTextBoxColumn valorFinal;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataVendaDataGridViewTextBoxColumn;
	}
}
