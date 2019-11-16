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
    public partial class Frm_FornecedorManutencao : Form
    {

        public RepositoryFornecedor repositoryFornecedor { get; private set; }

        public ClassFornecedor FornecedorManutencao { get; set; }

        public Frm_FornecedorManutencao(int id, RepositoryFornecedor repFornecedor)
        {
            InitializeComponent();
            repositoryFornecedor = repFornecedor;
            Obter(id);
        }

        private void Obter(int id)
        {
            FornecedorManutencao = repositoryFornecedor.Obter(id);

            if (FornecedorManutencao == null)
            {
                FornecedorManutencao = new ClassFornecedor();
            }
            else
            {
                txt_NomeDoFornecedor.Text = FornecedorManutencao.NomeDoFornecedor;
                ck_Ativo.Checked = FornecedorManutencao.Ativo ? true : false;
            }

        }

        private bool CadastroEhValido()
        {
            if (string.IsNullOrEmpty(txt_NomeDoFornecedor.Text))
            {
                MessageBox.Show("Informe o nome do Fornecedor!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private void Bt_Salvar_Click(object sender, EventArgs e)
        {
            if (CadastroEhValido())
            {
                FornecedorManutencao.NomeDoFornecedor = txt_NomeDoFornecedor.Text;
                FornecedorManutencao.Ativo = ck_Ativo.Checked ? true : false;

                if (FornecedorManutencao.Id == 0)
                {
                    repositoryFornecedor.Inserir(FornecedorManutencao);
                }
                else
                {
                    repositoryFornecedor.Editar(FornecedorManutencao);
                }
                Close();
            }
        }
    }
}
