namespace Mercadinho_INTERFACE
{
    partial class Frm_CompraProdutoManutencao
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
            this.cBox_Produto = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cBox_Fornecedor = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_Qtde = new System.Windows.Forms.TextBox();
            this.bt_Salvar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cBox_Produto
            // 
            this.cBox_Produto.FormattingEnabled = true;
            this.cBox_Produto.Location = new System.Drawing.Point(84, 22);
            this.cBox_Produto.Name = "cBox_Produto";
            this.cBox_Produto.Size = new System.Drawing.Size(536, 21);
            this.cBox_Produto.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Produto";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Fornecedor";
            // 
            // cBox_Fornecedor
            // 
            this.cBox_Fornecedor.FormattingEnabled = true;
            this.cBox_Fornecedor.Location = new System.Drawing.Point(84, 61);
            this.cBox_Fornecedor.Name = "cBox_Fornecedor";
            this.cBox_Fornecedor.Size = new System.Drawing.Size(536, 21);
            this.cBox_Fornecedor.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Qtde";
            // 
            // txt_Qtde
            // 
            this.txt_Qtde.Location = new System.Drawing.Point(84, 103);
            this.txt_Qtde.Name = "txt_Qtde";
            this.txt_Qtde.Size = new System.Drawing.Size(100, 20);
            this.txt_Qtde.TabIndex = 5;
            // 
            // bt_Salvar
            // 
            this.bt_Salvar.Location = new System.Drawing.Point(496, 154);
            this.bt_Salvar.Name = "bt_Salvar";
            this.bt_Salvar.Size = new System.Drawing.Size(75, 23);
            this.bt_Salvar.TabIndex = 6;
            this.bt_Salvar.Text = "Salvar";
            this.bt_Salvar.UseVisualStyleBackColor = true;
            this.bt_Salvar.Click += new System.EventHandler(this.Bt_Salvar_Click);
            // 
            // Frm_CompraProdutoManutencao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 245);
            this.Controls.Add(this.bt_Salvar);
            this.Controls.Add(this.txt_Qtde);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cBox_Fornecedor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cBox_Produto);
            this.Name = "Frm_CompraProdutoManutencao";
            this.Text = "Frm_CompraProdutoManutencao";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cBox_Produto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cBox_Fornecedor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_Qtde;
        private System.Windows.Forms.Button bt_Salvar;
    }
}