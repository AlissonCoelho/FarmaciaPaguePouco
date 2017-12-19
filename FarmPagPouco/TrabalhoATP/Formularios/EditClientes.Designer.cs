namespace TrabalhoATP.Formularios
{
    partial class EditClientes
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
            this.texTel = new System.Windows.Forms.MaskedTextBox();
            this.texNum = new System.Windows.Forms.TextBox();
            this.texCidade = new System.Windows.Forms.TextBox();
            this.labelCidade = new System.Windows.Forms.Label();
            this.labelNum = new System.Windows.Forms.Label();
            this.texEstado = new System.Windows.Forms.ComboBox();
            this.botOk = new System.Windows.Forms.Button();
            this.labelTelefone = new System.Windows.Forms.Label();
            this.texBairro = new System.Windows.Forms.TextBox();
            this.labelEstado = new System.Windows.Forms.Label();
            this.labelBairro = new System.Windows.Forms.Label();
            this.texLogra = new System.Windows.Forms.TextBox();
            this.labeLogradouro = new System.Windows.Forms.Label();
            this.texNome = new System.Windows.Forms.TextBox();
            this.labelNome = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // texTel
            // 
            this.texTel.Location = new System.Drawing.Point(102, 166);
            this.texTel.Mask = "(99) 00000-0000";
            this.texTel.Name = "texTel";
            this.texTel.Size = new System.Drawing.Size(93, 20);
            this.texTel.TabIndex = 7;
            // 
            // texNum
            // 
            this.texNum.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.texNum.Location = new System.Drawing.Point(102, 62);
            this.texNum.Name = "texNum";
            this.texNum.Size = new System.Drawing.Size(152, 20);
            this.texNum.TabIndex = 3;
            // 
            // texCidade
            // 
            this.texCidade.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.texCidade.Location = new System.Drawing.Point(102, 88);
            this.texCidade.Name = "texCidade";
            this.texCidade.Size = new System.Drawing.Size(238, 20);
            this.texCidade.TabIndex = 4;
            // 
            // labelCidade
            // 
            this.labelCidade.AutoSize = true;
            this.labelCidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCidade.Location = new System.Drawing.Point(9, 88);
            this.labelCidade.Name = "labelCidade";
            this.labelCidade.Size = new System.Drawing.Size(62, 16);
            this.labelCidade.TabIndex = 31;
            this.labelCidade.Text = "Cidade:";
            this.labelCidade.UseWaitCursor = true;
            // 
            // labelNum
            // 
            this.labelNum.AutoSize = true;
            this.labelNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNum.Location = new System.Drawing.Point(9, 62);
            this.labelNum.Name = "labelNum";
            this.labelNum.Size = new System.Drawing.Size(66, 16);
            this.labelNum.TabIndex = 30;
            this.labelNum.Text = "Número:";
            this.labelNum.UseWaitCursor = true;
            // 
            // texEstado
            // 
            this.texEstado.BackColor = System.Drawing.Color.White;
            this.texEstado.Cursor = System.Windows.Forms.Cursors.Default;
            this.texEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.texEstado.FormattingEnabled = true;
            this.texEstado.Items.AddRange(new object[] {
            "Acre",
            "Alagoas",
            "Amapá",
            "Amazonas\t",
            "Bahia",
            "Ceará",
            "Distrito Federal",
            "Espírito Santo",
            "Goiás",
            "Maranhão\t",
            "Mato Grosso do Sul",
            "Mato Grosso",
            "Minas Gerais",
            "Pará",
            "Paraíba",
            "Paraná",
            "Pernambuco",
            "Piauí",
            "Rio de Janeiro",
            "Rio Grande do Norte",
            "Rio Grande do Sul",
            "Rondônia",
            "Roraima",
            "Santa Catarina",
            "São Paulo",
            "Sergipe",
            "Tocantins"});
            this.texEstado.Location = new System.Drawing.Point(102, 140);
            this.texEstado.Name = "texEstado";
            this.texEstado.Size = new System.Drawing.Size(238, 21);
            this.texEstado.TabIndex = 6;
            // 
            // botOk
            // 
            this.botOk.Location = new System.Drawing.Point(151, 211);
            this.botOk.Name = "botOk";
            this.botOk.Size = new System.Drawing.Size(53, 32);
            this.botOk.TabIndex = 8;
            this.botOk.Text = "Ok";
            this.botOk.UseVisualStyleBackColor = true;
            this.botOk.Click += new System.EventHandler(this.botOk_Click);
            // 
            // labelTelefone
            // 
            this.labelTelefone.AutoSize = true;
            this.labelTelefone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTelefone.Location = new System.Drawing.Point(9, 166);
            this.labelTelefone.Name = "labelTelefone";
            this.labelTelefone.Size = new System.Drawing.Size(70, 16);
            this.labelTelefone.TabIndex = 27;
            this.labelTelefone.Text = "Telefone";
            this.labelTelefone.UseWaitCursor = true;
            // 
            // texBairro
            // 
            this.texBairro.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.texBairro.Location = new System.Drawing.Point(102, 114);
            this.texBairro.Name = "texBairro";
            this.texBairro.Size = new System.Drawing.Size(238, 20);
            this.texBairro.TabIndex = 5;
            // 
            // labelEstado
            // 
            this.labelEstado.AutoSize = true;
            this.labelEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEstado.Location = new System.Drawing.Point(9, 140);
            this.labelEstado.Name = "labelEstado";
            this.labelEstado.Size = new System.Drawing.Size(61, 16);
            this.labelEstado.TabIndex = 25;
            this.labelEstado.Text = "Estado:";
            this.labelEstado.UseWaitCursor = true;
            // 
            // labelBairro
            // 
            this.labelBairro.AutoSize = true;
            this.labelBairro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBairro.Location = new System.Drawing.Point(9, 114);
            this.labelBairro.Name = "labelBairro";
            this.labelBairro.Size = new System.Drawing.Size(54, 16);
            this.labelBairro.TabIndex = 22;
            this.labelBairro.Text = "Bairro:";
            this.labelBairro.UseWaitCursor = true;
            // 
            // texLogra
            // 
            this.texLogra.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.texLogra.Location = new System.Drawing.Point(102, 35);
            this.texLogra.Name = "texLogra";
            this.texLogra.Size = new System.Drawing.Size(238, 20);
            this.texLogra.TabIndex = 2;
            // 
            // labeLogradouro
            // 
            this.labeLogradouro.AutoSize = true;
            this.labeLogradouro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeLogradouro.Location = new System.Drawing.Point(9, 35);
            this.labeLogradouro.Name = "labeLogradouro";
            this.labeLogradouro.Size = new System.Drawing.Size(92, 16);
            this.labeLogradouro.TabIndex = 19;
            this.labeLogradouro.Text = "Logradouro:";
            // 
            // texNome
            // 
            this.texNome.Location = new System.Drawing.Point(102, 9);
            this.texNome.Name = "texNome";
            this.texNome.Size = new System.Drawing.Size(238, 20);
            this.texNome.TabIndex = 1;
            // 
            // labelNome
            // 
            this.labelNome.AutoSize = true;
            this.labelNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNome.Location = new System.Drawing.Point(9, 9);
            this.labelNome.Name = "labelNome";
            this.labelNome.Size = new System.Drawing.Size(53, 16);
            this.labelNome.TabIndex = 16;
            this.labelNome.Text = "Nome:";
            // 
            // EditClientes
            // 
            this.AcceptButton = this.botOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 255);
            this.Controls.Add(this.texTel);
            this.Controls.Add(this.texNum);
            this.Controls.Add(this.texCidade);
            this.Controls.Add(this.labelCidade);
            this.Controls.Add(this.labelNum);
            this.Controls.Add(this.texEstado);
            this.Controls.Add(this.botOk);
            this.Controls.Add(this.labelTelefone);
            this.Controls.Add(this.texBairro);
            this.Controls.Add(this.labelEstado);
            this.Controls.Add(this.labelBairro);
            this.Controls.Add(this.texLogra);
            this.Controls.Add(this.labeLogradouro);
            this.Controls.Add(this.texNome);
            this.Controls.Add(this.labelNome);
            this.Name = "EditClientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Editar Clientes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.MaskedTextBox texTel;
        public System.Windows.Forms.TextBox texNum;
        public System.Windows.Forms.TextBox texCidade;
        private System.Windows.Forms.Label labelCidade;
        private System.Windows.Forms.Label labelNum;
        public System.Windows.Forms.ComboBox texEstado;
        private System.Windows.Forms.Button botOk;
        private System.Windows.Forms.Label labelTelefone;
        public System.Windows.Forms.TextBox texBairro;
        private System.Windows.Forms.Label labelEstado;
        private System.Windows.Forms.Label labelBairro;
        public System.Windows.Forms.TextBox texLogra;
        private System.Windows.Forms.Label labeLogradouro;
        public System.Windows.Forms.TextBox texNome;
        private System.Windows.Forms.Label labelNome;
    }
}