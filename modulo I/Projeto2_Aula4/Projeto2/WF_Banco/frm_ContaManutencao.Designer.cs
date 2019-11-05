namespace WF_Banco
{
    partial class frm_ContaManutencao
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
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_Agencia = new System.Windows.Forms.TextBox();
            this.txt_ContaCorrente = new System.Windows.Forms.TextBox();
            this.txt_Saldo = new System.Windows.Forms.TextBox();
            this.txt_Limite = new System.Windows.Forms.TextBox();
            this.btn_Salvar = new System.Windows.Forms.Button();
            this.combo_Banco = new System.Windows.Forms.ComboBox();
            this.combo_Cliente = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Banco:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Agência:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Conta Corrente:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 90);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Cliente:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 118);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Saldo:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(13, 145);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(37, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Limite:";
            // 
            // txt_Agencia
            // 
            this.txt_Agencia.Location = new System.Drawing.Point(111, 32);
            this.txt_Agencia.Name = "txt_Agencia";
            this.txt_Agencia.Size = new System.Drawing.Size(100, 20);
            this.txt_Agencia.TabIndex = 10;
            // 
            // txt_ContaCorrente
            // 
            this.txt_ContaCorrente.Location = new System.Drawing.Point(111, 58);
            this.txt_ContaCorrente.Name = "txt_ContaCorrente";
            this.txt_ContaCorrente.Size = new System.Drawing.Size(100, 20);
            this.txt_ContaCorrente.TabIndex = 11;
            // 
            // txt_Saldo
            // 
            this.txt_Saldo.Location = new System.Drawing.Point(111, 113);
            this.txt_Saldo.Name = "txt_Saldo";
            this.txt_Saldo.Size = new System.Drawing.Size(100, 20);
            this.txt_Saldo.TabIndex = 14;
            // 
            // txt_Limite
            // 
            this.txt_Limite.Location = new System.Drawing.Point(111, 142);
            this.txt_Limite.Name = "txt_Limite";
            this.txt_Limite.Size = new System.Drawing.Size(100, 20);
            this.txt_Limite.TabIndex = 15;
            // 
            // btn_Salvar
            // 
            this.btn_Salvar.Location = new System.Drawing.Point(284, 140);
            this.btn_Salvar.Name = "btn_Salvar";
            this.btn_Salvar.Size = new System.Drawing.Size(140, 22);
            this.btn_Salvar.TabIndex = 16;
            this.btn_Salvar.Text = "Salvar";
            this.btn_Salvar.UseVisualStyleBackColor = true;
            this.btn_Salvar.Click += new System.EventHandler(this.Btn_Salvar_Click);
            // 
            // combo_Banco
            // 
            this.combo_Banco.FormattingEnabled = true;
            this.combo_Banco.Location = new System.Drawing.Point(111, 5);
            this.combo_Banco.Name = "combo_Banco";
            this.combo_Banco.Size = new System.Drawing.Size(327, 21);
            this.combo_Banco.TabIndex = 17;
            // 
            // combo_Cliente
            // 
            this.combo_Cliente.FormattingEnabled = true;
            this.combo_Cliente.Location = new System.Drawing.Point(111, 84);
            this.combo_Cliente.Name = "combo_Cliente";
            this.combo_Cliente.Size = new System.Drawing.Size(327, 21);
            this.combo_Cliente.TabIndex = 18;
            // 
            // frm_ContaManutencao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 174);
            this.Controls.Add(this.combo_Cliente);
            this.Controls.Add(this.combo_Banco);
            this.Controls.Add(this.btn_Salvar);
            this.Controls.Add(this.txt_Limite);
            this.Controls.Add(this.txt_Saldo);
            this.Controls.Add(this.txt_ContaCorrente);
            this.Controls.Add(this.txt_Agencia);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "frm_ContaManutencao";
            this.Text = "frm_ContaManutencao";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_Agencia;
        private System.Windows.Forms.TextBox txt_ContaCorrente;
        private System.Windows.Forms.TextBox txt_Saldo;
        private System.Windows.Forms.TextBox txt_Limite;
        private System.Windows.Forms.Button btn_Salvar;
        private System.Windows.Forms.ComboBox combo_Banco;
        private System.Windows.Forms.ComboBox combo_Cliente;
    }
}