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
    public partial class frmListagemLivro : Form
    {
        public List<Livro> Livros { get; set; }
        public frmListagemLivro()
        {
            InitializeComponent();
            Initialize();
        }

        private void BtnNovo_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            frm.ShowDialog();
            Livros.Add(frm.LivroManutencao);

            //frm.LivroManutencao.Autor = "Autor X";
            //frm.LivroManutencao.Titulo = "Titulo X";
            //frm.LivroManutencao.DataLancamento = DateTime.Now;
            //frm.LivroManutencao.NumeroPaginas = 10;
            //
            AtualizarGrid();

        }

        private void Initialize()
        {
            Livros = new List<Livro>();
            Livros.Add(new Livro()
            {
                    Autor = "Autor 1 ",
                    DataLancamento = DateTime.Now.AddDays(-50),
                    Id = Guid.NewGuid(),
                    NumeroPaginas = 10,
                    Titulo = "Titulo 1"
            });

      
            Livros.Add(new Livro()
            {
                Autor = "Autor 2 ",
                DataLancamento = DateTime.Now.AddDays(-60),
                Id = Guid.NewGuid(),
                NumeroPaginas = 10,
                Titulo = "Titulo 2"
            });

          
            Livros.Add(new Livro()
            {
                Autor = "Autor 3 ",
                DataLancamento = DateTime.Now.AddDays(-70),
                Id = Guid.NewGuid(),
                NumeroPaginas = 10,
                Titulo = "Titulo 3"
            });

            
            dgListagemLivros.AutoGenerateColumns = false;
            dgListagemLivros.DataSource = Livros;
            dgListagemLivros.Columns["ColunaID"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgListagemLivros.Columns["ColunaAutor"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgListagemLivros.Columns["ColunaTitulo"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
           
        }

        private void DgListagemLivros_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //var teste = dgListagemLivros.Rows[e.RowIndex].DataBoundItem;
            // atribui um objeto
            // fala que o livro será do tipo Livro

            Livro ItemSelecionado = (Livro) dgListagemLivros.Rows[e.RowIndex].DataBoundItem;

            if (e.ColumnIndex == 3) //editar
            { 
                Livro livro = (Livro) dgListagemLivros.Rows[e.RowIndex].DataBoundItem;
                Form1 frm = new Form1();
                frm.PreencherLivro(livro);
                frm.Show();
            }

            if (e.ColumnIndex == 4) //apagar
            {
                DialogResult resut =    MessageBox.Show("Deseja apagar o item?", "Remover", 
                                                        MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (DialogResult == DialogResult.Yes)
                {
                    Livros.Remove(ItemSelecionado);
                    AtualizarGrid();

                }

            }

           //Livro livro = (Livro) dgListagemLivros.Rows[e.RowIndex].DataBoundItem;
                        
         ;
        }

        private void AtualizarGrid()
        {
            dgListagemLivros.DataSource = null;
            //dgListagemLivros.DataSource = Livros;
            dgListagemLivros.DataSource = Livros.OrderBy(a => a.Id).ToList();
        }
    }
}
