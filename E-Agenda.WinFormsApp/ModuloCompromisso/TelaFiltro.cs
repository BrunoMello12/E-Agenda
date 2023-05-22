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
    public partial class TelaFiltro : Form
    {
        public TelaFiltro()
        {
            InitializeComponent();
        }

        public StatusCompromissosEnum StatusSelecionado
        {
            get
            {
                if (rdbCompromissosPassados.Checked)
                    return StatusCompromissosEnum.Passados;

                else if (rdbCompromissosFuturos.Checked)
                    return StatusCompromissosEnum.Futuros;

                else
                    return StatusCompromissosEnum.Todos;
            }
        }

        public DateTime DataInicial
        {
            get { return dateTimePicker1.Value; }
        }

        public DateTime DataFinal
        {
            get { return dateTimePicker2.Value; }
        }

        private void rdbCompromissosTodos_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbCompromissosTodos.Checked)
            {
                FiltroFuturo.Enabled = false;
            }
        }

        private void rdbCompromissosPassados_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbCompromissosPassados.Checked)
            {
                FiltroFuturo.Enabled = false;
            }
        }

        private void rdbCompromissosFuturos_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbCompromissosFuturos.Checked)
            {
                FiltroFuturo.Enabled = true;
            }
        }
    }
}
