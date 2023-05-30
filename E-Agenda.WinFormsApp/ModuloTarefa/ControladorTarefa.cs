using E_Agenda.WinFormsApp.Compartilhado;
using E_Agenda.WinFormsApp.ModuloContato;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Agenda.WinFormsApp.ModuloTarefa
{
    public class ControladorTarefa : ControladorBase
    {
        RepositorioTarefa repositorioTarefa;
        TabelaTarefaControl tabelaTarefa;

        public ControladorTarefa(RepositorioTarefa repositorioTarefa)
        {
            this.repositorioTarefa = repositorioTarefa;
        }

        public override string ToolTipInserir => "Inserir uma nova Tarefa"; 

        public override string ToolTipEditar => "Editar uma Tarefa existente";

        public override string ToolTipExcluir => "Excluir uma Tarefa existente";

        public override string ToolTipFiltrar => "Filtrar Tarefas";

        public override string ToolTipAdicionar => "Adicionar Itens na Tarefa";

        public override string ToolTipAtualizar => "Atualizar Percentual";

        public override bool AdicionarItensHabilitado => true;

        public override bool FiltrarHabilitado => true;

        public override bool ConcluirItensHabilitado => true;

        public override void Editar()
        {
            if (repositorioTarefa.listaRegistros.Count == 0) return;

            TelaTarefaForm telaTarefa = new TelaTarefaForm();

            Tarefa tarefaSelecionada = ObterTarefaSelecionada();

            if(tarefaSelecionada == null)
            {
                MessageBox.Show("Selecione uma tarefa primeiro!", "Edição de tarefas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            telaTarefa.ConfigurarTela(tarefaSelecionada);

            DialogResult opcaoEscolhida = telaTarefa.ShowDialog();

            if(opcaoEscolhida == DialogResult.OK)
            {
                Tarefa tarefa = telaTarefa.ObterTarefa();

                repositorioTarefa.Editar(tarefa.id, tarefa);

                CarregarTarefas();
            }
        }

        private Tarefa ObterTarefaSelecionada()
        {
            int id = tabelaTarefa.ObterIdSelecionado();

            return repositorioTarefa.SelecionarPorId(id);
        }

        public override void Excluir()
        {
            if (repositorioTarefa.listaRegistros.Count == 0) return;

            Tarefa tarefaSelecionada = ObterTarefaSelecionada();

            if (tarefaSelecionada == null)
            {
                MessageBox.Show("Selecione uma tarefa primeiro!", "Exclusão de tarefas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            DialogResult opcaoEscolhida = MessageBox.Show($"Deseja excluir a tarefa {tarefaSelecionada.titulo}?", "Exclusão de Contatos", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if(opcaoEscolhida == DialogResult.OK)
            {
                repositorioTarefa.Excluir(tarefaSelecionada);

                CarregarTarefas();
            }
        }

        public override void Inserir()
        {
            TelaTarefaForm telaTarefa = new TelaTarefaForm();

            DialogResult opcaoEscolhida = telaTarefa.ShowDialog();

            if(opcaoEscolhida == DialogResult.OK)
            {
                Tarefa tarefa = telaTarefa.ObterTarefa();

                repositorioTarefa.Inserir(tarefa);

                CarregarTarefas();
            }
        }

        public override void Adicionar()
        {
            if (repositorioTarefa.listaRegistros.Count == 0) return;

            TelaTarefaForm telaTarefa = new TelaTarefaForm();

            Tarefa tarefaSelecionada = ObterTarefaSelecionada();

            if (tarefaSelecionada == null)
            {
                MessageBox.Show("Selecione uma tarefa primeiro!", "Adição de tarefas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            TelaCadastroItensForm telaItem = new TelaCadastroItensForm(tarefaSelecionada);

            DialogResult opcaoEscolhida = telaItem.ShowDialog();

            if(opcaoEscolhida == DialogResult.OK)
            {
                List<ItemTarefa> itensAdicionados = telaItem.ObterItensCadastrados();

                tarefaSelecionada.items = itensAdicionados;

                repositorioTarefa.Editar(tarefaSelecionada.id, tarefaSelecionada);
            }

            CarregarTarefas();
        }

        public override void Atualizar()
        {
            Tarefa tarefaSelecionada = ObterTarefaSelecionada();

            if(tarefaSelecionada == null)
            {
                MessageBox.Show("Selecione uma tarefa primeiro!", "Atualização de itens",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if(tarefaSelecionada.items.Count == 0)
            {
                MessageBox.Show("A tarefa selecionada não tem itens adicionados",
                    "Atualização de Itens", MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
                return;
            }

            TelaAtualizacaoItensForm telaAtualizacaoItensForm = new TelaAtualizacaoItensForm(tarefaSelecionada);

            DialogResult opcaoEscolhida = telaAtualizacaoItensForm.ShowDialog();

            if(opcaoEscolhida == DialogResult.OK)
            {
                List<ItemTarefa> itensMarcados = telaAtualizacaoItensForm.ObterItensMarcados();

                List<ItemTarefa> itensPendentes = telaAtualizacaoItensForm.ObterItensPendentes();

                foreach(ItemTarefa item in itensMarcados)
                {
                    tarefaSelecionada.ConcluirItem(item);
                }

                foreach(ItemTarefa item in itensPendentes)
                {
                    tarefaSelecionada.DesmarcarItem(item);
                }
            }

            repositorioTarefa.Editar(tarefaSelecionada.id, tarefaSelecionada);

            CarregarTarefas();
        }

        public override void Filtrar()
        {
            TelaFiltroTarefaForm telaFiltroTarefa = new TelaFiltroTarefaForm();

            DialogResult opcaoEscolhida = telaFiltroTarefa.ShowDialog();

            if(opcaoEscolhida == DialogResult.OK)
            {
                List<Tarefa> tarefas;

                StatusTarefaEnum status = telaFiltroTarefa.ObterFiltroTarefa();

                switch(status)
                {
                    case StatusTarefaEnum.Concluidos: tarefas = repositorioTarefa.SelecionarConcluidas(); break;
                    case StatusTarefaEnum.Pendentes: tarefas = repositorioTarefa.SelecionarPendentes(); break;

                    default: tarefas = repositorioTarefa.SelecionarTodos(); break;
                }

                CarregarTarefas(tarefas);
            }
        }

        private void CarregarTarefas(List<Tarefa> tarefas)
        {
            tabelaTarefa.AtualizarRegistros(tarefas);

            TelaPrincipalForm1.instancia.AtualizarRodape($"Visualizando {tarefas.Count} tarefa(s)");
        }

        private void CarregarTarefas()
        {
            List<Tarefa> tarefas = repositorioTarefa.SelecionarTodos();

            tabelaTarefa.AtualizarRegistros(tarefas);
        }

        public override UserControl ObterListagem()
        {
            if(tabelaTarefa == null)
                tabelaTarefa = new TabelaTarefaControl();

            CarregarTarefas();

            return tabelaTarefa;
        }

        public override string ObterTipoCadastro()
        {
            return "Cadastro de Tarefas";
        }

    }
}
