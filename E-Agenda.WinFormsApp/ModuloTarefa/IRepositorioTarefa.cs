using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Agenda.WinFormsApp.ModuloTarefa
{
    public interface IRepositorioTarefa
    {
        void Inserir(Tarefa novaTarefa);
        void Editar(int id,  Tarefa tarefa);
        void Excluir(Tarefa tarefaSelecionada);
        List<Tarefa> SelecionarConcluidas();
        List<Tarefa> SelecionarPendentes();
        Tarefa SelecionarPorId(int id);
        List<Tarefa> SelecionarTodosOrdenadosPorPrioridade();
        List<Tarefa> SelecionarTodos();
    }
}
