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
            this.PrecoDeVenda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ativo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QtdeEmEstoque = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QtdeMinima = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Bt_Editar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Bt_Apagar = new System.Windows.Forms.DataGridViewButtonColumn();
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
            this.PrecoDeVenda,
            this.Ativo,
            this.QtdeEmEstoque,
            this.QtdeMinima,
            this.Bt_Editar,
            this.Bt_Apagar});
            this.dbGrid_Produtos.Location = new System.Drawing.Point(-2, 2);
            this.dbGrid_Produtos.Name = "dbGrid_Produtos";
            this.dbGrid_Produtos.Size = new System.Drawing.Size(1095, 280);
            this.dbGrid_Produtos.TabIndex = 0;
            this.dbGrid_Produtos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DbGrid_Produtos_CellContentClick);
            // 
            // DescricaoDoProduto
            // 
            this.DescricaoDoProduto.DataPropertyName = "DescricaoDoProduto";
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
            // PrecoDeVenda
            // 
            this.PrecoDeVenda.DataPropertyName = "PrecoDeVenda";
            this.PrecoDeVenda.HeaderText = "Preço de Venda";
            this.PrecoDeVenda.Name = "PrecoDeVenda";
            // 
            // Ativo
            // 
            this.Ativo.DataPropertyName = "Ativo";
            this.Ativo.HeaderText = "Ativo";
            this.Ativo.Name = "Ativo";
            // 
            // QtdeEmEstoque
            // 
            this.QtdeEmEstoque.DataPropertyName = "QtdeEmEstoque";
            this.QtdeEmEstoque.HeaderText = "QtdeEmEstoque";
            this.QtdeEmEstoque.Name = "QtdeEmEstoque";
            // 
            // QtdeMinima
            // 
            this.QtdeMinima.DataPropertyName = "QtdeMinima";
            this.QtdeMinima.HeaderText = "QtdeMinima";
            this.QtdeMinima.Name = "QtdeMinima";
            // 
            // Bt_Editar
            // 
            this.Bt_Editar.HeaderText = "Editar";
            this.Bt_Editar.Name = "Bt_Editar";
            this.Bt_Editar.Text = "Editar";
            this.Bt_Editar.UseColumnTextForButtonValue = true;
            // 
            // Bt_Apagar
            // 
            this.Bt_Apagar.HeaderText = "Apagar";
            this.Bt_Apagar.Name = "Bt_Apagar";
            this.Bt_Apagar.Text = "Apagar";
            this.Bt_Apagar.UseColumnTextForButtonValue = true;
            // 
            // Bt_Incluir
            // 
            this.Bt_Incluir.Location = new System.Drawing.Point(718, 298);
            this.Bt_Incluir.Name = "Bt_Incluir";
            this.Bt_Incluir.Size = new System.Drawing.Size(197, 23);
            this.Bt_Incluir.TabIndex = 1;
            this.Bt_Incluir.Text = "Incluir Produto";
            this.Bt_Incluir.UseVisualStyleBackColor = true;
            this.Bt_Incluir.Click += new System.EventHandler(this.Bt_Incluir_Click);
            // 
            // Frm_ListaProdutos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1126, 333);
            this.Controls.Add(this.Bt_Incluir);
            this.Controls.Add(this.dbGrid_Produtos);
            this.Name = "Frm_ListaProdutos";
            this.Text = "frm_ListaProdutos";
            ((System.ComponentModel.ISupportInitialize)(this.dbGrid_Produtos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dbGrid_Produtos;
        private System.Windows.Forms.Button Bt_Incluir;
        private System.Windows.Forms.DataGridViewTextBoxColumn DescricaoDoProduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn ValorDeCompra;
        private System.Windows.Forms.DataGridViewTextBoxColumn PercentualDeLucro;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecoDeVenda;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ativo;
        private System.Windows.Forms.DataGridViewTextBoxColumn QtdeEmEstoque;
        private System.Windows.Forms.DataGridViewTextBoxColumn QtdeMinima;
        private System.Windows.Forms.DataGridViewButtonColumn Bt_Editar;
        private System.Windows.Forms.DataGridViewButtonColumn Bt_Apagar;
    }
}