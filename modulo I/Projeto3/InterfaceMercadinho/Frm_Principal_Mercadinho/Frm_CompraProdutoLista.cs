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
    public partial class Frm_CompraProdutoLista : Form
    {
        public RepositoryCompra repository = new RepositoryCompra();
        public List<ClassCompra> Compras { get; set; }
        public Frm_CompraProdutoLista()
        {
            InitializeComponent();
            Initialize();
        }

        private void Initialize()
        {
            Compras = new List<ClassCompra>();
            dGrid_Compras.AutoGenerateColumns = false;
            AtualizarGrid();
        }

        public void AtualizarGrid()
        {
            Compras = repository.Obter().ToList();
            dGrid_Compras.DataSource = null;
            dGrid_Compras.DataSource = Compras.OrderBy(a => a.DataDeRecebimento).ToList();
        }

        private void Bt_Incluir_Click(object sender, EventArgs e)
        {
            Frm_CompraProdutoManutencao frm = new Frm_CompraProdutoManutencao(0, repository);
            Hide();
            //frm.ShowDialog;
            Show();
                  
        }

        private void DGrid_Compras_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dGrid_Compras.Columns[e.ColumnIndex].Name == "bt_Editar")
            {
                ClassCompra compraSelecionada = (ClassCompra)dGrid_Compras.Rows[e.RowIndex].DataBoundItem;
                Frm_CompraProdutoManutencao frm = new Frm_CompraProdutoManutencao(compraSelecionada.Id, repository);
                Hide();
                frm.ShowDialog();

                Show();
                AtualizarGrid();

            }

        }
    }
}
