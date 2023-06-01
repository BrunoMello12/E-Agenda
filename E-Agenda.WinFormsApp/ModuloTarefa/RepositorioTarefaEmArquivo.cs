using E_Agenda.WinFormsApp.Compartilhado;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace E_Agenda.WinFormsApp.ModuloTarefa
{
    public class RepositorioTarefaEmArquivo : RepositorioEmArquivoBase<Tarefa>, IRepositorioTarefa
    {
        public RepositorioTarefaEmArquivo(ContextoDados contextoDados) : base(contextoDados)
        {
            
        }

        protected override List<Tarefa> ObterRegistros()
        {
            return contextoDados.tarefas;
        }

        public List<Tarefa> SelecionarConcluidas()
        {
            return ObterRegistros()
                    .Where(x => x.percentualConcluido == 100)
                    .ToList();
        }

        public List<Tarefa> SelecionarPendentes()
        {
            return ObterRegistros()
                    .Where(x => x.percentualConcluido < 100)
                    .ToList();
        }

        public List<Tarefa> SelecionarTodosOrdenadosPorPrioridade()
        {
            return ObterRegistros()
                   .OrderByDescending(x => x.prioridade)
                   .ToList();
        }

    }
}
