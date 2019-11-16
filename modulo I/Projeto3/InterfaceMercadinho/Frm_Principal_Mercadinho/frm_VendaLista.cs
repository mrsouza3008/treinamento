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

namespace Mercadinho_INTERFACE
{
    public partial class frm_VendaLista : Form
    {
        public RepositoryVenda repositoryVenda = new RepositoryVenda();

        public List<ClassVenda> Vendas { get; set; }

        public frm_VendaLista()
        {
            InitializeComponent();
            Initialize();
        }

        public void Initialize()
        {
            Vendas = new List<ClassVenda>();
            dGrid_Venda.AutoGenerateColumns = false;
            AtualizarGrid();
        }

        public void AtualizarGrid()
        {
            Vendas = repositoryVenda.Obter().ToList();
            dGrid_Venda.DataSource = null;
            dGrid_Venda.DataSource = Vendas.OrderBy(a => a.DataDaVenda).ToList();
        }

    }
}
