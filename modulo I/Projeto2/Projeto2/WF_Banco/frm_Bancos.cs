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

    
    public partial class frm_Bancos : Form
    {
        public BancoRepository repository = new BancoRepository();
        
        public List<Banco> Bancos { get; set; }

        public void Initialize()
        {
            Bancos = new List<Banco>();
            dgrid_Bancos.AutoGenerateColumns = false;
            AtualizarGrid();

        }
        public frm_Bancos()
        {
            InitializeComponent();
            Initialize();
        }

        private void Bt_AdicionarBanco_Click(object sender, EventArgs e)
        {
            frm_BancosManutencao frm = new frm_BancosManutencao();
            frm.ShowDialog();
            repository.Inserir(frm.BancoManutencao);
            AtualizarGrid();
        }
        private void AtualizarGrid()
        {
         
            Bancos = repository.Obter().ToList();
            dgrid_Bancos.DataSource = null;
            dgrid_Bancos.DataSource = Bancos.OrderBy(a => a.NomeDoBanco).ToList();
            
        }

    }

  
}
