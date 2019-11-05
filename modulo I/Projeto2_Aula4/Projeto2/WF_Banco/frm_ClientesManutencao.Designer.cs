namespace WF_Banco
{
    partial class frm_ClientesManutencao
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
            this.btn_Salvar = new System.Windows.Forms.Button();
            this.txt_NomeDoCliente = new System.Windows.Forms.TextBox();
            this.lbl_NomeDoCliente = new System.Windows.Forms.Label();
            this.lbl_DataDeNascimento = new System.Windows.Forms.Label();
            this.date_Nascimento = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // btn_Salvar
            // 
            this.btn_Salvar.Location = new System.Drawing.Point(406, 45);
            this.btn_Salvar.Name = "btn_Salvar";
            this.btn_Salvar.Size = new System.Drawing.Size(140, 23);
            this.btn_Salvar.TabIndex = 7;
            this.btn_Salvar.Text = "Salvar";
            this.btn_Salvar.UseVisualStyleBackColor = true;
            this.btn_Salvar.Click += new System.EventHandler(this.Btn_Salvar_Click);
            // 
            // txt_NomeDoCliente
            // 
            this.txt_NomeDoCliente.Location = new System.Drawing.Point(124, 12);
            this.txt_NomeDoCliente.Name = "txt_NomeDoCliente";
            this.txt_NomeDoCliente.Size = new System.Drawing.Size(422, 20);
            this.txt_NomeDoCliente.TabIndex = 6;
            // 
            // lbl_NomeDoCliente
            // 
            this.lbl_NomeDoCliente.AutoSize = true;
            this.lbl_NomeDoCliente.Location = new System.Drawing.Point(11, 15);
            this.lbl_NomeDoCliente.Name = "lbl_NomeDoCliente";
            this.lbl_NomeDoCliente.Size = new System.Drawing.Size(88, 13);
            this.lbl_NomeDoCliente.TabIndex = 5;
            this.lbl_NomeDoCliente.Text = "Nome do Cliente:";
            // 
            // lbl_DataDeNascimento
            // 
            this.lbl_DataDeNascimento.AutoSize = true;
            this.lbl_DataDeNascimento.Location = new System.Drawing.Point(11, 50);
            this.lbl_DataDeNascimento.Name = "lbl_DataDeNascimento";
            this.lbl_DataDeNascimento.Size = new System.Drawing.Size(107, 13);
            this.lbl_DataDeNascimento.TabIndex = 8;
            this.lbl_DataDeNascimento.Text = "Data de Nascimento:";
            // 
            // date_Nascimento
            // 
            this.date_Nascimento.Location = new System.Drawing.Point(124, 44);
            this.date_Nascimento.Name = "date_Nascimento";
            this.date_Nascimento.Size = new System.Drawing.Size(200, 20);
            this.date_Nascimento.TabIndex = 9;
            // 
            // frm_ClientesManutencao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(567, 86);
            this.Controls.Add(this.date_Nascimento);
            this.Controls.Add(this.lbl_DataDeNascimento);
            this.Controls.Add(this.btn_Salvar);
            this.Controls.Add(this.txt_NomeDoCliente);
            this.Controls.Add(this.lbl_NomeDoCliente);
            this.Name = "frm_ClientesManutencao";
            this.Text = "frm_ClientesManutencao";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Salvar;
        private System.Windows.Forms.TextBox txt_NomeDoCliente;
        private System.Windows.Forms.Label lbl_NomeDoCliente;
        private System.Windows.Forms.Label lbl_DataDeNascimento;
        private System.Windows.Forms.DateTimePicker date_Nascimento;
    }
}