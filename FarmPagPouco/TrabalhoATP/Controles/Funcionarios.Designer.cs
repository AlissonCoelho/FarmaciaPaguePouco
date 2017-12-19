namespace TrabalhoATP.Controles
{
	partial class Funcionarios
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.texPesquisar = new System.Windows.Forms.TextBox();
            this.pesquisar = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.EditFunc = new System.Windows.Forms.Button();
            this.butDelFunc = new System.Windows.Forms.Button();
            this.butNewFunc = new System.Windows.Forms.Button();
            this.dataGridViewFunc = new System.Windows.Forms.DataGridView();
            this.codigoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cargoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Salario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.horarioChegarDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.horarioSairDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.funcionariosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFunc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.funcionariosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.texPesquisar);
            this.panel3.Controls.Add(this.pesquisar);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1093, 33);
            this.panel3.TabIndex = 22;
            // 
            // texPesquisar
            // 
            this.texPesquisar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.texPesquisar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.texPesquisar.Location = new System.Drawing.Point(0, 0);
            this.texPesquisar.Name = "texPesquisar";
            this.texPesquisar.Size = new System.Drawing.Size(1035, 31);
            this.texPesquisar.TabIndex = 9;
            // 
            // pesquisar
            // 
            this.pesquisar.BackgroundImage = global::TrabalhoATP.Properties.Resources.search;
            this.pesquisar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pesquisar.Dock = System.Windows.Forms.DockStyle.Right;
            this.pesquisar.Location = new System.Drawing.Point(1035, 0);
            this.pesquisar.Name = "pesquisar";
            this.pesquisar.Size = new System.Drawing.Size(58, 33);
            this.pesquisar.TabIndex = 8;
            this.pesquisar.UseVisualStyleBackColor = true;
            this.pesquisar.Click += new System.EventHandler(this.pesquisar_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.EditFunc);
            this.panel4.Controls.Add(this.butDelFunc);
            this.panel4.Controls.Add(this.butNewFunc);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 33);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1093, 33);
            this.panel4.TabIndex = 23;
            // 
            // EditFunc
            // 
            this.EditFunc.Dock = System.Windows.Forms.DockStyle.Left;
            this.EditFunc.Location = new System.Drawing.Point(222, 0);
            this.EditFunc.Name = "EditFunc";
            this.EditFunc.Size = new System.Drawing.Size(111, 33);
            this.EditFunc.TabIndex = 2;
            this.EditFunc.Text = "Editar Funcionario";
            this.EditFunc.UseVisualStyleBackColor = true;
            this.EditFunc.Click += new System.EventHandler(this.EditFunc_Click);
            // 
            // butDelFunc
            // 
            this.butDelFunc.Dock = System.Windows.Forms.DockStyle.Left;
            this.butDelFunc.Location = new System.Drawing.Point(111, 0);
            this.butDelFunc.Name = "butDelFunc";
            this.butDelFunc.Size = new System.Drawing.Size(111, 33);
            this.butDelFunc.TabIndex = 1;
            this.butDelFunc.Text = "Deletar Funcionario";
            this.butDelFunc.UseVisualStyleBackColor = true;
            this.butDelFunc.Click += new System.EventHandler(this.butDelFunc_Click);
            // 
            // butNewFunc
            // 
            this.butNewFunc.Dock = System.Windows.Forms.DockStyle.Left;
            this.butNewFunc.Location = new System.Drawing.Point(0, 0);
            this.butNewFunc.Name = "butNewFunc";
            this.butNewFunc.Size = new System.Drawing.Size(111, 33);
            this.butNewFunc.TabIndex = 0;
            this.butNewFunc.Text = "Novo Funcionario";
            this.butNewFunc.UseVisualStyleBackColor = true;
            this.butNewFunc.Click += new System.EventHandler(this.butNewFunc_Click);
            // 
            // dataGridViewFunc
            // 
            this.dataGridViewFunc.AllowUserToAddRows = false;
            this.dataGridViewFunc.AllowUserToDeleteRows = false;
            this.dataGridViewFunc.AutoGenerateColumns = false;
            this.dataGridViewFunc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFunc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigoDataGridViewTextBoxColumn,
            this.nomeDataGridViewTextBoxColumn,
            this.telefoneDataGridViewTextBoxColumn,
            this.cargoDataGridViewTextBoxColumn,
            this.Salario,
            this.horarioChegarDataGridViewTextBoxColumn,
            this.horarioSairDataGridViewTextBoxColumn});
            this.dataGridViewFunc.DataSource = this.funcionariosBindingSource;
            this.dataGridViewFunc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewFunc.Location = new System.Drawing.Point(0, 66);
            this.dataGridViewFunc.Name = "dataGridViewFunc";
            this.dataGridViewFunc.ReadOnly = true;
            this.dataGridViewFunc.Size = new System.Drawing.Size(1093, 306);
            this.dataGridViewFunc.TabIndex = 24;
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
            // telefoneDataGridViewTextBoxColumn
            // 
            this.telefoneDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.telefoneDataGridViewTextBoxColumn.DataPropertyName = "telefone";
            this.telefoneDataGridViewTextBoxColumn.HeaderText = "Telefone";
            this.telefoneDataGridViewTextBoxColumn.MinimumWidth = 100;
            this.telefoneDataGridViewTextBoxColumn.Name = "telefoneDataGridViewTextBoxColumn";
            this.telefoneDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cargoDataGridViewTextBoxColumn
            // 
            this.cargoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.cargoDataGridViewTextBoxColumn.DataPropertyName = "cargo";
            this.cargoDataGridViewTextBoxColumn.HeaderText = "Cargo";
            this.cargoDataGridViewTextBoxColumn.MinimumWidth = 100;
            this.cargoDataGridViewTextBoxColumn.Name = "cargoDataGridViewTextBoxColumn";
            this.cargoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Salario
            // 
            this.Salario.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.Salario.DataPropertyName = "salario";
            this.Salario.HeaderText = "Salario";
            this.Salario.MinimumWidth = 100;
            this.Salario.Name = "Salario";
            this.Salario.ReadOnly = true;
            // 
            // horarioChegarDataGridViewTextBoxColumn
            // 
            this.horarioChegarDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.horarioChegarDataGridViewTextBoxColumn.DataPropertyName = "horarioChegar";
            this.horarioChegarDataGridViewTextBoxColumn.HeaderText = "Inicio Expediente";
            this.horarioChegarDataGridViewTextBoxColumn.MinimumWidth = 100;
            this.horarioChegarDataGridViewTextBoxColumn.Name = "horarioChegarDataGridViewTextBoxColumn";
            this.horarioChegarDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // horarioSairDataGridViewTextBoxColumn
            // 
            this.horarioSairDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.horarioSairDataGridViewTextBoxColumn.DataPropertyName = "horarioSair";
            this.horarioSairDataGridViewTextBoxColumn.HeaderText = "Fim Expediente";
            this.horarioSairDataGridViewTextBoxColumn.MinimumWidth = 100;
            this.horarioSairDataGridViewTextBoxColumn.Name = "horarioSairDataGridViewTextBoxColumn";
            this.horarioSairDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // funcionariosBindingSource
            // 
            this.funcionariosBindingSource.DataSource = typeof(TrabalhoATP.Classes.Funcionarios);
            // 
            // Funcionarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridViewFunc);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Name = "Funcionarios";
            this.Size = new System.Drawing.Size(1093, 372);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFunc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.funcionariosBindingSource)).EndInit();
            this.ResumeLayout(false);

		}

		#endregion
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox texPesquisar;
        private System.Windows.Forms.Button pesquisar;
        public System.Windows.Forms.Panel panel4;
        public System.Windows.Forms.Button EditFunc;
        public System.Windows.Forms.Button butDelFunc;
        public System.Windows.Forms.Button butNewFunc;
        public System.Windows.Forms.DataGridView dataGridViewFunc;
        private System.Windows.Forms.BindingSource funcionariosBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cargoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Salario;
        private System.Windows.Forms.DataGridViewTextBoxColumn horarioChegarDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn horarioSairDataGridViewTextBoxColumn;
    }
}
