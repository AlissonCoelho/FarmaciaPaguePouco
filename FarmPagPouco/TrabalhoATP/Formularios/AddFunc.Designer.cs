namespace TrabalhoATP.Formularios
{
	partial class formAddFunc
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
            this.botNewClient = new System.Windows.Forms.Button();
            this.botSalvarClient = new System.Windows.Forms.Button();
            this.labelTelefone = new System.Windows.Forms.Label();
            this.labelSalario = new System.Windows.Forms.Label();
            this.texCargo = new System.Windows.Forms.TextBox();
            this.labelCargo = new System.Windows.Forms.Label();
            this.labelTelefona = new System.Windows.Forms.Label();
            this.texNome = new System.Windows.Forms.TextBox();
            this.labelNome = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.texIniEx = new System.Windows.Forms.ComboBox();
            this.texFimEx = new System.Windows.Forms.ComboBox();
            this.texTel = new System.Windows.Forms.MaskedTextBox();
            this.texSalario = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // botNewClient
            // 
            this.botNewClient.Location = new System.Drawing.Point(187, 204);
            this.botNewClient.Name = "botNewClient";
            this.botNewClient.Size = new System.Drawing.Size(108, 32);
            this.botNewClient.TabIndex = 8;
            this.botNewClient.Text = "Novo Funcionario";
            this.botNewClient.UseVisualStyleBackColor = true;
            this.botNewClient.Click += new System.EventHandler(this.botNewClient_Click);
            // 
            // botSalvarClient
            // 
            this.botSalvarClient.Location = new System.Drawing.Point(53, 204);
            this.botSalvarClient.Name = "botSalvarClient";
            this.botSalvarClient.Size = new System.Drawing.Size(127, 32);
            this.botSalvarClient.TabIndex = 7;
            this.botSalvarClient.Text = "Salvar Funcionario";
            this.botSalvarClient.UseVisualStyleBackColor = true;
            this.botSalvarClient.Click += new System.EventHandler(this.botSalvarClient_Click);
            // 
            // labelTelefone
            // 
            this.labelTelefone.AutoSize = true;
            this.labelTelefone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTelefone.Location = new System.Drawing.Point(10, 114);
            this.labelTelefone.Name = "labelTelefone";
            this.labelTelefone.Size = new System.Drawing.Size(90, 32);
            this.labelTelefone.TabIndex = 20;
            this.labelTelefone.Text = "Inicio\r\nExpediente:";
            this.labelTelefone.UseWaitCursor = true;
            // 
            // labelSalario
            // 
            this.labelSalario.AutoSize = true;
            this.labelSalario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSalario.Location = new System.Drawing.Point(10, 88);
            this.labelSalario.Name = "labelSalario";
            this.labelSalario.Size = new System.Drawing.Size(62, 16);
            this.labelSalario.TabIndex = 18;
            this.labelSalario.Text = "Salario:";
            this.labelSalario.UseWaitCursor = true;
            // 
            // texCargo
            // 
            this.texCargo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.texCargo.Location = new System.Drawing.Point(99, 62);
            this.texCargo.Name = "texCargo";
            this.texCargo.Size = new System.Drawing.Size(238, 20);
            this.texCargo.TabIndex = 3;
            // 
            // labelCargo
            // 
            this.labelCargo.AutoSize = true;
            this.labelCargo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCargo.Location = new System.Drawing.Point(10, 62);
            this.labelCargo.Name = "labelCargo";
            this.labelCargo.Size = new System.Drawing.Size(54, 16);
            this.labelCargo.TabIndex = 16;
            this.labelCargo.Text = "Cargo:";
            this.labelCargo.UseWaitCursor = true;
            // 
            // labelTelefona
            // 
            this.labelTelefona.AutoSize = true;
            this.labelTelefona.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTelefona.Location = new System.Drawing.Point(10, 36);
            this.labelTelefona.Name = "labelTelefona";
            this.labelTelefona.Size = new System.Drawing.Size(70, 16);
            this.labelTelefona.TabIndex = 14;
            this.labelTelefona.Text = "Telefone";
            // 
            // texNome
            // 
            this.texNome.Location = new System.Drawing.Point(99, 10);
            this.texNome.Name = "texNome";
            this.texNome.Size = new System.Drawing.Size(238, 20);
            this.texNome.TabIndex = 1;
            // 
            // labelNome
            // 
            this.labelNome.AutoSize = true;
            this.labelNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNome.Location = new System.Drawing.Point(10, 10);
            this.labelNome.Name = "labelNome";
            this.labelNome.Size = new System.Drawing.Size(53, 16);
            this.labelNome.TabIndex = 12;
            this.labelNome.Text = "Nome:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 153);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 32);
            this.label1.TabIndex = 24;
            this.label1.Text = "Fim\r\nExpediente:";
            this.label1.UseWaitCursor = true;
            // 
            // texIniEx
            // 
            this.texIniEx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.texIniEx.FormattingEnabled = true;
            this.texIniEx.Items.AddRange(new object[] {
            "00:00",
            "01:00",
            "02:00",
            "03:00",
            "04:00",
            "05:00",
            "06:00",
            "07:00",
            "08:00",
            "09:00",
            "10:00",
            "11:00",
            "12:00",
            "13:00",
            "14:00",
            "15:00",
            "16:00",
            "17:00",
            "18:00",
            "19:00",
            "20:00",
            "21:00",
            "22:00",
            "23:00"});
            this.texIniEx.Location = new System.Drawing.Point(100, 126);
            this.texIniEx.Name = "texIniEx";
            this.texIniEx.Size = new System.Drawing.Size(152, 21);
            this.texIniEx.TabIndex = 5;
            // 
            // texFimEx
            // 
            this.texFimEx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.texFimEx.FormattingEnabled = true;
            this.texFimEx.Items.AddRange(new object[] {
            "00:00",
            "01:00",
            "02:00",
            "03:00",
            "04:00",
            "05:00",
            "06:00",
            "07:00",
            "08:00",
            "09:00",
            "10:00",
            "11:00",
            "12:00",
            "13:00",
            "14:00",
            "15:00",
            "16:00",
            "17:00",
            "18:00",
            "19:00",
            "20:00",
            "21:00",
            "22:00",
            "23:00"});
            this.texFimEx.Location = new System.Drawing.Point(100, 165);
            this.texFimEx.Name = "texFimEx";
            this.texFimEx.Size = new System.Drawing.Size(152, 21);
            this.texFimEx.TabIndex = 6;
            // 
            // texTel
            // 
            this.texTel.Location = new System.Drawing.Point(99, 36);
            this.texTel.Mask = "(99) 0000-0000";
            this.texTel.Name = "texTel";
            this.texTel.Size = new System.Drawing.Size(93, 20);
            this.texTel.TabIndex = 2;
            // 
            // texSalario
            // 
            this.texSalario.Location = new System.Drawing.Point(99, 88);
            this.texSalario.Mask = "$ 0000.00";
            this.texSalario.Name = "texSalario";
            this.texSalario.Size = new System.Drawing.Size(93, 20);
            this.texSalario.TabIndex = 4;
            // 
            // formAddFunc
            // 
            this.AcceptButton = this.botSalvarClient;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 253);
            this.Controls.Add(this.texSalario);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.botNewClient);
            this.Controls.Add(this.botSalvarClient);
            this.Controls.Add(this.labelTelefone);
            this.Controls.Add(this.labelSalario);
            this.Controls.Add(this.texCargo);
            this.Controls.Add(this.labelCargo);
            this.Controls.Add(this.labelTelefona);
            this.Controls.Add(this.texNome);
            this.Controls.Add(this.labelNome);
            this.Controls.Add(this.texIniEx);
            this.Controls.Add(this.texFimEx);
            this.Controls.Add(this.texTel);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "formAddFunc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Novo Funcionario";
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button botNewClient;
		private System.Windows.Forms.Button botSalvarClient;
		private System.Windows.Forms.Label labelTelefone;
		private System.Windows.Forms.Label labelSalario;
		private System.Windows.Forms.TextBox texCargo;
		private System.Windows.Forms.Label labelCargo;
		private System.Windows.Forms.Label labelTelefona;
		private System.Windows.Forms.TextBox texNome;
		private System.Windows.Forms.Label labelNome;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ComboBox texIniEx;
		private System.Windows.Forms.ComboBox texFimEx;
		private System.Windows.Forms.MaskedTextBox texTel;
        private System.Windows.Forms.MaskedTextBox texSalario;
    }
}