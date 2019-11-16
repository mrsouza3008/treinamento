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
        public RepositoryProduto repository = new RepositoryProduto();
        public List<ClassProduto> Produtos { get; set; }
        public Frm_CompraProdutoLista()
        {
            InitializeComponent();
        }

        private void Bt_Incluir_Click(object sender, EventArgs e)
        {
            Frm_CompraProdutoManutencao frm = new Frm_CompraProdutoManutencao();
            Hide();
            //frm.ShowDialog;
            Show();
                  
        }

  
    }
}
