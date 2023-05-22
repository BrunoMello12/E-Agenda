using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Agenda.WinFormsApp.ModuloTarefa
{
    public class RepositorioTarefa 
    {
        public List<Tarefa> tarefaList = new List<Tarefa>();
        private static int contador = 1;

        public void Inserir(Tarefa tarefa)
        {
            tarefa.id = contador++;

            tarefaList.Add(tarefa);
        }

        public List<Tarefa> SelecionarTodos()
        {
            return tarefaList;
        }

        public void Editar(Tarefa tarefa)
        {
            Tarefa tarefaSelecionada = SelecionarPorId(tarefa.id);

            tarefaSelecionada.titulo = tarefa.titulo;
            tarefaSelecionada.prioridade = tarefa.prioridade;
        }

        public Tarefa SelecionarPorId(int id)
        {
            return tarefaList.FirstOrDefault(x => x.id == id);
        }

        public void Excluir(Tarefa tarefa)
        {
            tarefaList.Remove(tarefa);
        }
    }
}
