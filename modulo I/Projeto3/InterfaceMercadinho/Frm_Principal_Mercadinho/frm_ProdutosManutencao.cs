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

        public RepositoryProduto Repository { get; private set; }

        public frm_ProdutosManutencao(int id, RepositoryProduto RepProduto)
        {
            InitializeComponent();
            Repository = RepProduto;
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
                txt_ValorDeVenda.Text = ProdutoManutencao.PrecoDeVenda.ToString();
                ckBox_Ativo.Checked = ProdutoManutencao.Ativo == "S" ? true : false;

                /*
                if (ProdutoManutencao.Ativo == "S")
                {
                    ckBox_Ativo.Checked = true;
                }
                else
                {
                    ckBox_Ativo.Checked = false;
                }
                */

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

            
            ProdutoManutencao.DescricaoDoProduto = txt_DescricaoDoProduto.Text;
            ProdutoManutencao.ValorDeCompra = Convert.ToDecimal(txt_ValorDeCompra.Text);
            ProdutoManutencao.PercentualDeLucro = Convert.ToInt32(txt_PercentualDeLucro.Text);
            ProdutoManutencao.Ativo = ativo;
            

            if (ProdutoManutencao.Id == 0)
            {
                Repository.Inserir(ProdutoManutencao);
            }
            else
            {
                Repository.Editar(ProdutoManutencao);
            }
            Close();
        }
    }
}
