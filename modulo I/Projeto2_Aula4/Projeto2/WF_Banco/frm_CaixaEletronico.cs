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
    public partial class frm_CaixaEletronico : Form
    {

        public List<Banco> ListaBancoOrigem { get; set; }
        public List<Banco> ListaBancoDestino { get; set; }
        public BancoRepository bancoRepository { get; set; }
        public ContaRepository contaRepository { get; set; }

        public frm_CaixaEletronico()
        {
            InitializeComponent();
            Initialize();
        }

        private void Initialize()
        {
            PreencherComboBancoOrigem();
            PreencherComboBancoDestino();
        }

        private void PreencherComboBancoOrigem()
        {
            cb_BancoOrigem.DisplayMember = "CodigoDoBanco";
            cb_BancoOrigem.DisplayMember = "NomeDoBanco";
            cb_BancoOrigem.ValueMember = "Id";

            cb_BancoOrigem.DataSource = bancoRepository.Obter().ToList();

            cb_BancoOrigem.SelectedValue = -1;
        }

        private void PreencherComboBancoDestino()
        {
            cb_BancoDestino.DisplayMember = "CodigoDoBanco";
            cb_BancoDestino.DisplayMember = "NomeDoBanco";
            cb_BancoDestino.ValueMember = "Id";
                    
            cb_BancoDestino.DataSource = bancoRepository.Obter().ToList();
                    
            cb_BancoDestino.SelectedValue = -1;
        }

        private void Bt_Sacar_Click(object sender, EventArgs e)
        {
            Conta ContaOrigem = new Conta();

            //fazer o que precisa aqui
            // contaRepository.RealizarSaque()
        }
    }
}
