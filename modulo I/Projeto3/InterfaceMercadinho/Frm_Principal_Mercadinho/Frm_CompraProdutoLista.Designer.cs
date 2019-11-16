namespace Mercadinho_INTERFACE
{
    partial class Frm_CompraProdutoLista
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
            this.dGrid_Compras = new System.Windows.Forms.DataGridView();
            this.Bt_Incluir = new System.Windows.Forms.Button();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProdutoId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Produto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FornecedorId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fornecedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Qtde = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataDeRecebimento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bt_Editar = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dGrid_Compras)).BeginInit();
            this.SuspendLayout();
            // 
            // dGrid_Compras
            // 
            this.dGrid_Compras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGrid_Compras.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.ProdutoId,
            this.Produto,
            this.FornecedorId,
            this.Fornecedor,
            this.Qtde,
            this.DataDeRecebimento,
            this.bt_Editar});
            this.dGrid_Compras.Location = new System.Drawing.Point(12, 12);
            this.dGrid_Compras.Name = "dGrid_Compras";
            this.dGrid_Compras.Size = new System.Drawing.Size(857, 380);
            this.dGrid_Compras.TabIndex = 0;
            this.dGrid_Compras.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGrid_Compras_CellContentClick);
            // 
            // Bt_Incluir
            // 
            this.Bt_Incluir.Location = new System.Drawing.Point(742, 398);
            this.Bt_Incluir.Name = "Bt_Incluir";
            this.Bt_Incluir.Size = new System.Drawing.Size(118, 25);
            this.Bt_Incluir.TabIndex = 1;
            this.Bt_Incluir.Text = "Nova Compra";
            this.Bt_Incluir.UseVisualStyleBackColor = true;
            this.Bt_Incluir.Click += new System.EventHandler(this.Bt_Incluir_Click);
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id da Compra";
            this.Id.Name = "Id";
            // 
            // ProdutoId
            // 
            this.ProdutoId.DataPropertyName = "ProdutoId";
            this.ProdutoId.HeaderText = "ProdutoId";
            this.ProdutoId.Name = "ProdutoId";
            // 
            // Produto
            // 
            this.Produto.DataPropertyName = "NomeDoProduto";
            this.Produto.HeaderText = "Produto";
            this.Produto.Name = "Produto";
            // 
            // FornecedorId
            // 
            this.FornecedorId.DataPropertyName = "FornecedorId";
            this.FornecedorId.HeaderText = "FornecedorId";
            this.FornecedorId.Name = "FornecedorId";
            // 
            // Fornecedor
            // 
            this.Fornecedor.DataPropertyName = "NomeDoFornecedor";
            this.Fornecedor.HeaderText = "Fornecedor";
            this.Fornecedor.Name = "Fornecedor";
            // 
            // Qtde
            // 
            this.Qtde.DataPropertyName = "QtdeDeCompra";
            this.Qtde.HeaderText = "Qtde Comprada";
            this.Qtde.Name = "Qtde";
            // 
            // DataDeRecebimento
            // 
            this.DataDeRecebimento.DataPropertyName = "DataDeRecebimento";
            this.DataDeRecebimento.HeaderText = "DataDeRecebimento";
            this.DataDeRecebimento.Name = "DataDeRecebimento";
            // 
            // bt_Editar
            // 
            this.bt_Editar.HeaderText = "Editar";
            this.bt_Editar.Name = "bt_Editar";
            this.bt_Editar.Text = "Editar";
            this.bt_Editar.UseColumnTextForButtonValue = true;
            // 
            // Frm_CompraProdutoLista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(892, 435);
            this.Controls.Add(this.Bt_Incluir);
            this.Controls.Add(this.dGrid_Compras);
            this.Name = "Frm_CompraProdutoLista";
            this.Text = "Frm_CompraProdutoLista";
            ((System.ComponentModel.ISupportInitialize)(this.dGrid_Compras)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dGrid_Compras;
        private System.Windows.Forms.Button Bt_Incluir;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProdutoId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Produto;
        private System.Windows.Forms.DataGridViewTextBoxColumn FornecedorId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fornecedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Qtde;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataDeRecebimento;
        private System.Windows.Forms.DataGridViewButtonColumn bt_Editar;
    }
}