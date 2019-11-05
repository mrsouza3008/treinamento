namespace WF_Banco
{
    partial class FrmPrincipal
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
            this.bt_Bancos = new System.Windows.Forms.Button();
            this.bt_Contas = new System.Windows.Forms.Button();
            this.bt_CaixaEletronico = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bt_Clientes
            // 
            this.bt_Clientes.Location = new System.Drawing.Point(31, 81);
            this.bt_Clientes.Name = "bt_Clientes";
            this.bt_Clientes.Size = new System.Drawing.Size(300, 41);
            this.bt_Clientes.TabIndex = 0;
            this.bt_Clientes.Text = "CLIENTES";
            this.bt_Clientes.UseVisualStyleBackColor = true;
            this.bt_Clientes.Click += new System.EventHandler(this.Bt_Clientes_Click);
            // 
            // bt_Bancos
            // 
            this.bt_Bancos.Location = new System.Drawing.Point(31, 24);
            this.bt_Bancos.Name = "bt_Bancos";
            this.bt_Bancos.Size = new System.Drawing.Size(300, 41);
            this.bt_Bancos.TabIndex = 1;
            this.bt_Bancos.Text = "BANCOS";
            this.bt_Bancos.UseVisualStyleBackColor = true;
            this.bt_Bancos.Click += new System.EventHandler(this.Bt_Bancos_Click);
            // 
            // bt_Contas
            // 
            this.bt_Contas.Location = new System.Drawing.Point(31, 140);
            this.bt_Contas.Name = "bt_Contas";
            this.bt_Contas.Size = new System.Drawing.Size(300, 41);
            this.bt_Contas.TabIndex = 2;
            this.bt_Contas.Text = "CONTAS";
            this.bt_Contas.UseVisualStyleBackColor = true;
            this.bt_Contas.Click += new System.EventHandler(this.Bt_Contas_Click);
            // 
            // bt_CaixaEletronico
            // 
            this.bt_CaixaEletronico.Location = new System.Drawing.Point(31, 203);
            this.bt_CaixaEletronico.Name = "bt_CaixaEletronico";
            this.bt_CaixaEletronico.Size = new System.Drawing.Size(300, 41);
            this.bt_CaixaEletronico.TabIndex = 3;
            this.bt_CaixaEletronico.Text = "CAIXA ELETRÔNICO";
            this.bt_CaixaEletronico.UseVisualStyleBackColor = true;
            this.bt_CaixaEletronico.Click += new System.EventHandler(this.Bt_CaixaEletronico_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(357, 315);
            this.Controls.Add(this.bt_CaixaEletronico);
            this.Controls.Add(this.bt_Contas);
            this.Controls.Add(this.bt_Bancos);
            this.Controls.Add(this.bt_Clientes);
            this.Name = "frmPrincipal";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bt_Clientes;
        private System.Windows.Forms.Button bt_Bancos;
        private System.Windows.Forms.Button bt_Contas;
        private System.Windows.Forms.Button bt_CaixaEletronico;
    }
}

