namespace WF_Banco
{
    partial class frm_BancosManutencao
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
            this.lbl_CodigoDoBanco = new System.Windows.Forms.Label();
            this.lbl_NomeDoBanco = new System.Windows.Forms.Label();
            this.txt_CodigoDoBanco = new System.Windows.Forms.TextBox();
            this.txt_NomeDoBanco = new System.Windows.Forms.TextBox();
            this.btn_Salvar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_CodigoDoBanco
            // 
            this.lbl_CodigoDoBanco.AutoSize = true;
            this.lbl_CodigoDoBanco.Location = new System.Drawing.Point(12, 15);
            this.lbl_CodigoDoBanco.Name = "lbl_CodigoDoBanco";
            this.lbl_CodigoDoBanco.Size = new System.Drawing.Size(92, 13);
            this.lbl_CodigoDoBanco.TabIndex = 0;
            this.lbl_CodigoDoBanco.Text = "Código do Banco:";
            // 
            // lbl_NomeDoBanco
            // 
            this.lbl_NomeDoBanco.AutoSize = true;
            this.lbl_NomeDoBanco.Location = new System.Drawing.Point(12, 43);
            this.lbl_NomeDoBanco.Name = "lbl_NomeDoBanco";
            this.lbl_NomeDoBanco.Size = new System.Drawing.Size(87, 13);
            this.lbl_NomeDoBanco.TabIndex = 1;
            this.lbl_NomeDoBanco.Text = "Nome do Banco:";
            // 
            // txt_CodigoDoBanco
            // 
            this.txt_CodigoDoBanco.Location = new System.Drawing.Point(110, 12);
            this.txt_CodigoDoBanco.Name = "txt_CodigoDoBanco";
            this.txt_CodigoDoBanco.Size = new System.Drawing.Size(58, 20);
            this.txt_CodigoDoBanco.TabIndex = 2;
            // 
            // txt_NomeDoBanco
            // 
            this.txt_NomeDoBanco.Location = new System.Drawing.Point(110, 40);
            this.txt_NomeDoBanco.Name = "txt_NomeDoBanco";
            this.txt_NomeDoBanco.Size = new System.Drawing.Size(437, 20);
            this.txt_NomeDoBanco.TabIndex = 3;
            // 
            // btn_Salvar
            // 
            this.btn_Salvar.Location = new System.Drawing.Point(407, 73);
            this.btn_Salvar.Name = "btn_Salvar";
            this.btn_Salvar.Size = new System.Drawing.Size(140, 23);
            this.btn_Salvar.TabIndex = 4;
            this.btn_Salvar.Text = "Salvar";
            this.btn_Salvar.UseVisualStyleBackColor = true;
            // 
            // frm_BancosManutencao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(555, 103);
            this.Controls.Add(this.btn_Salvar);
            this.Controls.Add(this.txt_NomeDoBanco);
            this.Controls.Add(this.txt_CodigoDoBanco);
            this.Controls.Add(this.lbl_NomeDoBanco);
            this.Controls.Add(this.lbl_CodigoDoBanco);
            this.Name = "frm_BancosManutencao";
            this.Text = "frm_BancosManutencao";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_CodigoDoBanco;
        private System.Windows.Forms.Label lbl_NomeDoBanco;
        private System.Windows.Forms.TextBox txt_CodigoDoBanco;
        private System.Windows.Forms.TextBox txt_NomeDoBanco;
        private System.Windows.Forms.Button btn_Salvar;
    }
}