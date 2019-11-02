using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


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
    }
}
