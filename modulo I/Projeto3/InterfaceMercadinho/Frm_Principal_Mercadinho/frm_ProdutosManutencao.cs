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
    public partial class frm_ProdutosManutencao : Form
    {
        public ClassProduto ProdutoManutencao { get; set; }

        public RepositoryProduto Repository { get; set; }

        public frm_ProdutosManutencao(int id)
        {
            InitializeComponent();
            Obter(id);
        }

        private void Obter(int id)
        {
            ProdutoManutencao = Repository.Obter(id); //tem algum erro aqui  <<<---

            if (ProdutoManutencao == null) //Novo
            {
                ProdutoManutencao = new ClassProduto();
            }
            else //Editar
            {
                txt_DescricaoDoProduto.Text = ProdutoManutencao.DescricaoDoProduto;
                txt_ValorDeCompra.Text = ProdutoManutencao.ValorDeCompra.ToString();
                txt_PercentualDeLucro.Text = ProdutoManutencao.PercentualDeLucro.ToString();
            }
        }

    }
}
