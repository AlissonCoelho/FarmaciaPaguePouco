namespace TrabalhoATP.Controles
{
    partial class Convenios
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
			this.Edit = new System.Windows.Forms.Button();
			this.butDel = new System.Windows.Forms.Button();
			this.butNew = new System.Windows.Forms.Button();
			this.dataGrid = new System.Windows.Forms.DataGridView();
			this.codigoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.nomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.descontoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.BindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.panel4.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGrid)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.BindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// panel4
			// 
			this.panel4.Controls.Add(this.Edit);
			this.panel4.Controls.Add(this.butDel);
			this.panel4.Controls.Add(this.butNew);
			this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel4.Location = new System.Drawing.Point(0, 0);
			this.panel4.Name = "panel4";
			this.panel4.Size = new System.Drawing.Size(1093, 33);
			this.panel4.TabIndex = 27;
			// 
			// Edit
			// 
			this.Edit.Dock = System.Windows.Forms.DockStyle.Left;
			this.Edit.Location = new System.Drawing.Point(222, 0);
			this.Edit.Name = "Edit";
			this.Edit.Size = new System.Drawing.Size(111, 33);
			this.Edit.TabIndex = 2;
			this.Edit.Text = "Editar Convenio";
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
			this.butDel.Text = "Deletar Convenio";
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
			this.butNew.Text = "Novo Convenio";
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
            this.nomeDataGridViewTextBoxColumn,
            this.descontoDataGridViewTextBoxColumn});
			this.dataGrid.DataSource = this.BindingSource;
			this.dataGrid.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dataGrid.Location = new System.Drawing.Point(0, 33);
			this.dataGrid.Name = "dataGrid";
			this.dataGrid.ReadOnly = true;
			this.dataGrid.Size = new System.Drawing.Size(1093, 339);
			this.dataGrid.TabIndex = 29;
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
			// nomeDataGridViewTextBoxColumn
			// 
			this.nomeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
			this.nomeDataGridViewTextBoxColumn.DataPropertyName = "nome";
			this.nomeDataGridViewTextBoxColumn.HeaderText = "Nome";
			this.nomeDataGridViewTextBoxColumn.MinimumWidth = 100;
			this.nomeDataGridViewTextBoxColumn.Name = "nomeDataGridViewTextBoxColumn";
			this.nomeDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// descontoDataGridViewTextBoxColumn
			// 
			this.descontoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
			this.descontoDataGridViewTextBoxColumn.DataPropertyName = "desconto";
			this.descontoDataGridViewTextBoxColumn.HeaderText = "Desconto";
			this.descontoDataGridViewTextBoxColumn.MinimumWidth = 100;
			this.descontoDataGridViewTextBoxColumn.Name = "descontoDataGridViewTextBoxColumn";
			this.descontoDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// BindingSource
			// 
			this.BindingSource.DataSource = typeof(TrabalhoATP.Classes.Convenios);
			// 
			// Convenios
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.dataGrid);
			this.Controls.Add(this.panel4);
			this.Name = "Convenios";
			this.Size = new System.Drawing.Size(1093, 372);
			this.panel4.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGrid)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.BindingSource)).EndInit();
			this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Panel panel4;
        public System.Windows.Forms.Button Edit;
        public System.Windows.Forms.Button butDel;
        public System.Windows.Forms.Button butNew;
        private System.Windows.Forms.BindingSource BindingSource;
        public System.Windows.Forms.DataGridView dataGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descontoDataGridViewTextBoxColumn;
    }
}
