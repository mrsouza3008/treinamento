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
    public partial class frm_Conta : Form
    {

        public ContaRepository contaRepository { get; set; }
        public IEnumerable<Conta> Contas { get; set; }

        public void Initialize()
        {
            contaRepository = new ContaRepository();
            Contas = new List<Conta>();
            dgrid_Contas.AutoGenerateColumns = false;
            AtualizarGrid();
        }

        private void AtualizarGrid()
        {
            Contas = contaRepository.Obter();
            dgrid_Contas.DataSource = null;
            dgrid_Contas.DataSource = Contas.ToList();

        }
        public frm_Conta()
        {
            InitializeComponent();
            Initialize();
        }

        private void Bt_AdicionarCliente_Click(object sender, EventArgs e)
        {
            frm_ContaManutencao frm = new frm_ContaManutencao(0);
            frm.ShowDialog();
            AtualizarGrid();
        }
    }
}
