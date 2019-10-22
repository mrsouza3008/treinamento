namespace WF_Banco
{
    partial class frm_Clientes
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
            this.bt_AdicionarCliente = new System.Windows.Forms.Button();
            this.dgrid_Clientes = new System.Windows.Forms.DataGridView();
            this.NomeCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataDeNascimento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Bt_Editar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Bt_Excluir = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgrid_Clientes)).BeginInit();
            this.SuspendLayout();
            // 
            // bt_AdicionarCliente
            // 
            this.bt_AdicionarCliente.Location = new System.Drawing.Point(520, 405);
            this.bt_AdicionarCliente.Name = "bt_AdicionarCliente";
            this.bt_AdicionarCliente.Size = new System.Drawing.Size(175, 23);
            this.bt_AdicionarCliente.TabIndex = 2;
            this.bt_AdicionarCliente.Text = "Incluir Novo";
            this.bt_AdicionarCliente.UseVisualStyleBackColor = true;
            this.bt_AdicionarCliente.Click += new System.EventHandler(this.Bt_AdicionarCliente_Click);
            // 
            // dgrid_Clientes
            // 
            this.dgrid_Clientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrid_Clientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NomeCliente,
            this.DataDeNascimento,
            this.Bt_Editar,
            this.Bt_Excluir});
            this.dgrid_Clientes.Location = new System.Drawing.Point(12, 12);
            this.dgrid_Clientes.Name = "dgrid_Clientes";
            this.dgrid_Clientes.Size = new System.Drawing.Size(683, 387);
            this.dgrid_Clientes.TabIndex = 3;
            this.dgrid_Clientes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellContentClick);
            // 
            // NomeCliente
            // 
            this.NomeCliente.DataPropertyName = "NomeTitular";
            this.NomeCliente.HeaderText = "Nome";
            this.NomeCliente.Name = "NomeCliente";
            this.NomeCliente.Width = 350;
            // 
            // DataDeNascimento
            // 
            this.DataDeNascimento.DataPropertyName = "Nascimento";
            this.DataDeNascimento.HeaderText = "Nascimento";
            this.DataDeNascimento.Name = "DataDeNascimento";
            // 
            // Bt_Editar
            // 
            this.Bt_Editar.HeaderText = "Editar";
            this.Bt_Editar.Name = "Bt_Editar";
            // 
            // Bt_Excluir
            // 
            this.Bt_Excluir.HeaderText = "Apagar";
            this.Bt_Excluir.Name = "Bt_Excluir";
            // 
            // frm_Clientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(706, 450);
            this.Controls.Add(this.dgrid_Clientes);
            this.Controls.Add(this.bt_AdicionarCliente);
            this.Name = "frm_Clientes";
            this.Text = "frm_Clientes";
            ((System.ComponentModel.ISupportInitialize)(this.dgrid_Clientes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bt_AdicionarCliente;
        private System.Windows.Forms.DataGridView dgrid_Clientes;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomeCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataDeNascimento;
        private System.Windows.Forms.DataGridViewButtonColumn Bt_Editar;
        private System.Windows.Forms.DataGridViewButtonColumn Bt_Excluir;
    }
}