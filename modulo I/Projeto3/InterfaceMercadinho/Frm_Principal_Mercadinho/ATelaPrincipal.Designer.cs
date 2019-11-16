namespace Frm_Principal_Mercadinho
{
    partial class ATelaPrincipal
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
            this.bt_Clientes = new System.Windows.Forms.Button();
            this.bt_Produtos = new System.Windows.Forms.Button();
            this.bt_Estoque = new System.Windows.Forms.Button();
            this.bt_Vendas = new System.Windows.Forms.Button();
            this.bt_Compras = new System.Windows.Forms.Button();
            this.bt_Fornecedores = new System.Windows.Forms.Button();
            this.bt_EditarCompras = new System.Windows.Forms.Button();
            this.bt_EditarVendas = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bt_Clientes
            // 
            this.bt_Clientes.Location = new System.Drawing.Point(29, 12);
            this.bt_Clientes.Name = "bt_Clientes";
            this.bt_Clientes.Size = new System.Drawing.Size(158, 62);
            this.bt_Clientes.TabIndex = 0;
            this.bt_Clientes.Text = "Cadastro de Clientes";
            this.bt_Clientes.UseVisualStyleBackColor = true;
            this.bt_Clientes.Click += new System.EventHandler(this.Bt_Clientes_Click);
            // 
            // bt_Produtos
            // 
            this.bt_Produtos.Location = new System.Drawing.Point(193, 12);
            this.bt_Produtos.Name = "bt_Produtos";
            this.bt_Produtos.Size = new System.Drawing.Size(158, 62);
            this.bt_Produtos.TabIndex = 1;
            this.bt_Produtos.Text = "Cadastro de Produtos";
            this.bt_Produtos.UseVisualStyleBackColor = true;
            this.bt_Produtos.Click += new System.EventHandler(this.Bt_Produtos_Click);
            // 
            // bt_Estoque
            // 
            this.bt_Estoque.Location = new System.Drawing.Point(29, 147);
            this.bt_Estoque.Name = "bt_Estoque";
            this.bt_Estoque.Size = new System.Drawing.Size(158, 62);
            this.bt_Estoque.TabIndex = 2;
            this.bt_Estoque.Text = "Estoque";
            this.bt_Estoque.UseVisualStyleBackColor = true;
            this.bt_Estoque.Click += new System.EventHandler(this.Bt_Estoque_Click);
            // 
            // bt_Vendas
            // 
            this.bt_Vendas.Location = new System.Drawing.Point(29, 283);
            this.bt_Vendas.Name = "bt_Vendas";
            this.bt_Vendas.Size = new System.Drawing.Size(158, 62);
            this.bt_Vendas.TabIndex = 3;
            this.bt_Vendas.Text = "Vendas";
            this.bt_Vendas.UseVisualStyleBackColor = true;
            this.bt_Vendas.Click += new System.EventHandler(this.Bt_Vendas_Click);
            // 
            // bt_Compras
            // 
            this.bt_Compras.Location = new System.Drawing.Point(29, 215);
            this.bt_Compras.Name = "bt_Compras";
            this.bt_Compras.Size = new System.Drawing.Size(158, 62);
            this.bt_Compras.TabIndex = 4;
            this.bt_Compras.Text = "Compras";
            this.bt_Compras.UseVisualStyleBackColor = true;
            this.bt_Compras.Click += new System.EventHandler(this.Bt_Compras_Click);
            // 
            // bt_Fornecedores
            // 
            this.bt_Fornecedores.Location = new System.Drawing.Point(357, 12);
            this.bt_Fornecedores.Name = "bt_Fornecedores";
            this.bt_Fornecedores.Size = new System.Drawing.Size(158, 62);
            this.bt_Fornecedores.TabIndex = 5;
            this.bt_Fornecedores.Text = "Cadastro de Fornecedores";
            this.bt_Fornecedores.UseVisualStyleBackColor = true;
            this.bt_Fornecedores.Click += new System.EventHandler(this.Bt_Fornecedores_Click);
            // 
            // bt_EditarCompras
            // 
            this.bt_EditarCompras.Location = new System.Drawing.Point(193, 215);
            this.bt_EditarCompras.Name = "bt_EditarCompras";
            this.bt_EditarCompras.Size = new System.Drawing.Size(158, 62);
            this.bt_EditarCompras.TabIndex = 6;
            this.bt_EditarCompras.Text = "Lista de  Compras";
            this.bt_EditarCompras.UseVisualStyleBackColor = true;
            this.bt_EditarCompras.Click += new System.EventHandler(this.Bt_EditarCompras_Click_1);
            // 
            // bt_EditarVendas
            // 
            this.bt_EditarVendas.Location = new System.Drawing.Point(193, 283);
            this.bt_EditarVendas.Name = "bt_EditarVendas";
            this.bt_EditarVendas.Size = new System.Drawing.Size(158, 62);
            this.bt_EditarVendas.TabIndex = 7;
            this.bt_EditarVendas.Text = "Lista de Vendas";
            this.bt_EditarVendas.UseVisualStyleBackColor = true;
            this.bt_EditarVendas.Click += new System.EventHandler(this.Bt_EditarVendas_Click);
            // 
            // ATelaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(641, 399);
            this.Controls.Add(this.bt_EditarVendas);
            this.Controls.Add(this.bt_EditarCompras);
            this.Controls.Add(this.bt_Fornecedores);
            this.Controls.Add(this.bt_Compras);
            this.Controls.Add(this.bt_Vendas);
            this.Controls.Add(this.bt_Estoque);
            this.Controls.Add(this.bt_Produtos);
            this.Controls.Add(this.bt_Clientes);
            this.Name = "ATelaPrincipal";
            this.Text = "Tela Principal";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bt_Clientes;
        private System.Windows.Forms.Button bt_Produtos;
        private System.Windows.Forms.Button bt_Estoque;
        private System.Windows.Forms.Button bt_Vendas;
        private System.Windows.Forms.Button bt_Compras;
        private System.Windows.Forms.Button bt_Fornecedores;
        private System.Windows.Forms.Button bt_EditarCompras;
        private System.Windows.Forms.Button bt_EditarVendas;
    }
}

