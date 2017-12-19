namespace TrabalhoATP.Formularios
{
    partial class AddConvenios
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
            this.botNew = new System.Windows.Forms.Button();
            this.botSalvar = new System.Windows.Forms.Button();
            this.texNome = new System.Windows.Forms.TextBox();
            this.labelNome = new System.Windows.Forms.Label();
            this.labeLogradouro = new System.Windows.Forms.Label();
            this.texDesconto = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // botNew
            // 
            this.botNew.Location = new System.Drawing.Point(180, 72);
            this.botNew.Name = "botNew";
            this.botNew.Size = new System.Drawing.Size(94, 32);
            this.botNew.TabIndex = 29;
            this.botNew.Text = "Novo Convenio";
            this.botNew.UseVisualStyleBackColor = true;
            this.botNew.Click += new System.EventHandler(this.botNew_Click);
            // 
            // botSalvar
            // 
            this.botSalvar.Location = new System.Drawing.Point(80, 72);
            this.botSalvar.Name = "botSalvar";
            this.botSalvar.Size = new System.Drawing.Size(94, 32);
            this.botSalvar.TabIndex = 28;
            this.botSalvar.Text = "Salvar Convenio";
            this.botSalvar.UseVisualStyleBackColor = true;
            this.botSalvar.Click += new System.EventHandler(this.botSalvar_Click);
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
            // labeLogradouro
            // 
            this.labeLogradouro.AutoSize = true;
            this.labeLogradouro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeLogradouro.Location = new System.Drawing.Point(9, 35);
            this.labeLogradouro.Name = "labeLogradouro";
            this.labeLogradouro.Size = new System.Drawing.Size(78, 16);
            this.labeLogradouro.TabIndex = 19;
            this.labeLogradouro.Text = "Desconto:";
            // 
            // texDesconto
            // 
            this.texDesconto.Location = new System.Drawing.Point(102, 35);
            this.texDesconto.Mask = "00%";
            this.texDesconto.Name = "texDesconto";
            this.texDesconto.Size = new System.Drawing.Size(93, 20);
            this.texDesconto.TabIndex = 2;
            // 
            // AddConvenios
            // 
            this.AcceptButton = this.botSalvar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 114);
            this.Controls.Add(this.texDesconto);
            this.Controls.Add(this.botNew);
            this.Controls.Add(this.botSalvar);
            this.Controls.Add(this.labeLogradouro);
            this.Controls.Add(this.texNome);
            this.Controls.Add(this.labelNome);
            this.Name = "AddConvenios";
            this.Text = "Novo Convenio";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button botNew;
        private System.Windows.Forms.Button botSalvar;
        private System.Windows.Forms.TextBox texNome;
        private System.Windows.Forms.Label labelNome;
        private System.Windows.Forms.Label labeLogradouro;
        private System.Windows.Forms.MaskedTextBox texDesconto;
    }
}