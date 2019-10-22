using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Projeto2;

namespace WF_Banco
{
    public partial class frm_ClientesManutencao : Form
    {
        public Cliente ClientesManutencao { get; set; }
        public frm_ClientesManutencao()
        {
            InitializeComponent();
        }

        private void Btn_Salvar_Click(object sender, EventArgs e)
        {
            ClientesManutencao = new Cliente
            {
                NomeTitular = txt_NomeDoCliente.Text,
                Nascimento = date_Nascimento.Value
            };
        }
    }
}
