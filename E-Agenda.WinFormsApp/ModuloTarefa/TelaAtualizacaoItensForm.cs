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
    public partial class TelaAtualizacaoItensForm : Form
    {
        public TelaAtualizacaoItensForm(Tarefa tarefaSelecionada)
        {
            InitializeComponent();

            this.ConfigurarDialog();

            ConfigurarTela(tarefaSelecionada);
        }

        public List<ItemTarefa> ObterItensMarcados()
        {
            return listItens.CheckedItems.Cast<ItemTarefa>().ToList();
        }

        public List<ItemTarefa> ObterItensPendentes()
        {
            return listItens.Items.Cast<ItemTarefa>()
                .Except(ObterItensMarcados())
                .ToList();
        }

        private void ConfigurarTela(Tarefa tarefaSelecionada)
        {
            txtId.Text = tarefaSelecionada.id.ToString();
            txtTitulo.Text = tarefaSelecionada.titulo;

            listItens.Items.AddRange(tarefaSelecionada.items.ToArray());
        }
    }
}
