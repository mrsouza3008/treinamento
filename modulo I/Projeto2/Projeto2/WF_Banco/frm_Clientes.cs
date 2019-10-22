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
    public partial class frm_Clientes : Form
    {
        public ClienteRepository repository = new ClienteRepository();

        public List<Cliente> Clientes { get; set; }

        public void Initialize()
        {
            Clientes = new List<Cliente>();
            dgrid_Clientes.AutoGenerateColumns = false;
            AtualizarGrid();

        }
        public frm_Clientes()
        {
            InitializeComponent();
            Initialize();
        }

        private void Bt_AdicionarCliente_Click(object sender, EventArgs e)
        {
            frm_ClientesManutencao frm = new frm_ClientesManutencao();
            frm.ShowDialog();
            repository.Inserir(frm.ClientesManutencao);
            AtualizarGrid();
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void AtualizarGrid()
        {

            Clientes = repository.Obter().ToList();
            dgrid_Clientes.DataSource = null;
            dgrid_Clientes.DataSource = Clientes.OrderBy(a => a.NomeTitular).ToList();

        }
    }
}
