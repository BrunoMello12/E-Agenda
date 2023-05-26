using E_Agenda.WinFormsApp.ModuloContato;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace E_Agenda.WinFormsApp.ModuloTarefa
{
    public partial class TelaTarefaForm : Form
    {
        private Tarefa tarefa;
        private string prioridade;

        public TelaTarefaForm()
        {
            InitializeComponent();
        }

        public Tarefa Tarefa
        {
            get { return tarefa; }
            set { txtId.Text = value.id.ToString(); txtTitulo.Text = value.titulo; }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string titulo = txtTitulo.Text;

            if (rdbPrioridadeAlta.Checked)
                prioridade = rdbPrioridadeAlta.Text;
            else if (rdbPrioridadeBaixa.Checked)
                prioridade = rdbPrioridadeBaixa.Text;
            else if (rdbPrioridadeMedia.Checked)
                prioridade = rdbPrioridadeMedia.Text;

            DateTime data = dateTimePicker1.Value;

            tarefa = new Tarefa(titulo, prioridade, data);

            if (txtId.Text != "0")
                tarefa.id = int.Parse(txtId.Text);
        }
        
    }
}
