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
        RepositorioCompromisso repositorioCompromisso;
        ListaCompromissoControl listagemCompromisso;
        RepositorioContato repositorioContato;

        public ControladorCompromisso(RepositorioCompromisso repositorioCompromisso, RepositorioContato repositorioContato)
        {
            this.repositorioCompromisso = repositorioCompromisso;
            this.repositorioContato = repositorioContato;
        }

        public override string ToolTipInserir { get { return "Inserir novo Compromisso"; } }

        public override string ToolTipEditar { get { return "Editar um Compromisso existente"; } }

        public override string ToolTipExcluir { get { return "Excluir um Compromisso existente"; } }

        public override void Editar()
        {
            if (repositorioCompromisso.compromissosList.Count == 0) return;

            TelaCompromisso telaCompromisso = new TelaCompromisso(repositorioContato);

            telaCompromisso.Compromisso = listagemCompromisso.ObterCompromissoSelecionado();

            DialogResult opcaoSelecionada = telaCompromisso.ShowDialog();

            if(opcaoSelecionada == DialogResult.OK)
            {
                Compromisso compromisso = telaCompromisso.Compromisso;

                repositorioCompromisso.Editar(compromisso);

                CarregarCompromissos();
            }
        }

        public override void Excluir()
        {
            if (repositorioCompromisso.compromissosList.Count == 0) return;

            Compromisso compromisso = listagemCompromisso.ObterCompromissoSelecionado();

            DialogResult opcaoSelecionada = MessageBox.Show($"Deseja mesmo excluir o compromisso {compromisso.assunto}", "Exclusão de Compromissos", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if(opcaoSelecionada == DialogResult.OK)
            {
                repositorioCompromisso.Excluir(compromisso);

                CarregarCompromissos();
            }
        }

        public override void Inserir()
        {
            TelaCompromisso telaCompromisso = new TelaCompromisso(repositorioContato);

            DialogResult opcaoEscolhida = telaCompromisso.ShowDialog();

            if(opcaoEscolhida == DialogResult.OK)
            {
                Compromisso compromisso = telaCompromisso.Compromisso;

                repositorioCompromisso.Inserir(compromisso);

                CarregarCompromissos();
            }
        }

        public override void Filtrar()
        {
            TelaFiltro telaFiltro = new TelaFiltro();

            if(telaFiltro.ShowDialog() == DialogResult.OK)
            {
                StatusCompromissosEnum statusSelecionado = telaFiltro.StatusSelecionado;

                DateTime dataInicial = telaFiltro.DataInicial.Date;
                DateTime dataFinal = telaFiltro.DataFinal.Date;

                CarregarCompromissosComFiltro(statusSelecionado, dataInicial, dataFinal);
            }
        }

        private void CarregarCompromissosComFiltro(StatusCompromissosEnum statusSelecionado, DateTime dataInicial, DateTime dataFinal)
        {
            string tipoCompromisso;
            List<Compromisso> compromissos;

            switch(statusSelecionado)
            {
                case StatusCompromissosEnum.Futuros: 
                    compromissos = repositorioCompromisso.SelecionarCompromissosFuturos();
                    tipoCompromisso = "Futuro(s)"; break;
                case StatusCompromissosEnum.Passados: 
                    compromissos = repositorioCompromisso.SelecionarCompromissosPassados();
                    tipoCompromisso = "Passado(s)"; break;

                default: compromissos = repositorioCompromisso.SelecionarTodos();
                    tipoCompromisso = ""; break;
            }

            listagemCompromisso.AtualizarRegistros(compromissos);
        }

        public override UserControl ObterListagem()
        {
            if(listagemCompromisso == null)
                listagemCompromisso = new ListaCompromissoControl();

            CarregarCompromissos();

            return listagemCompromisso;
        }

        private void CarregarCompromissos()
        {
            List<Compromisso> compromissos = repositorioCompromisso.SelecionarTodos();

            listagemCompromisso.AtualizarRegistros(compromissos);
        }

        public override string ObterTipoCadastro()
        {
            return "Cadastro de Compromissos";
        }
    }
}
