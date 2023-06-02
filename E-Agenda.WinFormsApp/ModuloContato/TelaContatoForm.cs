
using E_Agenda.Dominio.ModuloContato;
using E_Agenda.WinFormsApp.ModuloTarefa;
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
        public TelaContatoForm()
        {
            InitializeComponent();
        }

        public Contato ObterContato()
        {
            int id = int.Parse(txtId.Text);
            string nome = txtNome.Text;
            string empresa = txtEmpresa.Text;
            string telefone = txtTelefone.Text;
            string email = txtEmail.Text;
            string cargo = txtCargo.Text;

            return new Contato(nome,empresa,telefone,email,cargo, id);
        }

        public void ConfigurarTela(Contato contatoSelecionado)
        {
            txtId.Text = contatoSelecionado.id.ToString();
            txtNome.Text = contatoSelecionado.nome;
            txtEmpresa.Text = contatoSelecionado.empresa;
            txtTelefone.Text = contatoSelecionado.telefone;
            txtEmail.Text = contatoSelecionado.email;
            txtCargo.Text = contatoSelecionado.cargo;
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            Contato contato = ObterContato();

            string[] erros = contato.Validar();

            if(erros.Length > 0)
            {
                TelaPrincipalForm1.instancia.AtualizarRodape(erros[0]);

                DialogResult = DialogResult.None;
            }
        }
    }
}
