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


    public partial class frm_Vendas : Form
    {

        public RepositoryCliente clienteRepository = new RepositoryCliente();
        public List<ClassCliente> Clientes { get; set; }

        public RepositoryProduto produtoRepository = new RepositoryProduto();
        public List<ClassProduto> Produtos { get; set; }

        public void Initialize()
        {
            Produtos = new List<ClassProduto>();
            Produtos = produtoRepository.Obter().ToList();
            cBox_Produto.DataSource = Produtos;
            cBox_Produto.DisplayMember = "DescricaoDoProduto";
            cBox_Produto.ValueMember = "Id";

            Clientes = new List<ClassCliente>();
            Clientes = clienteRepository.Obter().ToList();
            cBox_Cliente.DataSource = Clientes;
            cBox_Cliente.DisplayMember = "NomeDoCliente";
            cBox_Cliente.ValueMember = "Id";

        }
        public frm_Vendas()
        {
            InitializeComponent();
            Initialize();
        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }
    }
}
