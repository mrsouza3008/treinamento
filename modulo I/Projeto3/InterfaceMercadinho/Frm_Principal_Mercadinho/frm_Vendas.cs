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

        public RepositoryEstoque estoqueRepository = new RepositoryEstoque();

        public RepositoryVenda vendaRepository = new RepositoryVenda();
        public ClassVenda vendaManutencao { get; set; }
        public ClassEstoque estoqueManutencao { get; set; }


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

        public void Bt_AdicionarProduto_Click(object sender, EventArgs e)
        {
            ClassVenda venda = new ClassVenda();
            venda.IdDoCliente = Convert.ToInt32(cBox_Cliente.SelectedValue);
            venda.IdDoProduto = Convert.ToInt32(cBox_Produto.SelectedValue);
            venda.QtdeVendida = Convert.ToInt32(txt_Qtde.Text);
            venda.DataDaVenda = DateTime.Now;
            
            ClassEstoque estoque;
            estoque = estoqueRepository.Obter(venda.IdDoProduto);

            ClassProduto produtovendido;
            produtovendido = produtoRepository.Obter(venda.IdDoProduto);

            int ValorDaVenda;
            ValorDaVenda = Convert.ToInt32(venda.QtdeVendida * produtovendido.PrecoDeVenda);

            txt_TotalDoProduto.Text = produtovendido.PrecoDeVenda.ToString();
            txt_TotalDeVenda.Text = ValorDaVenda.ToString();

            venda.ValorDaVenda = Convert.ToInt32(txt_TotalDeVenda.Text);

            vendaManutencao = venda;
            estoqueManutencao = estoque;

        }

        private void Bt_Efetivar_Click(object sender, EventArgs e)
        {
            estoqueRepository.RealizarVenda(estoqueManutencao, vendaManutencao);
            vendaRepository.Inserir(vendaManutencao);
            Close();
        }
    }
}
