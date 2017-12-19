namespace TrabalhoATP.Controles
{
    partial class Produtos
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
            this.panel4 = new System.Windows.Forms.Panel();
            this.checkBoxOutros = new System.Windows.Forms.CheckBox();
            this.checkBoxPerfumaria = new System.Windows.Forms.CheckBox();
            this.checkBoxMedicamentos = new System.Windows.Forms.CheckBox();
            this.Edit = new System.Windows.Forms.Button();
            this.butDel = new System.Windows.Forms.Button();
            this.butNew = new System.Windows.Forms.Button();
            this.dataGrid = new System.Windows.Forms.DataGridView();
            this.tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.removEstoque = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.codigoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descricaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantidadeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precoCustoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precoVendaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.removEstoque);
            this.panel4.Controls.Add(this.checkBoxOutros);
            this.panel4.Controls.Add(this.checkBoxPerfumaria);
            this.panel4.Controls.Add(this.checkBoxMedicamentos);
            this.panel4.Controls.Add(this.Edit);
            this.panel4.Controls.Add(this.butDel);
            this.panel4.Controls.Add(this.butNew);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1093, 33);
            this.panel4.TabIndex = 27;
            // 
            // checkBoxOutros
            // 
            this.checkBoxOutros.AutoSize = true;
            this.checkBoxOutros.Location = new System.Drawing.Point(569, 6);
            this.checkBoxOutros.Name = "checkBoxOutros";
            this.checkBoxOutros.Size = new System.Drawing.Size(57, 17);
            this.checkBoxOutros.TabIndex = 33;
            this.checkBoxOutros.Text = "Outros";
            this.checkBoxOutros.UseVisualStyleBackColor = true;
            this.checkBoxOutros.CheckedChanged += new System.EventHandler(this.checkBoxOutros_CheckedChanged);
            // 
            // checkBoxPerfumaria
            // 
            this.checkBoxPerfumaria.AutoSize = true;
            this.checkBoxPerfumaria.Location = new System.Drawing.Point(471, 6);
            this.checkBoxPerfumaria.Name = "checkBoxPerfumaria";
            this.checkBoxPerfumaria.Size = new System.Drawing.Size(76, 17);
            this.checkBoxPerfumaria.TabIndex = 32;
            this.checkBoxPerfumaria.Text = "Perfumaria";
            this.checkBoxPerfumaria.UseVisualStyleBackColor = true;
            this.checkBoxPerfumaria.CheckedChanged += new System.EventHandler(this.checkBoxPerfumaria_CheckedChanged);
            // 
            // checkBoxMedicamentos
            // 
            this.checkBoxMedicamentos.AutoSize = true;
            this.checkBoxMedicamentos.Location = new System.Drawing.Point(354, 6);
            this.checkBoxMedicamentos.Name = "checkBoxMedicamentos";
            this.checkBoxMedicamentos.Size = new System.Drawing.Size(95, 17);
            this.checkBoxMedicamentos.TabIndex = 31;
            this.checkBoxMedicamentos.TabStop = false;
            this.checkBoxMedicamentos.Text = "Medicamentos";
            this.checkBoxMedicamentos.UseVisualStyleBackColor = true;
            this.checkBoxMedicamentos.CheckedChanged += new System.EventHandler(this.checkBoxMedicamentos_CheckedChanged);
            // 
            // Edit
            // 
            this.Edit.Dock = System.Windows.Forms.DockStyle.Left;
            this.Edit.Location = new System.Drawing.Point(222, 0);
            this.Edit.Name = "Edit";
            this.Edit.Size = new System.Drawing.Size(111, 33);
            this.Edit.TabIndex = 2;
            this.Edit.Text = "Editar Produto";
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
            this.butDel.Text = "Deletar Produto";
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
            this.butNew.Text = "Novo Produto";
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
            this.descricaoDataGridViewTextBoxColumn,
            this.quantidadeDataGridViewTextBoxColumn,
            this.precoCustoDataGridViewTextBoxColumn,
            this.precoVendaDataGridViewTextBoxColumn,
            this.tipo});
            this.dataGrid.DataSource = this.BindingSource;
            this.dataGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGrid.Location = new System.Drawing.Point(0, 33);
            this.dataGrid.Name = "dataGrid";
            this.dataGrid.ReadOnly = true;
            this.dataGrid.Size = new System.Drawing.Size(1093, 339);
            this.dataGrid.TabIndex = 30;
            this.dataGrid.Tag = "";
            // 
            // tipo
            // 
            this.tipo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.tipo.DataPropertyName = "tipo";
            this.tipo.HeaderText = "Tipo";
            this.tipo.MinimumWidth = 100;
            this.tipo.Name = "tipo";
            this.tipo.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(638, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 12);
            this.label1.TabIndex = 36;
            this.label1.Text = "Estoque";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // removEstoque
            // 
            this.removEstoque.BackgroundImage = global::TrabalhoATP.Properties.Resources.filter_delete;
            this.removEstoque.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.removEstoque.Location = new System.Drawing.Point(760, 0);
            this.removEstoque.Name = "removEstoque";
            this.removEstoque.Size = new System.Drawing.Size(32, 33);
            this.removEstoque.TabIndex = 34;
            this.removEstoque.UseVisualStyleBackColor = true;
            this.removEstoque.Click += new System.EventHandler(this.removEstoque_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(638, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(121, 20);
            this.textBox1.TabIndex = 31;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
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
            // descricaoDataGridViewTextBoxColumn
            // 
            this.descricaoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.descricaoDataGridViewTextBoxColumn.DataPropertyName = "descricao";
            this.descricaoDataGridViewTextBoxColumn.HeaderText = "Descricao";
            this.descricaoDataGridViewTextBoxColumn.MinimumWidth = 100;
            this.descricaoDataGridViewTextBoxColumn.Name = "descricaoDataGridViewTextBoxColumn";
            this.descricaoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // quantidadeDataGridViewTextBoxColumn
            // 
            this.quantidadeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.quantidadeDataGridViewTextBoxColumn.DataPropertyName = "quantidade";
            this.quantidadeDataGridViewTextBoxColumn.HeaderText = "Quantidade";
            this.quantidadeDataGridViewTextBoxColumn.MinimumWidth = 100;
            this.quantidadeDataGridViewTextBoxColumn.Name = "quantidadeDataGridViewTextBoxColumn";
            this.quantidadeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // precoCustoDataGridViewTextBoxColumn
            // 
            this.precoCustoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.precoCustoDataGridViewTextBoxColumn.DataPropertyName = "precoCusto";
            this.precoCustoDataGridViewTextBoxColumn.HeaderText = "Preco Custo";
            this.precoCustoDataGridViewTextBoxColumn.MinimumWidth = 100;
            this.precoCustoDataGridViewTextBoxColumn.Name = "precoCustoDataGridViewTextBoxColumn";
            this.precoCustoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // precoVendaDataGridViewTextBoxColumn
            // 
            this.precoVendaDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.precoVendaDataGridViewTextBoxColumn.DataPropertyName = "precoVenda";
            this.precoVendaDataGridViewTextBoxColumn.HeaderText = "Preco Venda";
            this.precoVendaDataGridViewTextBoxColumn.MinimumWidth = 100;
            this.precoVendaDataGridViewTextBoxColumn.Name = "precoVendaDataGridViewTextBoxColumn";
            this.precoVendaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // BindingSource
            // 
            this.BindingSource.DataSource = typeof(TrabalhoATP.Classes.Produtos);
            // 
            // Produtos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGrid);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.panel4);
            this.Name = "Produtos";
            this.Size = new System.Drawing.Size(1093, 372);
            this.Load += new System.EventHandler(this.Produtos_Load);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Panel panel4;
        public System.Windows.Forms.Button Edit;
        public System.Windows.Forms.Button butDel;
        public System.Windows.Forms.Button butNew;
        public System.Windows.Forms.DataGridView dataGrid;
        private System.Windows.Forms.BindingSource BindingSource;
        public System.Windows.Forms.CheckBox checkBoxOutros;
        public System.Windows.Forms.CheckBox checkBoxPerfumaria;
        public System.Windows.Forms.CheckBox checkBoxMedicamentos;
		private System.Windows.Forms.DataGridViewTextBoxColumn codigoDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn descricaoDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn quantidadeDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn precoCustoDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn precoVendaDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn tipo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button removEstoque;
        private System.Windows.Forms.TextBox textBox1;
    }
}
