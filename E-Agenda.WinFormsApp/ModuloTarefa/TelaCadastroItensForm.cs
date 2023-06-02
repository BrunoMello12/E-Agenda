using E_Agenda.Dominio.ModuloTarefa;
using E_Agenda.WinFormsApp.Compartilhado;
using System.Linq;

namespace E_Agenda.WinFormsApp.ModuloTarefa
{
    public partial class TelaCadastroItensForm : Form
    {

        public TelaCadastroItensForm(Tarefa tarefaSelecionada)
        {
            InitializeComponent();

            this.ConfigurarDialog();

            ConfigurarTela(tarefaSelecionada);
        }

        private void ConfigurarTela(Tarefa tarefaSelecionada)
        {
            txtId.Text = tarefaSelecionada.id.ToString();
            txtTitulo.Text = tarefaSelecionada.titulo;

            listItens.Items.AddRange(tarefaSelecionada.items.ToArray());
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            string titulo = txtTituloItem.Text;

            ItemTarefa itemTarefa = new ItemTarefa(titulo);

            listItens.Items.Add(itemTarefa);
        }

        public List<ItemTarefa> ObterItensCadastrados()
        {
            return listItens.Items.Cast<ItemTarefa>().ToList();
        }
    }
}




