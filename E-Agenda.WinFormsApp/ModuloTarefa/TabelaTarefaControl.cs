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
    public partial class TabelaTarefaControl : UserControl
    {
        public TabelaTarefaControl()
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
                    Name = "titulo",
                    HeaderText = "Título"
                },
                new DataGridViewTextBoxColumn
                {
                    Name = "prioridade",
                    HeaderText = "Prioridade"
                },
                new DataGridViewTextBoxColumn
                {
                    Name = "percentualConcluido",
                    HeaderText = "% Concluído"
                },
                new DataGridViewTextBoxColumn
                {
                    Name = "dataConclusao",
                    HeaderText = "Data Conclusão"
                },
                        };

            grid.Columns.AddRange(colunas);
        }

        public void AtualizarRegistros(List<Tarefa> tarefas)
        {
            grid.Rows.Clear();

            foreach(Tarefa tarefa in tarefas)
            {
                grid.Rows.Add(tarefa.id, tarefa.titulo, tarefa.prioridade, tarefa.percentualConcluido, tarefa.data);
            }
        }

        public int ObterIdSelecionado()
        {
            int id = 0;

            try
            {
                id = Convert.ToInt32(grid.SelectedRows[0].Cells[0].Value);
            }
            catch 
            { 
                id = -1;
            }

            return id;
        }
    }
}
