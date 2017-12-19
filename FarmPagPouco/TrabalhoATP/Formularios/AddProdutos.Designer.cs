namespace TrabalhoATP.Formularios
{
    partial class AddProdutos
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
			this.texQuantidade = new System.Windows.Forms.TextBox();
			this.labelCidade = new System.Windows.Forms.Label();
			this.labelQuantidade = new System.Windows.Forms.Label();
			this.botNew = new System.Windows.Forms.Button();
			this.botSalvar = new System.Windows.Forms.Button();
			this.labelTipo = new System.Windows.Forms.Label();
			this.labelBairro = new System.Windows.Forms.Label();
			this.texDescricao = new System.Windows.Forms.TextBox();
			this.labeDescricao = new System.Windows.Forms.Label();
			this.texTipo = new System.Windows.Forms.ComboBox();
			this.texCusto = new System.Windows.Forms.MaskedTextBox();
			this.texVenda = new System.Windows.Forms.MaskedTextBox();
			this.SuspendLayout();
			// 
			// texQuantidade
			// 
			this.texQuantidade.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.texQuantidade.Location = new System.Drawing.Point(104, 35);
			this.texQuantidade.Name = "texQuantidade";
			this.texQuantidade.Size = new System.Drawing.Size(136, 20);
			this.texQuantidade.TabIndex = 2;
			// 
			// labelCidade
			// 
			this.labelCidade.AutoSize = true;
			this.labelCidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelCidade.Location = new System.Drawing.Point(4, 67);
			this.labelCidade.Name = "labelCidade";
			this.labelCidade.Size = new System.Drawing.Size(96, 16);
			this.labelCidade.TabIndex = 31;
			this.labelCidade.Text = "Preço Custo:";
			this.labelCidade.UseWaitCursor = true;
			// 
			// labelQuantidade
			// 
			this.labelQuantidade.AutoSize = true;
			this.labelQuantidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelQuantidade.Location = new System.Drawing.Point(4, 39);
			this.labelQuantidade.Name = "labelQuantidade";
			this.labelQuantidade.Size = new System.Drawing.Size(92, 16);
			this.labelQuantidade.TabIndex = 30;
			this.labelQuantidade.Text = "Quantidade:";
			this.labelQuantidade.UseWaitCursor = true;
			// 
			// botNew
			// 
			this.botNew.Location = new System.Drawing.Point(180, 156);
			this.botNew.Name = "botNew";
			this.botNew.Size = new System.Drawing.Size(94, 32);
			this.botNew.TabIndex = 29;
			this.botNew.Text = "Novo Prduto";
			this.botNew.UseVisualStyleBackColor = true;
			this.botNew.Click += new System.EventHandler(this.botNew_Click);
			// 
			// botSalvar
			// 
			this.botSalvar.Location = new System.Drawing.Point(80, 156);
			this.botSalvar.Name = "botSalvar";
			this.botSalvar.Size = new System.Drawing.Size(94, 32);
			this.botSalvar.TabIndex = 28;
			this.botSalvar.Text = "Salvar Produto";
			this.botSalvar.UseVisualStyleBackColor = true;
			this.botSalvar.Click += new System.EventHandler(this.botSalvar_Click);
			// 
			// labelTipo
			// 
			this.labelTipo.AutoSize = true;
			this.labelTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelTipo.Location = new System.Drawing.Point(4, 123);
			this.labelTipo.Name = "labelTipo";
			this.labelTipo.Size = new System.Drawing.Size(44, 16);
			this.labelTipo.TabIndex = 27;
			this.labelTipo.Text = "Tipo:";
			this.labelTipo.UseWaitCursor = true;
			// 
			// labelBairro
			// 
			this.labelBairro.AutoSize = true;
			this.labelBairro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelBairro.Location = new System.Drawing.Point(4, 95);
			this.labelBairro.Name = "labelBairro";
			this.labelBairro.Size = new System.Drawing.Size(102, 16);
			this.labelBairro.TabIndex = 22;
			this.labelBairro.Text = "Preço Venda:";
			this.labelBairro.UseWaitCursor = true;
			// 
			// texDescricao
			// 
			this.texDescricao.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.texDescricao.Location = new System.Drawing.Point(104, 7);
			this.texDescricao.Name = "texDescricao";
			this.texDescricao.Size = new System.Drawing.Size(238, 20);
			this.texDescricao.TabIndex = 1;
			// 
			// labeDescricao
			// 
			this.labeDescricao.AutoSize = true;
			this.labeDescricao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labeDescricao.Location = new System.Drawing.Point(4, 11);
			this.labeDescricao.Name = "labeDescricao";
			this.labeDescricao.Size = new System.Drawing.Size(79, 16);
			this.labeDescricao.TabIndex = 19;
			this.labeDescricao.Text = "Descricao";
			// 
			// texTipo
			// 
			this.texTipo.BackColor = System.Drawing.Color.White;
			this.texTipo.Cursor = System.Windows.Forms.Cursors.Default;
			this.texTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.texTipo.FormattingEnabled = true;
			this.texTipo.Items.AddRange(new object[] {
            "Medicamentos",
            "Perfumaria",
            "Outros"});
			this.texTipo.Location = new System.Drawing.Point(104, 118);
			this.texTipo.Name = "texTipo";
			this.texTipo.Size = new System.Drawing.Size(238, 21);
			this.texTipo.TabIndex = 6;
			this.texTipo.SelectedIndexChanged += new System.EventHandler(this.texTipo_SelectedIndexChanged);
			// 
			// texCusto
			// 
			this.texCusto.Location = new System.Drawing.Point(104, 63);
			this.texCusto.Mask = "$0000.00";
			this.texCusto.Name = "texCusto";
			this.texCusto.Size = new System.Drawing.Size(93, 20);
			this.texCusto.TabIndex = 3;
			// 
			// texVenda
			// 
			this.texVenda.Location = new System.Drawing.Point(104, 91);
			this.texVenda.Mask = "$0000.00";
			this.texVenda.Name = "texVenda";
			this.texVenda.Size = new System.Drawing.Size(93, 20);
			this.texVenda.TabIndex = 4;
			// 
			// AddProdutos
			// 
			this.AcceptButton = this.botSalvar;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(354, 197);
			this.Controls.Add(this.texVenda);
			this.Controls.Add(this.texCusto);
			this.Controls.Add(this.texTipo);
			this.Controls.Add(this.texQuantidade);
			this.Controls.Add(this.labelCidade);
			this.Controls.Add(this.labelQuantidade);
			this.Controls.Add(this.botNew);
			this.Controls.Add(this.botSalvar);
			this.Controls.Add(this.labelTipo);
			this.Controls.Add(this.labelBairro);
			this.Controls.Add(this.texDescricao);
			this.Controls.Add(this.labeDescricao);
			this.Name = "AddProdutos";
			this.Text = "Novo Produto";
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox texQuantidade;
        private System.Windows.Forms.Label labelCidade;
        private System.Windows.Forms.Label labelQuantidade;
        private System.Windows.Forms.Button botNew;
        private System.Windows.Forms.Button botSalvar;
        private System.Windows.Forms.Label labelTipo;
        private System.Windows.Forms.Label labelBairro;
        private System.Windows.Forms.TextBox texDescricao;
        private System.Windows.Forms.Label labeDescricao;
        private System.Windows.Forms.ComboBox texTipo;
        private System.Windows.Forms.MaskedTextBox texCusto;
        private System.Windows.Forms.MaskedTextBox texVenda;
    }
}