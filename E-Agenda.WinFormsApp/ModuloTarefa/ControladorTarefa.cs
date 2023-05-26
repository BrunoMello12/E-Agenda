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
        ListaTarefaControl listagemTarefa;

        public ControladorTarefa(RepositorioTarefa repositorioTarefa)
        {
            this.repositorioTarefa = repositorioTarefa;
        }

        public override string ToolTipInserir { get { return "Inserir uma nova Tarefa"; } }

        public override string ToolTipEditar { get { return "Editar uma Tarefa existente"; } }

        public override string ToolTipExcluir { get { return "Excluir uma Tarefa existente"; } }

        public override void Editar()
        {
            if (repositorioTarefa.listaRegistros.Count == 0) return;

            TelaTarefaForm telaTarefa = new TelaTarefaForm();

            telaTarefa.Tarefa = listagemTarefa.ObterTarefaSelecionada();

            DialogResult opcaoEscolhida = telaTarefa.ShowDialog();

            if(opcaoEscolhida == DialogResult.OK)
            {
                Tarefa tarefa = telaTarefa.Tarefa;

                repositorioTarefa.Editar(tarefa.id, tarefa);

                CarregarTarefas();
            }
        }

        public override void Excluir()
        {
            if (repositorioTarefa.listaRegistros.Count == 0) return;

            Tarefa tarefa = listagemTarefa.ObterTarefaSelecionada();

            DialogResult opcaoEscolhida = MessageBox.Show($"Deseja excluir a tarefa {tarefa.titulo}?", "Exclusão de Contatos", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if(opcaoEscolhida == DialogResult.OK)
            {
                repositorioTarefa.Excluir(tarefa);

                CarregarTarefas();
            }
        }

        public override void Inserir()
        {
            TelaTarefaForm telaTarefa = new TelaTarefaForm();

            DialogResult opcaoEscolhida = telaTarefa.ShowDialog();

            if(opcaoEscolhida == DialogResult.OK)
            {
                Tarefa tarefa = telaTarefa.Tarefa;

                repositorioTarefa.Inserir(tarefa);

                CarregarTarefas();
            }
        }

        private void CarregarTarefas()
        {
            List<Tarefa> tarefas = repositorioTarefa.SelecionarTodos();

            listagemTarefa.AtualizarRegistros(tarefas);
        }

        public override UserControl ObterListagem()
        {
            if(listagemTarefa == null)
                listagemTarefa = new ListaTarefaControl();

            CarregarTarefas();

            return listagemTarefa;
        }

        public override string ObterTipoCadastro()
        {
            return "Cadastro de Tarefas";
        }

        public override void Filtrar()
        {
            throw new NotImplementedException();
        }
    }
}
