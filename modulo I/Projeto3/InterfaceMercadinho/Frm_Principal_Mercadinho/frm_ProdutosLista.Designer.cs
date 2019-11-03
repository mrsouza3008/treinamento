namespace Frm_Principal_Mercadinho
{
    partial class Frm_ListaProdutos
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
            this.dbGrid_Produtos = new System.Windows.Forms.DataGridView();
            this.DescricaoDoProduto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ValorDeCompra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PercentualDeLucro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ativo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Bt_Incluir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dbGrid_Produtos)).BeginInit();
            this.SuspendLayout();
            // 
            // dbGrid_Produtos
            // 
            this.dbGrid_Produtos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dbGrid_Produtos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DescricaoDoProduto,
            this.ValorDeCompra,
            this.PercentualDeLucro,
            this.Ativo});
            this.dbGrid_Produtos.Location = new System.Drawing.Point(22, 13);
            this.dbGrid_Produtos.Name = "dbGrid_Produtos";
            this.dbGrid_Produtos.Size = new System.Drawing.Size(598, 150);
            this.dbGrid_Produtos.TabIndex = 0;
            // 
            // DescricaoDoProduto
            // 
            this.DescricaoDoProduto.HeaderText = "Descricao";
            this.DescricaoDoProduto.Name = "DescricaoDoProduto";
            this.DescricaoDoProduto.Width = 250;
            // 
            // ValorDeCompra
            // 
            this.ValorDeCompra.DataPropertyName = "ValorDeCompra";
            this.ValorDeCompra.HeaderText = "ValorDeCompra";
            this.ValorDeCompra.Name = "ValorDeCompra";
            // 
            // PercentualDeLucro
            // 
            this.PercentualDeLucro.DataPropertyName = "PercentualDeLucro";
            this.PercentualDeLucro.HeaderText = "PercentualDeLucro";
            this.PercentualDeLucro.Name = "PercentualDeLucro";
            // 
            // Ativo
            // 
            this.Ativo.DataPropertyName = "Ativo";
            this.Ativo.HeaderText = "Ativo";
            this.Ativo.Name = "Ativo";
            // 
            // Bt_Incluir
            // 
            this.Bt_Incluir.Location = new System.Drawing.Point(514, 176);
            this.Bt_Incluir.Name = "Bt_Incluir";
            this.Bt_Incluir.Size = new System.Drawing.Size(75, 23);
            this.Bt_Incluir.TabIndex = 1;
            this.Bt_Incluir.Text = "Incluir Produto";
            this.Bt_Incluir.UseVisualStyleBackColor = true;
            this.Bt_Incluir.Click += new System.EventHandler(this.Bt_Incluir_Click);
            // 
            // Frm_ListaProdutos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(642, 211);
            this.Controls.Add(this.Bt_Incluir);
            this.Controls.Add(this.dbGrid_Produtos);
            this.Name = "Frm_ListaProdutos";
            this.Text = "frm_ListaProdutos";
            ((System.ComponentModel.ISupportInitialize)(this.dbGrid_Produtos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dbGrid_Produtos;
        private System.Windows.Forms.DataGridViewTextBoxColumn DescricaoDoProduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn ValorDeCompra;
        private System.Windows.Forms.DataGridViewTextBoxColumn PercentualDeLucro;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ativo;
        private System.Windows.Forms.Button Bt_Incluir;
    }
}