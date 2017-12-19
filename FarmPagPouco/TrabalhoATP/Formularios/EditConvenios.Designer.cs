namespace TrabalhoATP.Formularios
{
    partial class EditConvenios
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
            this.botOk = new System.Windows.Forms.Button();
            this.texDesconto = new System.Windows.Forms.MaskedTextBox();
            this.labeLogradouro = new System.Windows.Forms.Label();
            this.texNome = new System.Windows.Forms.TextBox();
            this.labelNome = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // botOk
            // 
            this.botOk.Location = new System.Drawing.Point(151, 70);
            this.botOk.Name = "botOk";
            this.botOk.Size = new System.Drawing.Size(53, 32);
            this.botOk.TabIndex = 39;
            this.botOk.Text = "Ok";
            this.botOk.UseVisualStyleBackColor = true;
            this.botOk.Click += new System.EventHandler(this.botOk_Click);
            // 
            // texDesconto
            // 
            this.texDesconto.Location = new System.Drawing.Point(102, 35);
            this.texDesconto.Mask = "00%";
            this.texDesconto.Name = "texDesconto";
            this.texDesconto.Size = new System.Drawing.Size(93, 20);
            this.texDesconto.TabIndex = 41;
            // 
            // labeLogradouro
            // 
            this.labeLogradouro.AutoSize = true;
            this.labeLogradouro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeLogradouro.Location = new System.Drawing.Point(9, 35);
            this.labeLogradouro.Name = "labeLogradouro";
            this.labeLogradouro.Size = new System.Drawing.Size(78, 16);
            this.labeLogradouro.TabIndex = 43;
            this.labeLogradouro.Text = "Desconto:";
            // 
            // texNome
            // 
            this.texNome.Location = new System.Drawing.Point(102, 9);
            this.texNome.Name = "texNome";
            this.texNome.Size = new System.Drawing.Size(238, 20);
            this.texNome.TabIndex = 40;
            // 
            // labelNome
            // 
            this.labelNome.AutoSize = true;
            this.labelNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNome.Location = new System.Drawing.Point(9, 9);
            this.labelNome.Name = "labelNome";
            this.labelNome.Size = new System.Drawing.Size(53, 16);
            this.labelNome.TabIndex = 42;
            this.labelNome.Text = "Nome:";
            // 
            // EditConvenios
            // 
            this.AcceptButton = this.botOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 114);
            this.Controls.Add(this.texDesconto);
            this.Controls.Add(this.labeLogradouro);
            this.Controls.Add(this.texNome);
            this.Controls.Add(this.labelNome);
            this.Controls.Add(this.botOk);
            this.Name = "EditConvenios";
            this.Text = "Editar Convenio";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button botOk;
        private System.Windows.Forms.MaskedTextBox texDesconto;
        private System.Windows.Forms.Label labeLogradouro;
        private System.Windows.Forms.TextBox texNome;
        private System.Windows.Forms.Label labelNome;
    }
}