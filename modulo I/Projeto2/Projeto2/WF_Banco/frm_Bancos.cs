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
    public partial class frm_Bancos : Form
    {
       
        public frm_Bancos()
        {
            InitializeComponent();
        }

        private void Bt_AdicionarBanco_Click(object sender, EventArgs e)
        {
            frm_BancosManutencao frm = new frm_BancosManutencao();
            frm.ShowDialog();
            // - Colocar aqui um método para atualizar a grid
        }
    }
}
