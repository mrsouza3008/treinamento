namespace Frm_Principal_Mercadinho
{
    partial class Frm_ListaEstoque
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
            this.dGrid_Estoque = new System.Windows.Forms.DataGridView();
            this.NomeDoProduto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QtdeEmEstoque = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QtdeMinima = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dGrid_Estoque)).BeginInit();
            this.SuspendLayout();
            // 
            // dGrid_Estoque
            // 
            this.dGrid_Estoque.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGrid_Estoque.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NomeDoProduto,
            this.QtdeEmEstoque,
            this.QtdeMinima});
            this.dGrid_Estoque.Location = new System.Drawing.Point(0, 3);
            this.dGrid_Estoque.Name = "dGrid_Estoque";
            this.dGrid_Estoque.Size = new System.Drawing.Size(545, 446);
            this.dGrid_Estoque.TabIndex = 0;
            // 
            // NomeDoProduto
            // 
            this.NomeDoProduto.DataPropertyName = "DescricaoDoProduto";
            this.NomeDoProduto.HeaderText = "NomeDoProduto";
            this.NomeDoProduto.Name = "NomeDoProduto";
            this.NomeDoProduto.Width = 300;
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
            // Frm_ListaEstoque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(546, 450);
            this.Controls.Add(this.dGrid_Estoque);
            this.Name = "Frm_ListaEstoque";
            this.Text = "frm_ListaEstoque";
            ((System.ComponentModel.ISupportInitialize)(this.dGrid_Estoque)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dGrid_Estoque;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomeDoProduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn QtdeEmEstoque;
        private System.Windows.Forms.DataGridViewTextBoxColumn QtdeMinima;
    }
}