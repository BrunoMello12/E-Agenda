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

namespace E_Agenda.WinFormsApp.ModuloTarefa
{
    public partial class TelaTarefaForm : Form
    {
        private Tarefa tarefa;

        public TelaTarefaForm()
        {
            InitializeComponent();
        }

        public Tarefa Tarefa
        {
            get { return tarefa; }
            set { txtId.Text = value.id.ToString(); txtTitulo.Text = value.titulo; /*txtPrioridade.Text = value.prioridade;*/ }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string titulo = txtTitulo.Text;
            string prioridade = "";

            tarefa = new Tarefa(titulo, prioridade);

            if (txtId.Text != "0")
                tarefa.id = int.Parse(txtId.Text);
        }
    }
}
