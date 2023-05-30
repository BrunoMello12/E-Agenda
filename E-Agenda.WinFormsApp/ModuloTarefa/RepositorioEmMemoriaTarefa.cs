using E_Agenda.WinFormsApp.Compartilhado;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace E_Agenda.WinFormsApp.ModuloTarefa
{
    public class RepositorioEmMemoriaTarefa : RepositorioEmMemoriaBase<Tarefa>, IRepositorioTarefa
    {
        public RepositorioEmMemoriaTarefa(List<Tarefa> tarefas) 
        {
            listaRegistros = tarefas;
        }

        public List<Tarefa> SelecionarConcluidas()
        {
            return listaRegistros.Where(x => x.percentualConcluido == 100)
                .OrderByDescending(x => x.prioridade).ToList();
        }

        public List<Tarefa> SelecionarPendentes()
        {
            return listaRegistros.Where(x => x.percentualConcluido < 100)
                .OrderByDescending(x => x.prioridade).ToList();
        }

        public List<Tarefa> SelecionarTodosOrdenadosPorPrioridade()
        {
            return listaRegistros
                .OrderByDescending(x => x.prioridade)
                .ToList();
        }
    }
}
