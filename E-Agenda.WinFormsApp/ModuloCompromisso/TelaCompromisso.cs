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
        private Compromisso compromisso;
        private RepositorioContato repositorioContato;

        public TelaCompromisso(RepositorioContato repositorioContato)
        {
            InitializeComponent();

            this.repositorioContato = repositorioContato;
        }

        public Compromisso Compromisso
        {
            get { return compromisso; }
            set { txtAssunto.Text = value.assunto; txtHorarioInicio.Value = value.horaInicio; txtHorarioTermino.Value = value.horaTermino; txtData.Value = value.data; }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime data = txtData.Value;
            DateTime horarioInicio = txtHorarioInicio.Value;
            DateTime horarioFinal = txtHorarioTermino.Value;
            string assunto = txtAssunto.Text;
            string local = txtLocalPresencial.Text;
            local = txtLocalPresencial.Text;
            Contato contato = comboBox1.SelectedItem as Contato;

            compromisso = new Compromisso(data, horarioInicio, horarioFinal, assunto, contato);

            if (txtId.Text != "0")
                compromisso.id = int.Parse(txtId.Text);
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
                comboBox1.Enabled = true;

            ListarContatos();
        }

        private void ListarContatos()
        {
            comboBox1.Items.Clear();

            comboBox1.Items.AddRange(repositorioContato.SelecionarTodos().ToArray());
        }
    }
}
