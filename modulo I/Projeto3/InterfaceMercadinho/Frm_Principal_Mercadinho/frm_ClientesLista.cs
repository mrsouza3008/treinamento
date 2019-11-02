﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Mercadinho;
using Mercadinho_INTERFACE;


namespace Frm_Principal_Mercadinho
{
    public partial class Frm_ListaClientes : Form
     {

        public RepositoryCliente repository = new RepositoryCliente();

        public List<ClassCliente> Clientes { get; set; }

        public Frm_ListaClientes()
        {
            InitializeComponent();
            Initialize();
        }

        private void AtualizarGrid()
        {
            Clientes = repository.Obter().ToList();
            dbGrid_Clientes.DataSource = null;
            dbGrid_Clientes.DataSource = Clientes.OrderBy(a => a.NomeDoCliente).ToList();

        }

        public void Initialize()
        {
            Clientes = new List<ClassCliente>();
            dbGrid_Clientes.AutoGenerateColumns = false;
            AtualizarGrid();
        }

        private void Bt_IncluirCliente_Click(object sender, EventArgs e)
        {
            Frm_ClientesManutencao frm = new Frm_ClientesManutencao();
            Hide();
            frm.ShowDialog();
            repository.Inserir(frm.ClienteManutencao);
            Show();
            AtualizarGrid();
        }
    }
}
