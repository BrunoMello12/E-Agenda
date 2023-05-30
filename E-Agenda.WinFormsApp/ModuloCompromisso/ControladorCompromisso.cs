using E_Agenda.WinFormsApp.Compartilhado;
using E_Agenda.WinFormsApp.ModuloContato;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Agenda.WinFormsApp.ModuloCompromisso
{
    public partial class ControladorCompromisso : ControladorBase
    {
        private RepositorioCompromisso repositorioCompromisso;
        private TabelaCompromissoControl tabelaCompromisso;
        private RepositorioContato repositorioContato;

        public ControladorCompromisso(RepositorioCompromisso repositorioCompromisso, RepositorioContato repositorioContato)
        {
            this.repositorioCompromisso = repositorioCompromisso;
            this.repositorioContato = repositorioContato;
        }

        public override string ToolTipInserir => "Inserir novo Compromisso"; 

        public override string ToolTipEditar => "Editar um Compromisso existente"; 

        public override string ToolTipExcluir => "Excluir um Compromisso existente";

        public override string ToolTipFiltrar => "Filtrar Compromissos";

        public override bool FiltrarHabilitado => true;

        public override void Inserir()
        {
            List<Contato> contatos = new List<Contato>();
            TelaCompromisso telaCompromisso = new TelaCompromisso(contatos);

            contatos = repositorioContato.SelecionarTodos();

            DialogResult opcaoEscolhida = telaCompromisso.ShowDialog();

            if(opcaoEscolhida == DialogResult.OK)
            {
                Compromisso compromisso = telaCompromisso.ObterCompromisso();

                repositorioCompromisso.Inserir(compromisso);

                CarregarCompromissos();
            }
        }

        public override void Editar()
        {
            Compromisso compromissoSelecionado = ObterCompromissoSelecionado();

            if(compromissoSelecionado == null )
            {
                MessageBox.Show("Selecione um compromisso primeiro!", "Edição de Compromissos",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            List<Contato> contatos = repositorioContato.SelecionarTodos();
            TelaCompromisso telaCompromisso = new TelaCompromisso(contatos);

            telaCompromisso.ConfigurarTela(compromissoSelecionado);

            DialogResult opcaoEscolhida = telaCompromisso.ShowDialog();

            if (opcaoEscolhida == DialogResult.OK)
            {
                Compromisso compromisso = telaCompromisso.ObterCompromisso();

                repositorioCompromisso.Editar(compromisso.id, compromisso);

                CarregarCompromissos();
            }
        }

        private Compromisso ObterCompromissoSelecionado()
        {
            int id = tabelaCompromisso.ObterIdSelecionado();

            return repositorioCompromisso.SelecionarPorId(id);
        }

        public override void Excluir()
        {
            Compromisso compromissoSelecionado = ObterCompromissoSelecionado();

            if (compromissoSelecionado == null)
            {
                MessageBox.Show("Selecione um compromisso primeiro!", "Exclusão de Compromissos",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            DialogResult opcaoEscolhida =
                MessageBox.Show(
                    $"Deseja excluir o compromisso {compromissoSelecionado.assunto}?",
                    "Exclusão de Compromissos",
                    MessageBoxButtons.OKCancel,
                    MessageBoxIcon.Question);

            if(opcaoEscolhida == DialogResult.OK )
            {
                repositorioCompromisso.Excluir(compromissoSelecionado);

                CarregarCompromissos();
            }
        }

        public override void Filtrar()
        {
            TelaFiltro telaFiltro = new TelaFiltro();

            DialogResult opcaoEscolhida = telaFiltro.ShowDialog();

            if (opcaoEscolhida == DialogResult.OK)
            {

                StatusCompromissosEnum status = telaFiltro.StatusSelecionado;
                List<Compromisso> compromissos = null;

                if (status == StatusCompromissosEnum.Futuros)
                {
                    compromissos = repositorioCompromisso.SelecionarCompromissosFuturos();
                }
                else if (status == StatusCompromissosEnum.Passados)
                {
                    compromissos = repositorioCompromisso.SelecionarCompromissosPassados();
                }
                else
                    compromissos = repositorioCompromisso.SelecionarTodos();

                CarregarCompromissos(compromissos);

                TelaPrincipalForm1.instancia.AtualizarRodape($"Visualizando {compromissos.Count} compromissos");
            }
        }

        private void CarregarCompromissos(List<Compromisso> compromissos)
        {
            tabelaCompromisso.AtualizarRegistros(compromissos);
        }

        public override UserControl ObterListagem()
        {
            if(tabelaCompromisso == null)
                tabelaCompromisso = new TabelaCompromissoControl();

            CarregarCompromissos();

            return tabelaCompromisso;
        }

        private void CarregarCompromissos()
        {
            List<Compromisso> compromissos = repositorioCompromisso.SelecionarTodos();

            tabelaCompromisso.AtualizarRegistros(compromissos);
        }

        public override string ObterTipoCadastro()
        {
            return "Cadastro de Compromissos";
        }
    }
}
