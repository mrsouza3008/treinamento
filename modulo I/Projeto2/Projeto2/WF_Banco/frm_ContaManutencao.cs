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
    public partial class frm_ContaManutencao : Form
    {
        public ContaRepository ContaRepository { get; set; }
        public ClienteRepository ClienteRepository { get; set; }
        public BancoRepository BancoRepository { get; set;}
        public Conta Conta { get; set; }

        public frm_ContaManutencao(int id)
        {
            InitializeComponent();

            ContaRepository = new ContaRepository();
            ClienteRepository = new ClienteRepository();
            BancoRepository = new BancoRepository();

            PreencherComboCliente();

            PreencherComboBanco();

            Obter(id);
         }

        private void Obter(int id)
        {
            Conta = ContaRepository.Obter(id);

            if (Conta == null) // Então é novo
            {
                Conta = new Conta();
            }
            else // Editar conta existente
            {
                combo_Banco.SelectedValue = Conta.BancoId;
                combo_Banco.Refresh();

                combo_Cliente.SelectedValue = Conta.ClientId;
                combo_Cliente.Refresh();

                txt_Agencia.Text = Conta.Agencia;
                txt_ContaCorrente.Text = Conta.ContaCorrente;
                txt_Limite.Text = Conta.Limite.ToString();
                txt_Saldo.Text = Conta.Saldo.ToString();
            }
        }
        private void Salvar()
            {
                if (CadastroEhValido())
                {
                    Conta.Agencia = txt_Agencia.Text;
                    Conta.ContaCorrente = txt_ContaCorrente.Text;
                    Conta.Limite = Convert.ToDecimal(txt_Limite.Text);
                    Conta.Saldo = Convert.ToDecimal(txt_Saldo.Text);

                    var idCliente = ((Cliente)combo_Cliente.SelectedItem).Id;
                    var idBanco = ((Banco)combo_Banco.SelectedItem).Id;

                    Conta.ClientId = idCliente;
                    Conta.BancoId = idBanco;

                    if (Conta.Id == 0)
                    {
                        ContaRepository.Inserir(Conta);
                        MessageBox.Show("Cadastro Incluido com sucesso", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        ContaRepository.Editar(Conta);
                        MessageBox.Show("Cadastro Alterado com sucesso", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    Close();
                }
         }

            private bool CadastroEhValido()
            {
                if (string.IsNullOrEmpty(txt_Agencia.Text))
                {
                    MessageBox.Show("Necessário informar a agencia!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }

                if (string.IsNullOrEmpty(txt_ContaCorrente.Text))
                {
                    MessageBox.Show("Necessário informar a conta corrente!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }

                if (string.IsNullOrEmpty(txt_Limite.Text))
                {
                    MessageBox.Show("Necessário informar o limite!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }

                if (string.IsNullOrEmpty(txt_Saldo.Text))
                {
                    MessageBox.Show("Necessário informar o saldo!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
            MessageBox.Show("Cadastro Válido! Comentar essa linha depois", "OK", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return true;

            }

            private void PreencherComboCliente()
            {
                combo_Cliente.DisplayMember = "NomeTitular";
                combo_Cliente.ValueMember = "Id";

                combo_Cliente.DataSource = ClienteRepository.Obter();

                combo_Cliente.SelectedValue = -1;
            }

        private void PreencherComboBanco()
        {
            combo_Banco.DisplayMember = "NomeDoBanco";
            combo_Banco.ValueMember = "Id";
           
            combo_Banco.DataSource = BancoRepository.Obter();
            
            combo_Banco.SelectedValue = -1;
        }


        private void Btn_Salvar_Click(object sender, EventArgs e)
        {
            Salvar();
        }
    }
}
