using E_Agenda.Dominio.Compartilhado;


namespace E_Agenda.Dominio.ModuloTarefa
{
    public interface IRepositorioTarefa : IRepositorioBase<Tarefa>
    {
        List<Tarefa> SelecionarConcluidas();
        List<Tarefa> SelecionarPendentes();
        List<Tarefa> SelecionarTodosOrdenadosPorPrioridade();
    }
}
