namespace Frm_Principal_Mercadinho
{
    partial class frm_Vendas
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
            this.label2 = new System.Windows.Forms.Label();
            this.cBox_Cliente = new System.Windows.Forms.ComboBox();
            this.cBox_Produto = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_Qtde = new System.Windows.Forms.TextBox();
            this.bt_AdicionarProduto = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txt_TotalDeVenda = new System.Windows.Forms.TextBox();
            this.txt_Desconto = new System.Windows.Forms.TextBox();
            this.txt_TotalDoProduto = new System.Windows.Forms.TextBox();
            this.bt_Efetivar = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cliente:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Produto:";
            this.label2.Click += new System.EventHandler(this.Label2_Click);
            // 
            // cBox_Cliente
            // 
            this.cBox_Cliente.FormattingEnabled = true;
            this.cBox_Cliente.Location = new System.Drawing.Point(85, 17);
            this.cBox_Cliente.Name = "cBox_Cliente";
            this.cBox_Cliente.Size = new System.Drawing.Size(556, 21);
            this.cBox_Cliente.TabIndex = 2;
            // 
            // cBox_Produto
            // 
            this.cBox_Produto.FormattingEnabled = true;
            this.cBox_Produto.Location = new System.Drawing.Point(86, 56);
            this.cBox_Produto.Name = "cBox_Produto";
            this.cBox_Produto.Size = new System.Drawing.Size(374, 21);
            this.cBox_Produto.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(479, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Qtde:";
            // 
            // txt_Qtde
            // 
            this.txt_Qtde.Location = new System.Drawing.Point(538, 59);
            this.txt_Qtde.Name = "txt_Qtde";
            this.txt_Qtde.Size = new System.Drawing.Size(100, 20);
            this.txt_Qtde.TabIndex = 5;
            // 
            // bt_AdicionarProduto
            // 
            this.bt_AdicionarProduto.Location = new System.Drawing.Point(482, 107);
            this.bt_AdicionarProduto.Name = "bt_AdicionarProduto";
            this.bt_AdicionarProduto.Size = new System.Drawing.Size(156, 23);
            this.bt_AdicionarProduto.TabIndex = 6;
            this.bt_AdicionarProduto.Text = "Adicionar Produto";
            this.bt_AdicionarProduto.UseVisualStyleBackColor = true;
            this.bt_AdicionarProduto.Click += new System.EventHandler(this.Bt_AdicionarProduto_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txt_TotalDeVenda);
            this.panel1.Controls.Add(this.txt_Desconto);
            this.panel1.Controls.Add(this.txt_TotalDoProduto);
            this.panel1.Controls.Add(this.bt_Efetivar);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(35, 145);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(606, 272);
            this.panel1.TabIndex = 7;
            // 
            // txt_TotalDeVenda
            // 
            this.txt_TotalDeVenda.Location = new System.Drawing.Point(447, 85);
            this.txt_TotalDeVenda.Name = "txt_TotalDeVenda";
            this.txt_TotalDeVenda.Size = new System.Drawing.Size(100, 20);
            this.txt_TotalDeVenda.TabIndex = 8;
            // 
            // txt_Desconto
            // 
            this.txt_Desconto.Location = new System.Drawing.Point(447, 54);
            this.txt_Desconto.Name = "txt_Desconto";
            this.txt_Desconto.Size = new System.Drawing.Size(100, 20);
            this.txt_Desconto.TabIndex = 7;
            // 
            // txt_TotalDoProduto
            // 
            this.txt_TotalDoProduto.Location = new System.Drawing.Point(447, 21);
            this.txt_TotalDoProduto.Name = "txt_TotalDoProduto";
            this.txt_TotalDoProduto.Size = new System.Drawing.Size(100, 20);
            this.txt_TotalDoProduto.TabIndex = 6;
            // 
            // bt_Efetivar
            // 
            this.bt_Efetivar.Location = new System.Drawing.Point(33, 140);
            this.bt_Efetivar.Name = "bt_Efetivar";
            this.bt_Efetivar.Size = new System.Drawing.Size(537, 23);
            this.bt_Efetivar.TabIndex = 5;
            this.bt_Efetivar.Text = "Efetivar";
            this.bt_Efetivar.UseVisualStyleBackColor = true;
            this.bt_Efetivar.Click += new System.EventHandler(this.Bt_Efetivar_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(351, 88);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Total de Venda:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(369, 57);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Desconto:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(312, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Preço Unitário do Produto";
            // 
            // frm_Vendas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(697, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.bt_AdicionarProduto);
            this.Controls.Add(this.txt_Qtde);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cBox_Produto);
            this.Controls.Add(this.cBox_Cliente);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frm_Vendas";
            this.Text = "frm_Vendas";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cBox_Cliente;
        private System.Windows.Forms.ComboBox cBox_Produto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_Qtde;
        private System.Windows.Forms.Button bt_AdicionarProduto;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txt_TotalDeVenda;
        private System.Windows.Forms.TextBox txt_Desconto;
        private System.Windows.Forms.TextBox txt_TotalDoProduto;
        private System.Windows.Forms.Button bt_Efetivar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
    }
}