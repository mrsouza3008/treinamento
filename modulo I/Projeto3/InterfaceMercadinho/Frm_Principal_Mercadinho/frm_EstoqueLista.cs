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


namespace Frm_Principal_Mercadinho
{
    public partial class Frm_ListaEstoque : Form
    {
        public RepositoryProduto repository = new RepositoryProduto();
        public List<ClassProduto> Produtos { get; set; }
        public Frm_ListaEstoque()
        {
            InitializeComponent();
            Initialize();
        }

        public void Initialize()
        {
            Produtos = new List<ClassProduto>();
            dGrid_Estoque.AutoGenerateColumns = false;
            AtualizarGrid();
        }

        public void AtualizarGrid()
        {
            Produtos = repository.Obter().ToList();
            dGrid_Estoque.DataSource = null;
            dGrid_Estoque.DataSource = Produtos.OrderBy(a => a.DescricaoDoProduto).ToList();
        }
    }
}
