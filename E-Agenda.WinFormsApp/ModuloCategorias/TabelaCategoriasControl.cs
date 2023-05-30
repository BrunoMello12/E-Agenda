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

namespace E_Agenda.WinFormsApp.ModuloCategorias
{
    public partial class TabelaCategoriasControl : UserControl
    {
        public TabelaCategoriasControl()
        {
            InitializeComponent();

            ConfigurarColunas();

            grid.ConfigurarGridZebrado();

            grid.ConfigurarGridSomenteLeitura();
        }

        public void AtualizarRegistros(List<Categoria> categorias)
        {   
            grid.Rows.Clear();

            foreach(Categoria categoria in categorias)
            {
                grid.Rows.Add(categoria.id, categoria.titulo);
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
                }
            };

            grid.Columns.AddRange(colunas);
        }
    }
}
