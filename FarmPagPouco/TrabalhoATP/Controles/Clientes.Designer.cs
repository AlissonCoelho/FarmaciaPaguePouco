namespace TrabalhoATP.Controles
{
	partial class Clientes
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
            this.EditClient = new System.Windows.Forms.Button();
            this.butDelClient = new System.Windows.Forms.Button();
            this.butNewClient = new System.Windows.Forms.Button();
            this.dataGridViewClient = new System.Windows.Forms.DataGridView();
            this.codigoDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.logradouro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bairro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefoneDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClient)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource)).BeginInit();
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
            this.panel3.TabIndex = 21;
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
            this.pesquisar.TabIndex = 0;
            this.pesquisar.UseVisualStyleBackColor = true;
            this.pesquisar.Click += new System.EventHandler(this.pesquisar_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.EditClient);
            this.panel4.Controls.Add(this.butDelClient);
            this.panel4.Controls.Add(this.butNewClient);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 33);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1093, 33);
            this.panel4.TabIndex = 22;
            // 
            // EditClient
            // 
            this.EditClient.Dock = System.Windows.Forms.DockStyle.Left;
            this.EditClient.Location = new System.Drawing.Point(222, 0);
            this.EditClient.Name = "EditClient";
            this.EditClient.Size = new System.Drawing.Size(111, 33);
            this.EditClient.TabIndex = 2;
            this.EditClient.Text = "Editar Cliente";
            this.EditClient.UseVisualStyleBackColor = true;
            this.EditClient.Click += new System.EventHandler(this.EditClient_Click);
            // 
            // butDelClient
            // 
            this.butDelClient.Dock = System.Windows.Forms.DockStyle.Left;
            this.butDelClient.Location = new System.Drawing.Point(111, 0);
            this.butDelClient.Name = "butDelClient";
            this.butDelClient.Size = new System.Drawing.Size(111, 33);
            this.butDelClient.TabIndex = 1;
            this.butDelClient.Text = "Deletar Cliente";
            this.butDelClient.UseVisualStyleBackColor = true;
            this.butDelClient.Click += new System.EventHandler(this.butDelClient_Click);
            // 
            // butNewClient
            // 
            this.butNewClient.Dock = System.Windows.Forms.DockStyle.Left;
            this.butNewClient.Location = new System.Drawing.Point(0, 0);
            this.butNewClient.Name = "butNewClient";
            this.butNewClient.Size = new System.Drawing.Size(111, 33);
            this.butNewClient.TabIndex = 0;
            this.butNewClient.Text = "Novo Cliente";
            this.butNewClient.UseVisualStyleBackColor = true;
            this.butNewClient.Click += new System.EventHandler(this.butNewClient_Click);
            // 
            // dataGridViewClient
            // 
            this.dataGridViewClient.AllowUserToAddRows = false;
            this.dataGridViewClient.AllowUserToDeleteRows = false;
            this.dataGridViewClient.AutoGenerateColumns = false;
            this.dataGridViewClient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewClient.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigoDataGridViewTextBoxColumn1,
            this.nomeDataGridViewTextBoxColumn1,
            this.logradouro,
            this.numero,
            this.cidade,
            this.bairro,
            this.estado,
            this.telefoneDataGridViewTextBoxColumn1});
            this.dataGridViewClient.DataSource = this.clientesBindingSource;
            this.dataGridViewClient.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewClient.Location = new System.Drawing.Point(0, 66);
            this.dataGridViewClient.Name = "dataGridViewClient";
            this.dataGridViewClient.ReadOnly = true;
            this.dataGridViewClient.Size = new System.Drawing.Size(1093, 392);
            this.dataGridViewClient.TabIndex = 23;
            this.dataGridViewClient.Tag = "";
            // 
            // codigoDataGridViewTextBoxColumn1
            // 
            this.codigoDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.codigoDataGridViewTextBoxColumn1.DataPropertyName = "codigo";
            this.codigoDataGridViewTextBoxColumn1.HeaderText = "Codigo";
            this.codigoDataGridViewTextBoxColumn1.MinimumWidth = 100;
            this.codigoDataGridViewTextBoxColumn1.Name = "codigoDataGridViewTextBoxColumn1";
            this.codigoDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // nomeDataGridViewTextBoxColumn1
            // 
            this.nomeDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.nomeDataGridViewTextBoxColumn1.DataPropertyName = "nome";
            this.nomeDataGridViewTextBoxColumn1.HeaderText = "Nome";
            this.nomeDataGridViewTextBoxColumn1.MinimumWidth = 100;
            this.nomeDataGridViewTextBoxColumn1.Name = "nomeDataGridViewTextBoxColumn1";
            this.nomeDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // logradouro
            // 
            this.logradouro.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.logradouro.DataPropertyName = "logradouro";
            this.logradouro.HeaderText = "Logradouro";
            this.logradouro.MinimumWidth = 100;
            this.logradouro.Name = "logradouro";
            this.logradouro.ReadOnly = true;
            // 
            // numero
            // 
            this.numero.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.numero.DataPropertyName = "numero";
            this.numero.HeaderText = "Número";
            this.numero.MinimumWidth = 100;
            this.numero.Name = "numero";
            this.numero.ReadOnly = true;
            // 
            // cidade
            // 
            this.cidade.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.cidade.DataPropertyName = "cidade";
            this.cidade.HeaderText = "Cidade";
            this.cidade.MinimumWidth = 100;
            this.cidade.Name = "cidade";
            this.cidade.ReadOnly = true;
            // 
            // bairro
            // 
            this.bairro.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.bairro.DataPropertyName = "bairro";
            this.bairro.HeaderText = "Bairro";
            this.bairro.MinimumWidth = 100;
            this.bairro.Name = "bairro";
            this.bairro.ReadOnly = true;
            // 
            // estado
            // 
            this.estado.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.estado.DataPropertyName = "estado";
            this.estado.HeaderText = "Estado";
            this.estado.MinimumWidth = 100;
            this.estado.Name = "estado";
            this.estado.ReadOnly = true;
            // 
            // telefoneDataGridViewTextBoxColumn1
            // 
            this.telefoneDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.telefoneDataGridViewTextBoxColumn1.DataPropertyName = "telefone";
            this.telefoneDataGridViewTextBoxColumn1.HeaderText = "Telefone";
            this.telefoneDataGridViewTextBoxColumn1.MinimumWidth = 100;
            this.telefoneDataGridViewTextBoxColumn1.Name = "telefoneDataGridViewTextBoxColumn1";
            this.telefoneDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // clientesBindingSource
            // 
            this.clientesBindingSource.DataSource = typeof(TrabalhoATP.Classes.Clientes);
            // 
            // Clientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridViewClient);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Name = "Clientes";
            this.Size = new System.Drawing.Size(1093, 458);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClient)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource)).EndInit();
            this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.BindingSource clientesBindingSource;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox texPesquisar;
        private System.Windows.Forms.Button pesquisar;
        public System.Windows.Forms.Panel panel4;
        public System.Windows.Forms.Button EditClient;
        public System.Windows.Forms.Button butDelClient;
        public System.Windows.Forms.Button butNewClient;
        public System.Windows.Forms.DataGridView dataGridViewClient;
		private System.Windows.Forms.DataGridViewTextBoxColumn codigoDataGridViewTextBoxColumn1;
		private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn1;
		private System.Windows.Forms.DataGridViewTextBoxColumn logradouro;
		private System.Windows.Forms.DataGridViewTextBoxColumn numero;
		private System.Windows.Forms.DataGridViewTextBoxColumn cidade;
		private System.Windows.Forms.DataGridViewTextBoxColumn bairro;
		private System.Windows.Forms.DataGridViewTextBoxColumn estado;
		private System.Windows.Forms.DataGridViewTextBoxColumn telefoneDataGridViewTextBoxColumn1;
	}
}
