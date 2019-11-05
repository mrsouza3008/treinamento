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
            frm_BancosManutencao frm = new frm_BancosManutencao(0);
            frm.ShowDialog();
            repository.Inserir(frm.Banco);
            AtualizarGrid();
        }
        private void AtualizarGrid()
        {
         
            Bancos = repository.Obter().ToList();
            dgrid_Bancos.DataSource = null;
            dgrid_Bancos.DataSource = Bancos.OrderBy(a => a.NomeDoBanco).ToList();
            
        }

        private void Dgrid_Bancos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           // MessageBox.Show("Identificado o click", "ok", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Banco itemSelecionado = (Banco)dgrid_Bancos.Rows[e.RowIndex].DataBoundItem;

            if (dgrid_Bancos.Columns[e.ColumnIndex].Name == "Bt_Editar") // Editar
            {
              //  MessageBox.Show("Clicou no botão Editar", "ok", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                frm_BancosManutencao frm = new frm_BancosManutencao(itemSelecionado.Id);
                frm.ShowDialog();
                AtualizarGrid();
            }

            if (dgrid_Bancos.Columns[e.ColumnIndex].Name == "Bt_Excluir") // Excluir
            {
                DialogResult result = MessageBox.Show("Deseja apagar?", "Remover", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    repository.Apagar(itemSelecionado.Id);
                    AtualizarGrid();
                }
            }

        }
    }

  
}
