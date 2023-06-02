using E_Agenda.Dominio.ModuloCompromisso;
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

namespace E_Agenda.WinFormsApp.ModuloCompromisso
{
    public partial class TelaFiltro : Form
    {
        public TelaFiltro()
        {
            InitializeComponent();

            this.ConfigurarDialog();
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
    }
}
