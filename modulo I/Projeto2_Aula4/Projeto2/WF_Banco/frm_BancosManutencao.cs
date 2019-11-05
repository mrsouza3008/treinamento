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
    public partial class frm_BancosManutencao: Form
    {
        public BancoRepository BancoRepository { get; set; }

        public Banco Banco { get; set; }
        public frm_BancosManutencao(int id)
        {
            InitializeComponent();
            BancoRepository = new BancoRepository();
            Obter(id);
        }

        private void Obter(int id)
        {
            Banco = BancoRepository.Obter(id);

            if (Banco == null) // Então é novo
            {
                Banco = new Banco();
            }
            else // Editar banco existente
            {
                txt_CodigoDoBanco.Text = Banco.CodigoDoBanco.ToString();
                txt_NomeDoBanco.Text = Banco.NomeDoBanco;

            }
        }

        private void Btn_Salvar_Click(object sender, EventArgs e)
        {

            if (Banco.Id != 0)
            {
                BancoRepository.Editar(Banco);
                MessageBox.Show("Alterado com sucesso", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                Banco = new Banco
                {
                    //Id = Guid.NewGuid(),
                    //Id = 1,
                    CodigoDoBanco = Convert.ToInt32(txt_CodigoDoBanco.Text),
                    NomeDoBanco = txt_NomeDoBanco.Text
                };
            }
            Close();


        }

           
        
    }
}
