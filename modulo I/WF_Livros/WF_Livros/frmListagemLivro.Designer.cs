namespace WF_Livros
{
    partial class frmListagemLivro
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
            this.dgListagemLivros = new System.Windows.Forms.DataGridView();
            this.btnNovo = new System.Windows.Forms.Button();
            this.ColunaID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColunaTitulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColunaAutor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnEditar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnApagar = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgListagemLivros)).BeginInit();
            this.SuspendLayout();
            // 
            // dgListagemLivros
            // 
            this.dgListagemLivros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgListagemLivros.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColunaID,
            this.ColunaTitulo,
            this.ColunaAutor,
            this.btnEditar,
            this.btnApagar});
            this.dgListagemLivros.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgListagemLivros.Location = new System.Drawing.Point(0, 0);
            this.dgListagemLivros.Name = "dgListagemLivros";
            this.dgListagemLivros.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgListagemLivros.Size = new System.Drawing.Size(800, 296);
            this.dgListagemLivros.TabIndex = 0;
            this.dgListagemLivros.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgListagemLivros_CellClick);
            // 
            // btnNovo
            // 
            this.btnNovo.Location = new System.Drawing.Point(584, 335);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(75, 23);
            this.btnNovo.TabIndex = 1;
            this.btnNovo.Text = "Novo";
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.BtnNovo_Click);
            // 
            // ColunaID
            // 
            this.ColunaID.DataPropertyName = "ID";
            this.ColunaID.HeaderText = "Código";
            this.ColunaID.Name = "ColunaID";
            // 
            // ColunaTitulo
            // 
            this.ColunaTitulo.DataPropertyName = "Titulo";
            this.ColunaTitulo.HeaderText = "Titulo";
            this.ColunaTitulo.Name = "ColunaTitulo";
            // 
            // ColunaAutor
            // 
            this.ColunaAutor.DataPropertyName = "Autor";
            this.ColunaAutor.HeaderText = "Autor";
            this.ColunaAutor.Name = "ColunaAutor";
            // 
            // btnEditar
            // 
            this.btnEditar.HeaderText = "Editar";
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.btnEditar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // btnApagar
            // 
            this.btnApagar.HeaderText = "Apagar";
            this.btnApagar.Name = "btnApagar";
            this.btnApagar.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.btnApagar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // frmListagemLivro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnNovo);
            this.Controls.Add(this.dgListagemLivros);
            this.Name = "frmListagemLivro";
            this.Text = "frmListagemLivro";
            ((System.ComponentModel.ISupportInitialize)(this.dgListagemLivros)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgListagemLivros;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColunaID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColunaTitulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColunaAutor;
        private System.Windows.Forms.DataGridViewButtonColumn btnEditar;
        private System.Windows.Forms.DataGridViewButtonColumn btnApagar;
    }
}