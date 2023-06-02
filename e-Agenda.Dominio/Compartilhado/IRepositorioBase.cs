

namespace E_Agenda.Dominio.Compartilhado
{
    public interface IRepositorioBase<TEntidade> where TEntidade : EntidadeBase<TEntidade>
    {
        void Inserir(TEntidade novaEntidade);
        void Editar(int id, TEntidade entidade);
        void Excluir(TEntidade entidadeSelecionada);

        TEntidade SelecionarPorId(int id);
        List<TEntidade> SelecionarTodos();
    }
}
