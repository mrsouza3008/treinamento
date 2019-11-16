namespace Mercadinho_INTERFACE
{
    partial class frm_ProdutosManutencao
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
            this.label1 = new System.Windows.Forms.Label();
            this.txt_DescricaoDoProduto = new System.Windows.Forms.TextBox();
            this.txt_ValorDeCompra = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_PercentualDeLucro = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Bt_Salvar = new System.Windows.Forms.Button();
            this.ckBox_Ativo = new System.Windows.Forms.CheckBox();
            this.txt_ValorDeVenda = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Descricao";
            // 
            // txt_DescricaoDoProduto
            // 
            this.txt_DescricaoDoProduto.Location = new System.Drawing.Point(90, 10);
            this.txt_DescricaoDoProduto.Name = "txt_DescricaoDoProduto";
            this.txt_DescricaoDoProduto.Size = new System.Drawing.Size(409, 20);
            this.txt_DescricaoDoProduto.TabIndex = 1;
            // 
            // txt_ValorDeCompra
            // 
            this.txt_ValorDeCompra.Location = new System.Drawing.Point(120, 47);
            this.txt_ValorDeCompra.Name = "txt_ValorDeCompra";
            this.txt_ValorDeCompra.Size = new System.Drawing.Size(90, 20);
            this.txt_ValorDeCompra.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Valor de Compra";
            // 
            // txt_PercentualDeLucro
            // 
            this.txt_PercentualDeLucro.Location = new System.Drawing.Point(120, 85);
            this.txt_PercentualDeLucro.Name = "txt_PercentualDeLucro";
            this.txt_PercentualDeLucro.Size = new System.Drawing.Size(90, 20);
            this.txt_PercentualDeLucro.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "% de Lucro";
            // 
            // Bt_Salvar
            // 
            this.Bt_Salvar.Location = new System.Drawing.Point(349, 142);
            this.Bt_Salvar.Name = "Bt_Salvar";
            this.Bt_Salvar.Size = new System.Drawing.Size(75, 23);
            this.Bt_Salvar.TabIndex = 6;
            this.Bt_Salvar.Text = "Salvar";
            this.Bt_Salvar.UseVisualStyleBackColor = true;
            this.Bt_Salvar.Click += new System.EventHandler(this.Bt_Salvar_Click);
            // 
            // ckBox_Ativo
            // 
            this.ckBox_Ativo.AutoSize = true;
            this.ckBox_Ativo.Location = new System.Drawing.Point(578, 13);
            this.ckBox_Ativo.Name = "ckBox_Ativo";
            this.ckBox_Ativo.Size = new System.Drawing.Size(58, 17);
            this.ckBox_Ativo.TabIndex = 7;
            this.ckBox_Ativo.Text = "ATIVO";
            this.ckBox_Ativo.UseVisualStyleBackColor = true;
            // 
            // txt_ValorDeVenda
            // 
            this.txt_ValorDeVenda.Location = new System.Drawing.Point(363, 85);
            this.txt_ValorDeVenda.Name = "txt_ValorDeVenda";
            this.txt_ValorDeVenda.Size = new System.Drawing.Size(90, 20);
            this.txt_ValorDeVenda.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(272, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Valor de Venda";
            // 
            // frm_ProdutosManutencao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txt_ValorDeVenda);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ckBox_Ativo);
            this.Controls.Add(this.Bt_Salvar);
            this.Controls.Add(this.txt_PercentualDeLucro);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_ValorDeCompra);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_DescricaoDoProduto);
            this.Controls.Add(this.label1);
            this.Name = "frm_ProdutosManutencao";
            this.Text = "frm_ProdutosManutencao";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_DescricaoDoProduto;
        private System.Windows.Forms.TextBox txt_ValorDeCompra;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_PercentualDeLucro;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Bt_Salvar;
        private System.Windows.Forms.CheckBox ckBox_Ativo;
        private System.Windows.Forms.TextBox txt_ValorDeVenda;
        private System.Windows.Forms.Label label4;
    }
}