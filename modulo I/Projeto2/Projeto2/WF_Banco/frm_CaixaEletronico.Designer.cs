namespace WF_Banco
{
    partial class frm_CaixaEletronico
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
            this.cb_BancoOrigem = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cb_BancoDestino = new System.Windows.Forms.ComboBox();
            this.txt_AgenciaOrigem = new System.Windows.Forms.TextBox();
            this.txt_ContaCorrenteOrigem = new System.Windows.Forms.TextBox();
            this.txt_Valor = new System.Windows.Forms.TextBox();
            this.txt_ContaCorrenteDestino = new System.Windows.Forms.TextBox();
            this.txt_AgenciaDestino = new System.Windows.Forms.TextBox();
            this.bt_Sacar = new System.Windows.Forms.Button();
            this.bt_Depositar = new System.Windows.Forms.Button();
            this.bt_Transferir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cb_BancoOrigem
            // 
            this.cb_BancoOrigem.FormattingEnabled = true;
            this.cb_BancoOrigem.Location = new System.Drawing.Point(108, 22);
            this.cb_BancoOrigem.Name = "cb_BancoOrigem";
            this.cb_BancoOrigem.Size = new System.Drawing.Size(343, 21);
            this.cb_BancoOrigem.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Banco Origem";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Agencia";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Conta Corrente";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 138);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Valor";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(473, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "para";
            // 
            // cb_BancoDestino
            // 
            this.cb_BancoDestino.FormattingEnabled = true;
            this.cb_BancoDestino.Location = new System.Drawing.Point(516, 22);
            this.cb_BancoDestino.Name = "cb_BancoDestino";
            this.cb_BancoDestino.Size = new System.Drawing.Size(343, 21);
            this.cb_BancoDestino.TabIndex = 6;
            // 
            // txt_AgenciaOrigem
            // 
            this.txt_AgenciaOrigem.Location = new System.Drawing.Point(108, 59);
            this.txt_AgenciaOrigem.Name = "txt_AgenciaOrigem";
            this.txt_AgenciaOrigem.Size = new System.Drawing.Size(136, 20);
            this.txt_AgenciaOrigem.TabIndex = 7;
            // 
            // txt_ContaCorrenteOrigem
            // 
            this.txt_ContaCorrenteOrigem.Location = new System.Drawing.Point(108, 98);
            this.txt_ContaCorrenteOrigem.Name = "txt_ContaCorrenteOrigem";
            this.txt_ContaCorrenteOrigem.Size = new System.Drawing.Size(136, 20);
            this.txt_ContaCorrenteOrigem.TabIndex = 8;
            // 
            // txt_Valor
            // 
            this.txt_Valor.Location = new System.Drawing.Point(108, 135);
            this.txt_Valor.Name = "txt_Valor";
            this.txt_Valor.Size = new System.Drawing.Size(136, 20);
            this.txt_Valor.TabIndex = 9;
            // 
            // txt_ContaCorrenteDestino
            // 
            this.txt_ContaCorrenteDestino.Location = new System.Drawing.Point(516, 98);
            this.txt_ContaCorrenteDestino.Name = "txt_ContaCorrenteDestino";
            this.txt_ContaCorrenteDestino.Size = new System.Drawing.Size(136, 20);
            this.txt_ContaCorrenteDestino.TabIndex = 11;
            // 
            // txt_AgenciaDestino
            // 
            this.txt_AgenciaDestino.Location = new System.Drawing.Point(516, 59);
            this.txt_AgenciaDestino.Name = "txt_AgenciaDestino";
            this.txt_AgenciaDestino.Size = new System.Drawing.Size(136, 20);
            this.txt_AgenciaDestino.TabIndex = 10;
            // 
            // bt_Sacar
            // 
            this.bt_Sacar.Location = new System.Drawing.Point(15, 205);
            this.bt_Sacar.Name = "bt_Sacar";
            this.bt_Sacar.Size = new System.Drawing.Size(168, 46);
            this.bt_Sacar.TabIndex = 12;
            this.bt_Sacar.Text = "SACAR";
            this.bt_Sacar.UseVisualStyleBackColor = true;
            this.bt_Sacar.Click += new System.EventHandler(this.Bt_Sacar_Click);
            // 
            // bt_Depositar
            // 
            this.bt_Depositar.Location = new System.Drawing.Point(270, 205);
            this.bt_Depositar.Name = "bt_Depositar";
            this.bt_Depositar.Size = new System.Drawing.Size(168, 46);
            this.bt_Depositar.TabIndex = 13;
            this.bt_Depositar.Text = "DEPOSITAR";
            this.bt_Depositar.UseVisualStyleBackColor = true;
            // 
            // bt_Transferir
            // 
            this.bt_Transferir.Location = new System.Drawing.Point(516, 205);
            this.bt_Transferir.Name = "bt_Transferir";
            this.bt_Transferir.Size = new System.Drawing.Size(168, 46);
            this.bt_Transferir.TabIndex = 14;
            this.bt_Transferir.Text = "TRANSFERIR";
            this.bt_Transferir.UseVisualStyleBackColor = true;
            // 
            // frm_CaixaEletronico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(888, 298);
            this.Controls.Add(this.bt_Transferir);
            this.Controls.Add(this.bt_Depositar);
            this.Controls.Add(this.bt_Sacar);
            this.Controls.Add(this.txt_ContaCorrenteDestino);
            this.Controls.Add(this.txt_AgenciaDestino);
            this.Controls.Add(this.txt_Valor);
            this.Controls.Add(this.txt_ContaCorrenteOrigem);
            this.Controls.Add(this.txt_AgenciaOrigem);
            this.Controls.Add(this.cb_BancoDestino);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cb_BancoOrigem);
            this.Name = "frm_CaixaEletronico";
            this.Text = "frm_CaixaEletronico";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cb_BancoOrigem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cb_BancoDestino;
        private System.Windows.Forms.TextBox txt_AgenciaOrigem;
        private System.Windows.Forms.TextBox txt_ContaCorrenteOrigem;
        private System.Windows.Forms.TextBox txt_Valor;
        private System.Windows.Forms.TextBox txt_ContaCorrenteDestino;
        private System.Windows.Forms.TextBox txt_AgenciaDestino;
        private System.Windows.Forms.Button bt_Sacar;
        private System.Windows.Forms.Button bt_Depositar;
        private System.Windows.Forms.Button bt_Transferir;
    }
}