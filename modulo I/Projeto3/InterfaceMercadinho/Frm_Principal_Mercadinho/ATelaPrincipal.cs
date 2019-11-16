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
    public partial class ATelaPrincipal : Form
    {
        public ATelaPrincipal()
        {
            InitializeComponent();
        }

        private void AbrirForm(Form form)
        {
            Hide();

            form.ShowDialog();

            Show();
        }

        private void Bt_Clientes_Click(object sender, EventArgs e)
        {
            Frm_ListaClientes frm = new Frm_ListaClientes();
            AbrirForm(frm);
        }

        private void Bt_Produtos_Click(object sender, EventArgs e)
        {
            Frm_ListaProdutos frm = new Frm_ListaProdutos();
            AbrirForm(frm);
        }

        private void Bt_Estoque_Click(object sender, EventArgs e)
        {
            Frm_ListaEstoque frm = new Frm_ListaEstoque();
            AbrirForm(frm);
        }

        private void Bt_Vendas_Click(object sender, EventArgs e)
        {
            frm_Vendas frm = new frm_Vendas();
            AbrirForm(frm);
        }

        private void Bt_Compras_Click(object sender, EventArgs e)
        {
            Frm_CompraProdutoManutencao frm = new Frm_CompraProdutoManutencao();
            AbrirForm(frm);

        }

        private void Bt_Fornecedores_Click(object sender, EventArgs e)
        {
            Frm_FornecedorLista frm = new Frm_FornecedorLista();
            AbrirForm(frm);
        }

        private void Bt_EditarCompras_Click(object sender, EventArgs e)
        {
            Frm_CompraProdutoLista frm = new Frm_CompraProdutoLista();
            AbrirForm(frm);
        }

        private void Bt_EditarCompras_Click_1(object sender, EventArgs e)
        {
            Frm_CompraProdutoLista frm = new Frm_CompraProdutoLista();
            AbrirForm(frm);
        }
    }
}
