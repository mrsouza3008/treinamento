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
    public partial class Frm_FornecedorLista : Form
    {
        public RepositoryFornecedor repositoryfornecedor = new RepositoryFornecedor();

        public List<ClassFornecedor> Fornecedores { get; set; }

        public Frm_FornecedorLista()
        {
            InitializeComponent();
            Initialize();
        }

        private void AtualizarGrid()
        {
            Fornecedores = repositoryfornecedor.Obter().ToList();
            dGrid_Fornecedores.DataSource = null;
            dGrid_Fornecedores.DataSource = Fornecedores.OrderBy(a => a.NomeDoFornecedor).ToList();
        }

        public void Initialize()
        {
            Fornecedores = new List<ClassFornecedor>();
            dGrid_Fornecedores.AutoGenerateColumns = false;
            AtualizarGrid();

        }

        private void Bt_Incluir_Click(object sender, EventArgs e)
        {
            Frm_FornecedorManutencao frm = new Frm_FornecedorManutencao(0, repositoryfornecedor);
            Hide();
            frm.ShowDialog();
            Show();
            AtualizarGrid();
        }

        private void DGrid_Fornecedores_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dGrid_Fornecedores.Columns[e.ColumnIndex].Name == "bt_Editar") // Editar
            {
                ClassFornecedor itemSelecionado = (ClassFornecedor)dGrid_Fornecedores.Rows[e.RowIndex].DataBoundItem;

                Frm_FornecedorManutencao frm = new Frm_FornecedorManutencao(itemSelecionado.Id, repositoryfornecedor);

                Hide();
                frm.ShowDialog();

                Show();
                AtualizarGrid();

            }
            if (dGrid_Fornecedores.Columns[e.ColumnIndex].Name == "bt_Apagar") // Editar
            {
                ClassFornecedor itemSelecionado = (ClassFornecedor)dGrid_Fornecedores.Rows[e.RowIndex].DataBoundItem;

                repositoryfornecedor.Apagar(itemSelecionado.Id);
                AtualizarGrid();

            }
        }
    }
}
