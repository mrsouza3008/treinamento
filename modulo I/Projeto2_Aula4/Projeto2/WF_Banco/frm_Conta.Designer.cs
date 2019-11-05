namespace WF_Banco
{
    partial class frm_Conta
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
            this.dgrid_Contas = new System.Windows.Forms.DataGridView();
            this.bt_AdicionarCliente = new System.Windows.Forms.Button();
            this.CodigoBanco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Agencia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ContaCorrente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Saldo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Limite = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Bt_Editar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Bt_Excluir = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgrid_Contas)).BeginInit();
            this.SuspendLayout();
            // 
            // dgrid_Contas
            // 
            this.dgrid_Contas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrid_Contas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CodigoBanco,
            this.Agencia,
            this.ContaCorrente,
            this.Saldo,
            this.Cliente,
            this.Limite,
            this.Bt_Editar,
            this.Bt_Excluir});
            this.dgrid_Contas.Location = new System.Drawing.Point(12, 12);
            this.dgrid_Contas.Name = "dgrid_Contas";
            this.dgrid_Contas.Size = new System.Drawing.Size(805, 387);
            this.dgrid_Contas.TabIndex = 5;
            // 
            // bt_AdicionarCliente
            // 
            this.bt_AdicionarCliente.Location = new System.Drawing.Point(642, 405);
            this.bt_AdicionarCliente.Name = "bt_AdicionarCliente";
            this.bt_AdicionarCliente.Size = new System.Drawing.Size(175, 23);
            this.bt_AdicionarCliente.TabIndex = 4;
            this.bt_AdicionarCliente.Text = "Incluir Novo";
            this.bt_AdicionarCliente.UseVisualStyleBackColor = true;
            this.bt_AdicionarCliente.Click += new System.EventHandler(this.Bt_AdicionarCliente_Click);
            // 
            // CodigoBanco
            // 
            this.CodigoBanco.DataPropertyName = "BancoId";
            this.CodigoBanco.HeaderText = "Banco";
            this.CodigoBanco.Name = "CodigoBanco";
            this.CodigoBanco.Width = 80;
            // 
            // Agencia
            // 
            this.Agencia.DataPropertyName = "Agencia";
            this.Agencia.HeaderText = "Agencia";
            this.Agencia.Name = "Agencia";
            this.Agencia.Width = 80;
            // 
            // ContaCorrente
            // 
            this.ContaCorrente.DataPropertyName = "ContaCorrente";
            this.ContaCorrente.HeaderText = "Conta Corrente";
            this.ContaCorrente.Name = "ContaCorrente";
            // 
            // Saldo
            // 
            this.Saldo.DataPropertyName = "Saldo";
            this.Saldo.HeaderText = "Saldo";
            this.Saldo.Name = "Saldo";
            // 
            // Cliente
            // 
            this.Cliente.DataPropertyName = "ClienteId";
            this.Cliente.HeaderText = "Cliente";
            this.Cliente.Name = "Cliente";
            // 
            // Limite
            // 
            this.Limite.DataPropertyName = "Limite";
            this.Limite.HeaderText = "Limite";
            this.Limite.Name = "Limite";
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
            // frm_Conta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(829, 450);
            this.Controls.Add(this.dgrid_Contas);
            this.Controls.Add(this.bt_AdicionarCliente);
            this.Name = "frm_Conta";
            this.Text = "frm_Conta";
            ((System.ComponentModel.ISupportInitialize)(this.dgrid_Contas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgrid_Contas;
        private System.Windows.Forms.Button bt_AdicionarCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodigoBanco;
        private System.Windows.Forms.DataGridViewTextBoxColumn Agencia;
        private System.Windows.Forms.DataGridViewTextBoxColumn ContaCorrente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Saldo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Limite;
        private System.Windows.Forms.DataGridViewButtonColumn Bt_Editar;
        private System.Windows.Forms.DataGridViewButtonColumn Bt_Excluir;
    }
}