using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WF_Banco
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void Bt_Bancos_Click(object sender, EventArgs e)
        {
            frm_Bancos frm = new frm_Bancos();
            frm.ShowDialog();
            
        }

        private void Bt_Clientes_Click(object sender, EventArgs e)
        {
            frm_Clientes frm = new frm_Clientes();
            frm.ShowDialog();
        }

        private void Bt_Contas_Click(object sender, EventArgs e)
        {
            frm_Conta frm = new frm_Conta();
            frm.ShowDialog();
        }

        private void Bt_CaixaEletronico_Click(object sender, EventArgs e)
        {
            frm_CaixaEletronico frm = new frm_CaixaEletronico();  
            frm.ShowDialog();
        }
    }
}
