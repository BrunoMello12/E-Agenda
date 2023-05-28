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

namespace E_Agenda.WinFormsApp.ModuloContato
{
    public partial class TabelaContatoControl : UserControl
    {
        public TabelaContatoControl()
        {
            InitializeComponent();

            ConfigurarColunas();

            grid.ConfigurarGridZebrado();

            grid.ConfigurarGridSomenteLeitura();
        }

        public void AtualizarRegistros(List<Contato> contatos)
        {
            grid.Rows.Clear();

            foreach(Contato contato in contatos)
            {
                grid.Rows.Add(contato.id, contato.nome, contato.empresa);
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
                    Name = "nome",
                    HeaderText = "Nome"
                },
                new DataGridViewTextBoxColumn
                {
                    Name = "empresa",
                    HeaderText = "Empresa"
                },
            };

            grid.Columns.AddRange(colunas);
        }
    }
}
