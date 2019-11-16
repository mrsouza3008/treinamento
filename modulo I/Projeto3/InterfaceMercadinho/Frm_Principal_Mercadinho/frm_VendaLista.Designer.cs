namespace Mercadinho_INTERFACE
{
    partial class frm_VendaLista
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
            this.dGrid_Venda = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdDoCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NomeDoCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdDoProduto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DescricaoDoProduto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QtdeVendida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ValorDaVenda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataDaVenda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dGrid_Venda)).BeginInit();
            this.SuspendLayout();
            // 
            // dGrid_Venda
            // 
            this.dGrid_Venda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGrid_Venda.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.IdDoCliente,
            this.NomeDoCliente,
            this.IdDoProduto,
            this.DescricaoDoProduto,
            this.QtdeVendida,
            this.ValorDaVenda,
            this.DataDaVenda});
            this.dGrid_Venda.Location = new System.Drawing.Point(13, 13);
            this.dGrid_Venda.Name = "dGrid_Venda";
            this.dGrid_Venda.Size = new System.Drawing.Size(919, 325);
            this.dGrid_Venda.TabIndex = 0;
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            // 
            // IdDoCliente
            // 
            this.IdDoCliente.DataPropertyName = "IdDoCliente";
            this.IdDoCliente.HeaderText = "IdDoCliente";
            this.IdDoCliente.Name = "IdDoCliente";
            // 
            // NomeDoCliente
            // 
            this.NomeDoCliente.DataPropertyName = "NomeDoCliente";
            this.NomeDoCliente.HeaderText = "NomeDoCliente";
            this.NomeDoCliente.Name = "NomeDoCliente";
            // 
            // IdDoProduto
            // 
            this.IdDoProduto.DataPropertyName = "IdDoProduto";
            this.IdDoProduto.HeaderText = "IdDoProduto";
            this.IdDoProduto.Name = "IdDoProduto";
            // 
            // DescricaoDoProduto
            // 
            this.DescricaoDoProduto.DataPropertyName = "DescricaoDoProduto";
            this.DescricaoDoProduto.HeaderText = "DescricaoDoProduto";
            this.DescricaoDoProduto.Name = "DescricaoDoProduto";
            // 
            // QtdeVendida
            // 
            this.QtdeVendida.DataPropertyName = "QtdeVendida";
            this.QtdeVendida.HeaderText = "QtdeVendida";
            this.QtdeVendida.Name = "QtdeVendida";
            // 
            // ValorDaVenda
            // 
            this.ValorDaVenda.DataPropertyName = "ValorDaVenda";
            this.ValorDaVenda.HeaderText = "ValorDaVenda";
            this.ValorDaVenda.Name = "ValorDaVenda";
            // 
            // DataDaVenda
            // 
            this.DataDaVenda.DataPropertyName = "DataDaVenda";
            this.DataDaVenda.HeaderText = "DataDaVenda";
            this.DataDaVenda.Name = "DataDaVenda";
            // 
            // frm_VendaLista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1040, 450);
            this.Controls.Add(this.dGrid_Venda);
            this.Name = "frm_VendaLista";
            this.Text = "frm_VendaLista";
            ((System.ComponentModel.ISupportInitialize)(this.dGrid_Venda)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dGrid_Venda;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdDoCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomeDoCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdDoProduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn DescricaoDoProduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn QtdeVendida;
        private System.Windows.Forms.DataGridViewTextBoxColumn ValorDaVenda;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataDaVenda;
    }
}