namespace Frm_Principal_Mercadinho
{
    partial class Frm_ListaClientes
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
            this.dbGrid_Clientes = new System.Windows.Forms.DataGridView();
            this.Nome_do_Cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Data_de_Nascimento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Data_de_Ultima_Compra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Bt_Editar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Bt_Apagar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.bt_IncluirCliente = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dbGrid_Clientes)).BeginInit();
            this.SuspendLayout();
            // 
            // dbGrid_Clientes
            // 
            this.dbGrid_Clientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dbGrid_Clientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nome_do_Cliente,
            this.Data_de_Nascimento,
            this.Data_de_Ultima_Compra,
            this.Bt_Editar,
            this.Bt_Apagar});
            this.dbGrid_Clientes.Location = new System.Drawing.Point(13, 13);
            this.dbGrid_Clientes.Name = "dbGrid_Clientes";
            this.dbGrid_Clientes.Size = new System.Drawing.Size(744, 267);
            this.dbGrid_Clientes.TabIndex = 0;
            // 
            // Nome_do_Cliente
            // 
            this.Nome_do_Cliente.DataPropertyName = "NomeDoCliente";
            this.Nome_do_Cliente.HeaderText = "Nome";
            this.Nome_do_Cliente.Name = "Nome_do_Cliente";
            // 
            // Data_de_Nascimento
            // 
            this.Data_de_Nascimento.DataPropertyName = "DataDeNascimento";
            this.Data_de_Nascimento.HeaderText = "Data de Nascimento";
            this.Data_de_Nascimento.Name = "Data_de_Nascimento";
            this.Data_de_Nascimento.Width = 300;
            // 
            // Data_de_Ultima_Compra
            // 
            this.Data_de_Ultima_Compra.DataPropertyName = "DataDeUltimaCompra";
            this.Data_de_Ultima_Compra.HeaderText = "Data da Ultima Compra";
            this.Data_de_Ultima_Compra.Name = "Data_de_Ultima_Compra";
            // 
            // Bt_Editar
            // 
            this.Bt_Editar.HeaderText = "Editar";
            this.Bt_Editar.Name = "Bt_Editar";
            this.Bt_Editar.Text = "Editar";
            // 
            // Bt_Apagar
            // 
            this.Bt_Apagar.HeaderText = "Apagar";
            this.Bt_Apagar.Name = "Bt_Apagar";
            this.Bt_Apagar.Text = "Apagar";
            this.Bt_Apagar.ToolTipText = "Apagar";
            // 
            // bt_IncluirCliente
            // 
            this.bt_IncluirCliente.Location = new System.Drawing.Point(599, 286);
            this.bt_IncluirCliente.Name = "bt_IncluirCliente";
            this.bt_IncluirCliente.Size = new System.Drawing.Size(156, 44);
            this.bt_IncluirCliente.TabIndex = 1;
            this.bt_IncluirCliente.Text = "Incluir Cliente";
            this.bt_IncluirCliente.UseVisualStyleBackColor = true;
            this.bt_IncluirCliente.Click += new System.EventHandler(this.Bt_IncluirCliente_Click);
            // 
            // Frm_ListaClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(767, 342);
            this.Controls.Add(this.bt_IncluirCliente);
            this.Controls.Add(this.dbGrid_Clientes);
            this.Name = "Frm_ListaClientes";
            this.Text = "frm_ListaClientes";
            ((System.ComponentModel.ISupportInitialize)(this.dbGrid_Clientes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dbGrid_Clientes;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome_do_Cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Data_de_Nascimento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Data_de_Ultima_Compra;
        private System.Windows.Forms.DataGridViewButtonColumn Bt_Editar;
        private System.Windows.Forms.DataGridViewButtonColumn Bt_Apagar;
        private System.Windows.Forms.Button bt_IncluirCliente;
    }
}