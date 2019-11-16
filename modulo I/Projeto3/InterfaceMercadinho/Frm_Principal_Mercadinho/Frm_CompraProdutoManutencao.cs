﻿using System;
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
    public partial class Frm_CompraProdutoManutencao : Form
    {
        public RepositoryFornecedor fornecedorRepository = new RepositoryFornecedor();
        public RepositoryProduto produtoRepository = new RepositoryProduto();
        public RepositoryEstoque estoqueRepository = new RepositoryEstoque();
        public RepositoryCompra compraRepository = new RepositoryCompra();
        public ClassCompra CompraManutencao { get; set; }
        public List<ClassFornecedor> Fornecedores { get; set; }
        public List<ClassProduto> Produtos { get; set; }


        public void Initialize()
        {
            Produtos = new List<ClassProduto>();
            Produtos = produtoRepository.Obter().ToList();
            cBox_Produto.DataSource = Produtos;
            cBox_Produto.DisplayMember = "DescricaoDoProduto";
            cBox_Produto.ValueMember = "Id";


            Fornecedores = new List<ClassFornecedor>();
            Fornecedores = fornecedorRepository.Obter().ToList();
            cBox_Fornecedor.DataSource = Fornecedores;
            cBox_Fornecedor.DisplayMember = "NomeDoFornecedor";
            cBox_Fornecedor.ValueMember = "Id";
        }

        public Frm_CompraProdutoManutencao()
        {
            InitializeComponent();
            Initialize();
        }

        private void Bt_Salvar_Click(object sender, EventArgs e)
        {
            CompraManutencao = new ClassCompra();
            CompraManutencao.FornecedorId = Convert.ToInt32(cBox_Fornecedor.SelectedValue);
            CompraManutencao.ProdutoId = Convert.ToInt32(cBox_Produto.SelectedValue);
            CompraManutencao.QtdeDeCompra = Convert.ToInt32(txt_Qtde.Text);
            CompraManutencao.DataDeRecebimento = DateTime.Now;

            ClassEstoque estoque;
            estoque = estoqueRepository.Obter(CompraManutencao.ProdutoId);

          
            estoqueRepository.Recebimento(estoque, CompraManutencao);                

            
            Close();

        }
    }
}
