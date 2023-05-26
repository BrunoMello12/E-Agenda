using E_Agenda.WinFormsApp.Compartilhado;
using E_Agenda.WinFormsApp.ModuloContato;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace E_Agenda.WinFormsApp.ModuloCompromisso
{
    public partial class TelaCompromisso : Form
    {

        public TelaCompromisso(List<Contato> contatos)
        {
            InitializeComponent();

            this.ConfigurarDialog();

            CarregarContatos(contatos);
        }

        private void CarregarContatos(List<Contato> contatos)
        {
            foreach (Contato contato in contatos)
            {
                cmbContatos.Items.Add(contato);
            }
        }

        public Compromisso ObterCompromisso()
        {
            int id = Convert.ToInt32(txtId.Text);
            DateTime data = txtData.Value;
            TimeSpan horarioInicio = txtHorarioInicio.Value.TimeOfDay;
            TimeSpan horarioFinal = txtHorarioTermino.Value.TimeOfDay;
            string assunto = txtAssunto.Text;
            TipoLocalEnum tipo = rdbPresencial.Checked ? TipoLocalEnum.Presencial : TipoLocalEnum.Online;

            Contato contato = cmbContatos.SelectedItem as Contato;

            string local;

            if (rdbPresencial.Checked)
                local = txtLocalPresencial.Text;
            else
                local = txtLocalRemoto.Text;


            return new Compromisso(data, horarioInicio, horarioFinal, assunto, contato, tipo, local, id);
        }

        public void ConfigurarTela(Compromisso compromissoSelecionado)
        {
            txtId.Text = compromissoSelecionado.id.ToString();
            txtAssunto.Text = compromissoSelecionado.assunto;
            txtData.Value = compromissoSelecionado.data.Date;
            txtHorarioInicio.Value = DateTime.Now.Date.Add(compromissoSelecionado.horaInicio);
            txtHorarioTermino.Value = DateTime.Now.Date.Add(compromissoSelecionado.horaTermino);

            if (compromissoSelecionado.contatoCompromisso != null)
            {
                ckbSelecionarContato.Checked = true;
                cmbContatos.SelectedItem = compromissoSelecionado.contatoCompromisso;
            }

            if (compromissoSelecionado.tipoLocal == TipoLocalEnum.Presencial)
            {
                rdbPresencial.Checked = true;
                txtLocalPresencial.Text = compromissoSelecionado.localPresencial;
            }

            else
            {
                rdbRemoto.Checked = true;
                txtLocalRemoto.Text = compromissoSelecionado.localOnline;
            }
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            Compromisso compromisso = ObterCompromisso();

            string[] erros = compromisso.Validar();

            if (erros.Length > 0)
            {
                TelaPrincipalForm1.instancia.AtualizarRodape(erros[0]);

                DialogResult = DialogResult.None;
            }
        }

        private void rdbRemoto_CheckedChanged(object sender, EventArgs e)
        {
            txtLocalRemoto.Enabled = true;
            txtLocalPresencial.Enabled = false;
            txtLocalPresencial.Text = "";
        }

        private void rdbPresencial_CheckedChanged(object sender, EventArgs e)
        {
            txtLocalRemoto.Enabled = false;
            txtLocalPresencial.Enabled = true;
            txtLocalRemoto.Text = "";
        }

        private void ckbSelecionarContato_CheckedChanged(object sender, EventArgs e)
        {
            cmbContatos.Enabled = !cmbContatos.Enabled;
            cmbContatos.SelectedIndex = -1;
        }
    }
}
