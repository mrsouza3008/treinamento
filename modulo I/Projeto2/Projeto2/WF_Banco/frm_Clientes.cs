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
    public partial class frm_Clientes : Form
    {
        public frm_Clientes()
        {
            InitializeComponent();
        }

        private void Bt_AdicionarCliente_Click(object sender, EventArgs e)
        {
            frm_ClientesManutencao frm = new frm_ClientesManutencao();
            frm.ShowDialog();
            // Colocar aqui um método que atualize a Grid
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
