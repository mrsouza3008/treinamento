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
    public partial class Frm_ClientesManutencao : Form
    {
        public ClassCliente ClienteManutencao { get; set; }

        public RepositoryCliente Repository { get; set; }


        public Frm_ClientesManutencao()
        {
            InitializeComponent();
        }

        private void Bt_Salvar_Click(object sender, EventArgs e)
        {


            ClienteManutencao = new ClassCliente
            {
                NomeDoCliente = txt_NomeDoCliente.Text,
                DataDeNascimento = dt_DataDeNascimento.Value
            };
            Close();
        }
    }
}
