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
    public partial class TabelaCompromissoControl : UserControl
    {
        public TabelaCompromissoControl()
        {
            InitializeComponent();

            ConfigurarColunas();

            grid.ConfigurarGridZebrado();

            grid.ConfigurarGridSomenteLeitura();
        }

        private void ConfigurarColunas()
        {
            DataGridViewColumn[] colunas = new DataGridViewColumn[]
                        {
                new DataGridViewTextBoxColumn
                {
                    Name = "id",
                    HeaderText = "Id"
                },
                new DataGridViewTextBoxColumn
                {
                    Name = "assunto",
                    HeaderText = "Assunto"
                },
                new DataGridViewTextBoxColumn
                {
                    Name = "data",
                    HeaderText = "Data"
                },
                        };

            grid.Columns.AddRange(colunas);
        }

        public void AtualizarRegistros(List<Compromisso> compromisssos)
        {
            grid.Rows.Clear();

            foreach (Compromisso compromisso in compromisssos)
            {
                grid.Rows.Add(compromisso.id, compromisso.assunto, compromisso.data);
            }
        }

        public int ObterIdSelecionado()
        {
            int id = 0;

            try
            {
                id = Convert.ToInt32(grid.Rows[0].Cells[0].Value);
            }
            catch { id = -1; }

            return id;
        }
    }
}
