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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProdutoId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Produto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FornecedorId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fornecedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataDeRecebimento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Editar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Bt_Incluir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.ProdutoId,
            this.Produto,
            this.FornecedorId,
            this.Fornecedor,
            this.DataDeRecebimento,
            this.Editar});
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(857, 380);
            this.dataGridView1.TabIndex = 0;
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
            this.Produto.DataPropertyName = "Produto";
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
            this.Fornecedor.DataPropertyName = "Fornecedor";
            this.Fornecedor.HeaderText = "Fornecedor";
            this.Fornecedor.Name = "Fornecedor";
            // 
            // DataDeRecebimento
            // 
            this.DataDeRecebimento.DataPropertyName = "DataDeRecebimento";
            this.DataDeRecebimento.HeaderText = "DataDeRecebimento";
            this.DataDeRecebimento.Name = "DataDeRecebimento";
            // 
            // Editar
            // 
            this.Editar.HeaderText = "Editar";
            this.Editar.Name = "Editar";
            this.Editar.Text = "Editar";
            this.Editar.UseColumnTextForButtonValue = true;
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
            // Frm_CompraProdutoLista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(892, 435);
            this.Controls.Add(this.Bt_Incluir);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Frm_CompraProdutoLista";
            this.Text = "Frm_CompraProdutoLista";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProdutoId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Produto;
        private System.Windows.Forms.DataGridViewTextBoxColumn FornecedorId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fornecedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataDeRecebimento;
        private System.Windows.Forms.DataGridViewButtonColumn Editar;
        private System.Windows.Forms.Button Bt_Incluir;
    }
}