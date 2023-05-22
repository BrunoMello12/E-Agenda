using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace E_Agenda.WinFormsApp.ModuloContato
{
    public partial class TelaContatoForm : Form
    {
        private Contato contato;

        public TelaContatoForm()
        {
            InitializeComponent();
        }

        public Contato Contato
        {
            get { return contato; }
            set
            {
                txtId.Text = value.id.ToString(); txtNome.Text = value.nome;
                txtTelefone.Text = value.telefone; txtEmpresa.Text = value.empresa; txtEmail.Text = value.email; txtCargo.Text = value.cargo;
            }
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            string nome = txtNome.Text;
            string empresa = txtEmpresa.Text;
            string cargo = txtCargo.Text;
            string email = txtEmail.Text;
            string telefone = txtTelefone.Text;

            contato = new Contato(nome, empresa, telefone, email, cargo);

            if (txtId.Text != "0")
                contato.id = int.Parse(txtId.Text);
        }
    }
}
