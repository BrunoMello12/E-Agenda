using E_Agenda.Dominio.ModuloTarefa;
using E_Agenda.WinFormsApp.Compartilhado;
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
    public partial class TelaFiltroTarefaForm : Form
    {
        public TelaFiltroTarefaForm()
        {
            InitializeComponent();

            this.ConfigurarDialog();
        }

        public StatusTarefaEnum ObterFiltroTarefa()
        {
            if (rdbTarefasConcluidas.Checked)
                return StatusTarefaEnum.Concluidos;
            else if (rdbTarefasPendentes.Checked)
                return StatusTarefaEnum.Pendentes;
            else
                return StatusTarefaEnum.Todos;
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            
        }
    }
}
