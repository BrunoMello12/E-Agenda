using E_Agenda.WinFormsApp.Compartilhado;
using E_Agenda.WinFormsApp.ModuloCompromisso;
using E_Agenda.WinFormsApp.ModuloContato;
using E_Agenda.WinFormsApp.ModuloTarefa;

namespace E_Agenda.WinFormsApp
{
    public partial class TelaPrincipalForm1 : Form
    {
        private ControladorBase controlador;
        private RepositorioContato repositorioContato = new RepositorioContato();
        private RepositorioTarefa repositorioTarefa = new RepositorioTarefa();
        private RepositorioCompromisso repositorioCompromisso = new RepositorioCompromisso();

        public TelaPrincipalForm1()
        {
            InitializeComponent();
        }

        private void contatosMenuItem_Click(object sender, EventArgs e)
        {
            controlador = new ControladorContato(repositorioContato);

            btnFiltrar.Visible = false;

            ConfigurarTelaPrincipal(controlador);
        }

        private void tarefasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            controlador = new ControladorTarefa(repositorioTarefa);

            btnFiltrar.Visible = false;

            ConfigurarTelaPrincipal(controlador);
        }

        private void compromissosMenuItem_Click(object sender, EventArgs e)
        {
            controlador = new ControladorCompromisso(repositorioCompromisso, repositorioContato);

            btnFiltrar.Visible = true;

            ConfigurarTelaPrincipal(controlador);
        }

        private void ConfigurarTelaPrincipal(ControladorBase controlador)
        {
            lblTipoCadastro.Text = controlador.ObterTipoCadastro();

            ConfigurarTooTips(controlador);

            ConfigurarListagem(controlador);
        }

        private void ConfigurarListagem(ControladorBase controlador)
        {
            UserControl listagem = controlador.ObterListagem();

            listagem.Dock = DockStyle.Fill;

            pnlRegistros.Controls.Clear();

            pnlRegistros.Controls.Add(listagem);
        }

        private void ConfigurarTooTips(ControladorBase controlador)
        {
            btnInserir.ToolTipText = controlador.ToolTipInserir;
            btnEditar.ToolTipText = controlador.ToolTipEditar;
            btnExcluir.ToolTipText = controlador.ToolTipExcluir;
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            if (controlador == null) return;

            controlador.Inserir();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (controlador == null) return;

            controlador.Editar();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (controlador == null) return;

            controlador.Excluir();
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            if (controlador == null) return;

            controlador.Filtrar();
        }
    }
}