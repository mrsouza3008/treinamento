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
    public partial class frm_BancosManutencao : Form
    {

        public Banco BancoManutencao { get; set; }
        public frm_BancosManutencao()
        {
            InitializeComponent();
        }

        private void Btn_Salvar_Click(object sender, EventArgs e)
        {
            BancoManutencao = new Banco
            {
                //Id = Guid.NewGuid(),
                //Id = 1,
                CodigoDoBanco = Convert.ToInt32(txt_CodigoDoBanco.Text),
                NomeDoBanco = txt_NomeDoBanco.Text

            };
            Close();

        }

           
        
    }
}
