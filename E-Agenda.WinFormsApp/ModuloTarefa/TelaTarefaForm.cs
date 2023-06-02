using E_Agenda.Dominio.ModuloTarefa;
using E_Agenda.WinFormsApp.Compartilhado;
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

        public TelaTarefaForm()
        {
            InitializeComponent();

            this.ConfigurarDialog();

            CarregarPrioridades();
        }

        public void CarregarPrioridades()
        {
            StatusPrioridadeEnum[] prioridades = Enum.GetValues<StatusPrioridadeEnum>();

            foreach (StatusPrioridadeEnum prioridade in prioridades)
            {
                cmbPrioridade.Items.Add(prioridade);
            }
        }

        public Tarefa ObterTarefa()
        {
            int id = int.Parse(txtId.Text);
            string titulo = txtTitulo.Text;
            DateTime data = txtData.Value;

            StatusPrioridadeEnum prioridade = (StatusPrioridadeEnum)cmbPrioridade.SelectedItem;

            return new Tarefa(id, titulo, prioridade, data);
        }

        public void ConfigurarTela(Tarefa tarefaSelecionada)
        {
            txtId.Text = tarefaSelecionada.id.ToString();
            txtTitulo.Text = tarefaSelecionada.titulo;
            txtData.Value = tarefaSelecionada.data.Date;
            cmbPrioridade.Text = tarefaSelecionada.prioridade.ToString();
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            Tarefa tarefa = ObterTarefa();

            string[] erros = tarefa.Validar();

            if (erros.Length > 0)
            {
                TelaPrincipalForm1.instancia.AtualizarRodape(erros[0]);

                DialogResult = DialogResult.None;
            }
        }
    }
}
