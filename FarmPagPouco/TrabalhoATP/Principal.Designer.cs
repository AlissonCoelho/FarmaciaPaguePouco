namespace TrabalhoATP
{
	partial class principal
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

		#region Código gerado pelo Windows Form Designer

		/// <summary>
		/// Método necessário para suporte ao Designer - não modifique 
		/// o conteúdo deste método com o editor de código.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(principal));
			this.panel1 = new System.Windows.Forms.Panel();
			this.label1 = new System.Windows.Forms.Label();
			this.panel2 = new System.Windows.Forms.Panel();
			this.botVendas = new System.Windows.Forms.Button();
			this.botConvenios = new System.Windows.Forms.Button();
			this.botProdutos = new System.Windows.Forms.Button();
			this.botFuncionarios = new System.Windows.Forms.Button();
			this.botClientes = new System.Windows.Forms.Button();
			this.panelControles = new System.Windows.Forms.Panel();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.panel1.SuspendLayout();
			this.panel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel1.Controls.Add(this.label1);
			this.panel1.Controls.Add(this.pictureBox2);
			this.panel1.Controls.Add(this.pictureBox1);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(1234, 83);
			this.panel1.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.SystemColors.Desktop;
			this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(140, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(856, 81);
			this.label1.TabIndex = 4;
			this.label1.Text = "Sitema de Gestão Farmacia Pague Pouco";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.botVendas);
			this.panel2.Controls.Add(this.botConvenios);
			this.panel2.Controls.Add(this.botProdutos);
			this.panel2.Controls.Add(this.botFuncionarios);
			this.panel2.Controls.Add(this.botClientes);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
			this.panel2.Location = new System.Drawing.Point(0, 83);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(141, 372);
			this.panel2.TabIndex = 2;
			// 
			// botVendas
			// 
			this.botVendas.BackColor = System.Drawing.SystemColors.Control;
			this.botVendas.Dock = System.Windows.Forms.DockStyle.Top;
			this.botVendas.Location = new System.Drawing.Point(0, 296);
			this.botVendas.Name = "botVendas";
			this.botVendas.Size = new System.Drawing.Size(141, 74);
			this.botVendas.TabIndex = 7;
			this.botVendas.Text = "VENDAS";
			this.botVendas.UseVisualStyleBackColor = false;
			this.botVendas.Click += new System.EventHandler(this.botVendas_Click);
			// 
			// botConvenios
			// 
			this.botConvenios.BackColor = System.Drawing.SystemColors.Control;
			this.botConvenios.Dock = System.Windows.Forms.DockStyle.Top;
			this.botConvenios.Location = new System.Drawing.Point(0, 222);
			this.botConvenios.Name = "botConvenios";
			this.botConvenios.Size = new System.Drawing.Size(141, 74);
			this.botConvenios.TabIndex = 6;
			this.botConvenios.Text = "CONVENIOS";
			this.botConvenios.UseVisualStyleBackColor = false;
			this.botConvenios.Click += new System.EventHandler(this.botConvenios_Click);
			// 
			// botProdutos
			// 
			this.botProdutos.BackColor = System.Drawing.SystemColors.Control;
			this.botProdutos.Dock = System.Windows.Forms.DockStyle.Top;
			this.botProdutos.Location = new System.Drawing.Point(0, 148);
			this.botProdutos.Name = "botProdutos";
			this.botProdutos.Size = new System.Drawing.Size(141, 74);
			this.botProdutos.TabIndex = 5;
			this.botProdutos.Text = "PRODUTOS";
			this.botProdutos.UseVisualStyleBackColor = false;
			this.botProdutos.Click += new System.EventHandler(this.botVrodutos_Click);
			// 
			// botFuncionarios
			// 
			this.botFuncionarios.BackColor = System.Drawing.SystemColors.Control;
			this.botFuncionarios.Dock = System.Windows.Forms.DockStyle.Top;
			this.botFuncionarios.Location = new System.Drawing.Point(0, 74);
			this.botFuncionarios.Name = "botFuncionarios";
			this.botFuncionarios.Size = new System.Drawing.Size(141, 74);
			this.botFuncionarios.TabIndex = 4;
			this.botFuncionarios.Text = "FUNCIONARIOS";
			this.botFuncionarios.UseVisualStyleBackColor = false;
			this.botFuncionarios.Click += new System.EventHandler(this.botFuncionarios_Click);
			// 
			// botClientes
			// 
			this.botClientes.BackColor = System.Drawing.SystemColors.Control;
			this.botClientes.Dock = System.Windows.Forms.DockStyle.Top;
			this.botClientes.ForeColor = System.Drawing.SystemColors.ControlText;
			this.botClientes.Location = new System.Drawing.Point(0, 0);
			this.botClientes.Name = "botClientes";
			this.botClientes.Size = new System.Drawing.Size(141, 74);
			this.botClientes.TabIndex = 3;
			this.botClientes.Text = "CLIENTES";
			this.botClientes.UseVisualStyleBackColor = false;
			this.botClientes.Click += new System.EventHandler(this.botClientes_Click);
			// 
			// panelControles
			// 
			this.panelControles.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panelControles.Location = new System.Drawing.Point(141, 83);
			this.panelControles.Name = "panelControles";
			this.panelControles.Size = new System.Drawing.Size(1093, 372);
			this.panelControles.TabIndex = 12;
			// 
			// pictureBox2
			// 
			this.pictureBox2.BackgroundImage = global::TrabalhoATP.Properties.Resources.SI_icone;
			this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Right;
			this.pictureBox2.Location = new System.Drawing.Point(996, 0);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(236, 81);
			this.pictureBox2.TabIndex = 3;
			this.pictureBox2.TabStop = false;
			// 
			// pictureBox1
			// 
			this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
			this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
			this.pictureBox1.Location = new System.Drawing.Point(0, 0);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(140, 81);
			this.pictureBox1.TabIndex = 1;
			this.pictureBox1.TabStop = false;
			// 
			// principal
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1234, 455);
			this.Controls.Add(this.panelControles);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel1);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "principal";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Farmácia Pague Pouco";
			this.panel1.ResumeLayout(false);
			this.panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Button botVendas;
		private System.Windows.Forms.Button botConvenios;
		private System.Windows.Forms.Button botProdutos;
		private System.Windows.Forms.Button botFuncionarios;
		private System.Windows.Forms.Button botClientes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panelControles;
    }
}

