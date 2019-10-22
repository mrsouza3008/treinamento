using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WF_Livros
{
    public partial class Form1 : Form
    {
        //public List<Livro> Livros{ get; set; }
        public Livro LivroManutencao { get; private set; }


        public Form1()
        {
            InitializeComponent();
        }

        private void Bt_Salvar_Click(object sender, EventArgs e)
        {
         
            LivroManutencao = new Livro
            {
                Id = Guid.NewGuid(),
                Titulo = txtTitulo.Text,
                Autor = txtAutor.Text,
                DataLancamento = DTDataLancamento.Value,
                NumeroPaginas = Convert.ToInt32(txtNumeroPaginas.Value)
            };

            Close();
            
        }

        public void PreencherLivro(Livro livro)
        {
            txtId.Text = livro.Id.ToString();
            txtTitulo.Text = livro.Titulo;
            txtAutor.Text = livro.Autor;
            DTDataLancamento.Value = livro.DataLancamento;
            txtNumeroPaginas.Value = livro.NumeroPaginas;

        }
    }
}
