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

        public RepositoryCliente Repository { get; private set; }


        public Frm_ClientesManutencao(int id, RepositoryCliente RepCliente)
        {
            InitializeComponent();
            Repository = RepCliente;
            Obter(id);
        }

        private void Obter(int id)
        {
            ClienteManutencao = Repository.Obter(id); //tem algum erro aqui  <<<---

            if (ClienteManutencao == null) //Novo
            {
                ClienteManutencao = new ClassCliente();
            }
            else //Editar
            {
                txt_NomeDoCliente.Text = ClienteManutencao.NomeDoCliente;
                dt_DataDeNascimento.Value = ClienteManutencao.DataDeNascimento;
            }


        }
        private bool CadastroEhValido()
        {
            if (string.IsNullOrEmpty(txt_NomeDoCliente.Text))
            {
                MessageBox.Show("Informe o nome do cliente!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private void Bt_Salvar_Click(object sender, EventArgs e)
        {
            if (CadastroEhValido())
            {
                ClienteManutencao.NomeDoCliente = txt_NomeDoCliente.Text;
                ClienteManutencao.DataDeNascimento = dt_DataDeNascimento.Value;

                /* ClienteManutencao = new ClassCliente
                {
                    NomeDoCliente = txt_NomeDoCliente.Text,
                    DataDeNascimento = dt_DataDeNascimento.Value
                };
                */


                if (ClienteManutencao.Id == 0)
                {

                    Repository.Inserir(ClienteManutencao);
                }
                else
                {         
                    Repository.Editar(ClienteManutencao);
                }

                Close();
            }
            
        }
    }
}
