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

        public RepositoryProduto Repository = new RepositoryProduto();

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

        private void Bt_Salvar_Click(object sender, EventArgs e)
        {

            string ativo = ckBox_Ativo.Checked ? "S":  "N";     // -- Condicao Tenaria

            /*if (ckBox_Ativo.Checked)
            {
                ativo = "S";
            }
            else
            {
                ativo = "N";
            }*/

            ProdutoManutencao = new ClassProduto
            {
                DescricaoDoProduto = txt_DescricaoDoProduto.Text,
                ValorDeCompra = Convert.ToInt32(txt_ValorDeCompra.Text),
                PercentualDeLucro = Convert.ToInt32(txt_PercentualDeLucro.Text),
                Ativo = ativo,
                QtdeEstoque = 0,
                QtdeMinima = 0

            };

            if (ProdutoManutencao.Id == 0)
            {
                Repository.Inserir(ProdutoManutencao);
            }
            else
            {
                Repository.Editar(ProdutoManutencao);
            }
        }
    }
}
