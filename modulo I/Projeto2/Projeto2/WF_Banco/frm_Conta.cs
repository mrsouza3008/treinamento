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
    public partial class frm_Conta : Form
    {
        public frm_Conta()
        {
            InitializeComponent();
        }

        private void Bt_AdicionarCliente_Click(object sender, EventArgs e)
        {
            frm_ContaManutencao frm = new frm_ContaManutencao();
            frm.ShowDialog();
            // Colocar aqui um método que atualize a Grid
        }
    }
}
