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
        public ClienteRepository ClienteRepository { get; set; }
        public frm_ClientesManutencao(int id)
        {
            InitializeComponent();
            ObterCliente(id);
        }


        private void ObterCliente(int id)
        {
            ClientesManutencao = ClienteRepository.Obter(id);

            if (ClientesManutencao == null) // Então é novo
            {
                ClientesManutencao = new Cliente();
            }
            else // Editar conta existente
            {
                txt_NomeDoCliente.Text = ClientesManutencao.NomeTitular;
                date_Nascimento.Value = ClientesManutencao.Nascimento;
            }
        }


        private void Btn_Salvar_Click(object sender, EventArgs e)
        {
            ClientesManutencao = new Cliente
            {
                NomeTitular = txt_NomeDoCliente.Text,
                Nascimento = date_Nascimento.Value
            };
            Close();
        }
    }
}
