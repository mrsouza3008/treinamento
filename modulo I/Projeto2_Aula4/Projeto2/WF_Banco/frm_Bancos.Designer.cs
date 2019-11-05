namespace WF_Banco
{
    partial class frm_Bancos
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
            this.dgrid_Bancos = new System.Windows.Forms.DataGridView();
            this.CodigoBanco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NomeDoBanco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Bt_Editar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Bt_Excluir = new System.Windows.Forms.DataGridViewButtonColumn();
            this.bt_AdicionarBanco = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgrid_Bancos)).BeginInit();
            this.SuspendLayout();
            // 
            // dgrid_Bancos
            // 
            this.dgrid_Bancos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrid_Bancos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CodigoBanco,
            this.NomeDoBanco,
            this.Bt_Editar,
            this.Bt_Excluir});
            this.dgrid_Bancos.Location = new System.Drawing.Point(12, 12);
            this.dgrid_Bancos.Name = "dgrid_Bancos";
            this.dgrid_Bancos.Size = new System.Drawing.Size(683, 220);
            this.dgrid_Bancos.TabIndex = 0;
            this.dgrid_Bancos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgrid_Bancos_CellContentClick);
            // 
            // CodigoBanco
            // 
            this.CodigoBanco.DataPropertyName = "CodigoDoBanco";
            this.CodigoBanco.HeaderText = "Código";
            this.CodigoBanco.Name = "CodigoBanco";
            // 
            // NomeDoBanco
            // 
            this.NomeDoBanco.DataPropertyName = "NomeDoBanco";
            this.NomeDoBanco.HeaderText = "Nome";
            this.NomeDoBanco.Name = "NomeDoBanco";
            this.NomeDoBanco.Width = 340;
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
            // bt_AdicionarBanco
            // 
            this.bt_AdicionarBanco.Location = new System.Drawing.Point(520, 239);
            this.bt_AdicionarBanco.Name = "bt_AdicionarBanco";
            this.bt_AdicionarBanco.Size = new System.Drawing.Size(175, 23);
            this.bt_AdicionarBanco.TabIndex = 1;
            this.bt_AdicionarBanco.Text = "Incluir Novo";
            this.bt_AdicionarBanco.UseVisualStyleBackColor = true;
            this.bt_AdicionarBanco.Click += new System.EventHandler(this.Bt_AdicionarBanco_Click);
            // 
            // frm_Bancos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(709, 295);
            this.Controls.Add(this.bt_AdicionarBanco);
            this.Controls.Add(this.dgrid_Bancos);
            this.Name = "frm_Bancos";
            this.Text = "CADASTRO DE BANCOS";
            ((System.ComponentModel.ISupportInitialize)(this.dgrid_Bancos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgrid_Bancos;
        private System.Windows.Forms.Button bt_AdicionarBanco;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodigoBanco;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomeDoBanco;
        private System.Windows.Forms.DataGridViewButtonColumn Bt_Editar;
        private System.Windows.Forms.DataGridViewButtonColumn Bt_Excluir;
    }
}