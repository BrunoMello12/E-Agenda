

namespace E_Agenda.Dominio.Compartilhado
{
    [Serializable]
    public abstract class EntidadeBase<TEntidade>
    {
        public int id;

        public abstract void AtualizarInformacoes(TEntidade entidadeAtualizada);

        public abstract string[] Validar();
    }
}
