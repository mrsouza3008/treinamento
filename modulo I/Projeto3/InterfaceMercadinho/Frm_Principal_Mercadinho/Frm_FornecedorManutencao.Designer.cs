namespace Mercadinho_INTERFACE
{
    partial class Frm_FornecedorManutencao
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
            this.txt_NomeDoFornecedor = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ck_Ativo = new System.Windows.Forms.CheckBox();
            this.bt_Salvar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_NomeDoFornecedor
            // 
            this.txt_NomeDoFornecedor.Location = new System.Drawing.Point(69, 12);
            this.txt_NomeDoFornecedor.Name = "txt_NomeDoFornecedor";
            this.txt_NomeDoFornecedor.Size = new System.Drawing.Size(480, 20);
            this.txt_NomeDoFornecedor.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nome";
            // 
            // ck_Ativo
            // 
            this.ck_Ativo.AutoSize = true;
            this.ck_Ativo.Location = new System.Drawing.Point(597, 14);
            this.ck_Ativo.Name = "ck_Ativo";
            this.ck_Ativo.Size = new System.Drawing.Size(50, 17);
            this.ck_Ativo.TabIndex = 2;
            this.ck_Ativo.Text = "Ativo";
            this.ck_Ativo.UseVisualStyleBackColor = true;
            // 
            // bt_Salvar
            // 
            this.bt_Salvar.Location = new System.Drawing.Point(505, 68);
            this.bt_Salvar.Name = "bt_Salvar";
            this.bt_Salvar.Size = new System.Drawing.Size(75, 23);
            this.bt_Salvar.TabIndex = 3;
            this.bt_Salvar.Text = "SALVAR";
            this.bt_Salvar.UseVisualStyleBackColor = true;
            this.bt_Salvar.Click += new System.EventHandler(this.Bt_Salvar_Click);
            // 
            // Frm_FornecedorManutencao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(698, 113);
            this.Controls.Add(this.bt_Salvar);
            this.Controls.Add(this.ck_Ativo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_NomeDoFornecedor);
            this.Name = "Frm_FornecedorManutencao";
            this.Text = "Frm_FornecedorManutencao";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_NomeDoFornecedor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox ck_Ativo;
        private System.Windows.Forms.Button bt_Salvar;
    }
}