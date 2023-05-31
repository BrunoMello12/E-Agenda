using E_Agenda.WinFormsApp.Compartilhado;
using E_Agenda.WinFormsApp.ModuloCategorias;
using E_Agenda.WinFormsApp.ModuloCompromisso;
using E_Agenda.WinFormsApp.ModuloContato;
using E_Agenda.WinFormsApp.ModuloDespesas;
using E_Agenda.WinFormsApp.ModuloTarefa;

namespace E_Agenda.WinFormsApp
{
    public partial class TelaPrincipalForm1 : Form
    {
        private ControladorBase controlador;
        private IRepositorioContato repositorioContato = new RepositorioContatoEmArquivo();
        private IRepositorioTarefa repositorioTarefa = new RepositorioTarefaEmArquivo();
        private IRepositorioCompromisso repositorioCompromisso = new RepositorioCompromissoEmArquivo();
        private IRepositorioDespesas repositorioDespesa = new RepositorioDespesasEmArquivo();
        private IRepositorioCategoria repositorioCategorias = new RepositorioCategoriaEmArquivo();

        private static TelaPrincipalForm1 telaPrincipal;

        public TelaPrincipalForm1()
        {
            InitializeComponent();

            telaPrincipal = this;
        }

        public void AtualizarRodape(string mensagem)
        {
            lblRodape.Text = mensagem;
        }


        public static TelaPrincipalForm1 instancia
        {
            get
            {
                if (telaPrincipal == null)
                    telaPrincipal = new TelaPrincipalForm1();

                return telaPrincipal;
            }
        }

        private void contatosMenuItem_Click(object sender, EventArgs e)
        {
            controlador = new ControladorContato(repositorioContato);

            ConfigurarTelaPrincipal(controlador);
        }

        private void tarefasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            controlador = new ControladorTarefa(repositorioTarefa);

            ConfigurarTelaPrincipal(controlador);
        }

        private void compromissosMenuItem_Click(object sender, EventArgs e)
        {
            controlador = new ControladorCompromisso(repositorioCompromisso, repositorioContato);

            ConfigurarTelaPrincipal(controlador);
        }

        private void desespesasMenuItem_Click(object sender, EventArgs e)
        {
            controlador = new ControladorDespesa(repositorioDespesa, repositorioCategorias);

            ConfigurarTelaPrincipal(controlador);
        }

        private void categoriasMenuItem_Click(object sender, EventArgs e)
        {
            controlador = new ControladorCategorias(repositorioCategorias, repositorioDespesa);

            ConfigurarTelaPrincipal(controlador);
        }

        private void ConfigurarTelaPrincipal(ControladorBase controlador)
        {
            lblTipoCadastro.Text = controlador.ObterTipoCadastro();

            ConfigurarTooTips(controlador);

            ConfigurarListagem(controlador);

            ConfigurarBotoes(controlador);
        }

        private void ConfigurarListagem(ControladorBase controlador)
        {
            UserControl listagem = controlador.ObterListagem();

            listagem.Dock = DockStyle.Fill;

            pnlRegistros.Controls.Clear();

            pnlRegistros.Controls.Add(listagem);
        }

        private void ConfigurarBotoes(ControladorBase controlador)
        {
            btnInserir.Enabled = controlador.InserirHabilitado;
            btnEditar.Enabled = controlador.EditarHabilitado;
            btnExcluir.Enabled = controlador.ExcluirHabilitado;
            btnFiltrar.Enabled = controlador.FiltrarHabilitado;
            btnAdicionar.Enabled = controlador.AdicionarItensHabilitado;
            btnAtualizar.Enabled = controlador.ConcluirItensHabilitado;
            btnVisualizar.Enabled = controlador.VisualizarCategoriasDespesas;
        }

        private void ConfigurarTooTips(ControladorBase controlador)
        {
            btnInserir.ToolTipText = controlador.ToolTipInserir;
            btnEditar.ToolTipText = controlador.ToolTipEditar;
            btnExcluir.ToolTipText = controlador.ToolTipExcluir;
            btnFiltrar.ToolTipText = controlador.ToolTipFiltrar;
            btnAdicionar.ToolTipText = controlador.ToolTipAdicionar;
            btnAtualizar.ToolTipText = controlador.ToolTipAtualizar;
            btnVisualizar.ToolTipText = controlador.ToolTipVisualizarCategorias;
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

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            if (controlador == null) return;

            controlador.Adicionar();
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            if (controlador == null) return;

            controlador.Atualizar();
        }

        private void btnVisualizar_Click(object sender, EventArgs e)
        {
            if(controlador == null) return;

            controlador.Visualizar();
        }
    }
}