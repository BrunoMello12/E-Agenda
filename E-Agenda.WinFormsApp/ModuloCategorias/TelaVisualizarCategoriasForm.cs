using E_Agenda.Dominio.ModuloCategorias;
using E_Agenda.Dominio.ModuloDespesas;
using E_Agenda.WinFormsApp.Compartilhado;
using E_Agenda.WinFormsApp.ModuloDespesas;
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
    public partial class TelaVisualizarCategoriasForm : Form
    {
        public TelaVisualizarCategoriasForm(List<Despesa> despesasPorCategoria)
        {
            InitializeComponent();

            this.ConfigurarDialog();

            AtualizarLista(despesasPorCategoria);
        }

        private void AtualizarLista(List<Despesa> lista)
        {
            listDespesas.Items.Clear();

            foreach (Despesa despesa in lista)
            {
                listDespesas.Items.Add(despesa);
            }
        }

        public void CarregarLabel(Categoria categoria)
        {
            label2.Text = categoria.titulo.ToString();
        }
    }
}
