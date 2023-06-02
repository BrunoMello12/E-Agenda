using E_Agenda.Dominio.Compartilhado;
using E_Agenda.Infra.Compartilhado;


namespace E_Agenda.Dominio.ModuloTarefa
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
