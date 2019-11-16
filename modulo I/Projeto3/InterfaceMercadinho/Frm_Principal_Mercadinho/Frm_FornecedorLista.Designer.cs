namespace Mercadinho_INTERFACE
{
    partial class Frm_FornecedorLista
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
            this.dGrid_Fornecedores = new System.Windows.Forms.DataGridView();
            this.bt_Incluir = new System.Windows.Forms.Button();
            this.NomeDoFornecedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ativo = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.bt_Editar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.bt_Apagar = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dGrid_Fornecedores)).BeginInit();
            this.SuspendLayout();
            // 
            // dGrid_Fornecedores
            // 
            this.dGrid_Fornecedores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGrid_Fornecedores.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NomeDoFornecedor,
            this.Ativo,
            this.bt_Editar,
            this.bt_Apagar});
            this.dGrid_Fornecedores.Location = new System.Drawing.Point(12, 25);
            this.dGrid_Fornecedores.Name = "dGrid_Fornecedores";
            this.dGrid_Fornecedores.Size = new System.Drawing.Size(875, 338);
            this.dGrid_Fornecedores.TabIndex = 0;
            this.dGrid_Fornecedores.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGrid_Fornecedores_CellContentClick);
            // 
            // bt_Incluir
            // 
            this.bt_Incluir.Location = new System.Drawing.Point(634, 381);
            this.bt_Incluir.Name = "bt_Incluir";
            this.bt_Incluir.Size = new System.Drawing.Size(145, 38);
            this.bt_Incluir.TabIndex = 1;
            this.bt_Incluir.Text = "Incluir";
            this.bt_Incluir.UseVisualStyleBackColor = true;
            this.bt_Incluir.Click += new System.EventHandler(this.Bt_Incluir_Click);
            // 
            // NomeDoFornecedor
            // 
            this.NomeDoFornecedor.DataPropertyName = "NomeDoFornecedor";
            this.NomeDoFornecedor.HeaderText = "Nome";
            this.NomeDoFornecedor.Name = "NomeDoFornecedor";
            this.NomeDoFornecedor.Width = 500;
            // 
            // Ativo
            // 
            this.Ativo.DataPropertyName = "Ativo";
            this.Ativo.HeaderText = "Ativo";
            this.Ativo.Name = "Ativo";
            // 
            // bt_Editar
            // 
            this.bt_Editar.HeaderText = "Editar";
            this.bt_Editar.Name = "bt_Editar";
            this.bt_Editar.Text = "Editar";
            this.bt_Editar.UseColumnTextForButtonValue = true;
            // 
            // bt_Apagar
            // 
            this.bt_Apagar.HeaderText = "Apagar";
            this.bt_Apagar.Name = "bt_Apagar";
            this.bt_Apagar.Text = "Apagar";
            this.bt_Apagar.UseColumnTextForButtonValue = true;
            // 
            // Frm_FornecedorLista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(912, 450);
            this.Controls.Add(this.bt_Incluir);
            this.Controls.Add(this.dGrid_Fornecedores);
            this.Name = "Frm_FornecedorLista";
            this.Text = "Frm_FornecedorLista";
            ((System.ComponentModel.ISupportInitialize)(this.dGrid_Fornecedores)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dGrid_Fornecedores;
        private System.Windows.Forms.Button bt_Incluir;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomeDoFornecedor;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Ativo;
        private System.Windows.Forms.DataGridViewButtonColumn bt_Editar;
        private System.Windows.Forms.DataGridViewButtonColumn bt_Apagar;
    }
}