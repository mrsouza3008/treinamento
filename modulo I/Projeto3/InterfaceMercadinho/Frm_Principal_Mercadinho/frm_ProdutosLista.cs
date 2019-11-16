using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Mercadinho;
using Mercadinho_INTERFACE;

namespace Frm_Principal_Mercadinho
{
    public partial class Frm_ListaProdutos : Form
    {

        public RepositoryProduto repository = new RepositoryProduto();
        public List<ClassProduto> Produtos { get; set; }
        public Frm_ListaProdutos()
        {
            InitializeComponent();
            Initialize();
        }

        private void AtualizarGrid()
        {
            Produtos = repository.Obter().ToList();
            dbGrid_Produtos.DataSource = null;
            dbGrid_Produtos.DataSource = Produtos.OrderBy(a => a.DescricaoDoProduto).ToList();

        }

        public void Initialize()
        {
            Produtos = new List<ClassProduto>();
            dbGrid_Produtos.AutoGenerateColumns = false;
            AtualizarGrid();
        }

        private void Bt_Incluir_Click(object sender, EventArgs e)
        {
            frm_ProdutosManutencao frm = new frm_ProdutosManutencao(0, repository);
            Hide();
            frm.ShowDialog();
            //repository.Inserir(frm.ProdutoManutencao);
            Show();
            AtualizarGrid();
        }

        private void DbGrid_Produtos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dbGrid_Produtos.Columns[e.ColumnIndex].Name == "Bt_Editar") // Editar
            {
                ClassProduto itemSelecionado = (ClassProduto)dbGrid_Produtos.Rows[e.RowIndex].DataBoundItem;

                frm_ProdutosManutencao frm = new frm_ProdutosManutencao(itemSelecionado.Id, repository);
               
                Hide();
                frm.ShowDialog();
          
                Show();
                AtualizarGrid();

            }
            if (dbGrid_Produtos.Columns[e.ColumnIndex].Name == "Bt_Apagar") // Editar
            {
                ClassProduto itemSelecionado = (ClassProduto)dbGrid_Produtos.Rows[e.RowIndex].DataBoundItem;

                repository.Apagar(itemSelecionado.Id);
                AtualizarGrid();

            }
        }
    }
}
