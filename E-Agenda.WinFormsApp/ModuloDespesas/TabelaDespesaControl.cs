using E_Agenda.Dominio.ModuloDespesas;
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

namespace E_Agenda.WinFormsApp.ModuloDespesas
{
    public partial class TabelaDespesaControl : UserControl
    {
        public TabelaDespesaControl()
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
                    Name = "descricao",
                    HeaderText = "Descrição"
                },
                new DataGridViewTextBoxColumn
                {
                    Name = "valor",
                    HeaderText = "Valor"
                },
                new DataGridViewTextBoxColumn
                {
                    Name = "data",
                    HeaderText = "Data"
                }
            };

            grid.Columns.AddRange(colunas);
        }

        public void AtualizarRegistros(List<Despesa> despesas)
        {
            grid.Rows.Clear();

            foreach(Despesa despesa in despesas)
            {
                grid.Rows.Add(despesa.id, despesa.descricao, despesa.valor, despesa.data);
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
