
using E_Agenda.Infra.Compartilhado;

namespace E_Agenda.Dominio.Compartilhado
{
    public abstract class RepositorioEmArquivoBase<TEntidade> where TEntidade : EntidadeBase<TEntidade>
    {
        protected ContextoDados contextoDados;
        private int contadorRegistros;

        public RepositorioEmArquivoBase(ContextoDados contexto)
        {
            contextoDados = contexto;

            AtualizarContador();
        }

        protected abstract List<TEntidade> ObterRegistros();

        public void Editar(int id, TEntidade entidade)
        {
            TEntidade entidadeSelecionada = SelecionarPorId(id);

            entidade.AtualizarInformacoes(entidadeSelecionada);

            contextoDados.GravarEmArquivoJson();
        }

        public void Excluir(TEntidade entidadeSelecionada)
        {
            List<TEntidade> listaRegistros = ObterRegistros();

            listaRegistros.Remove(entidadeSelecionada);

            contextoDados.GravarEmArquivoJson();
        }

        public void Inserir(TEntidade novaEntidade)
        {
            List<TEntidade> listaRegistros = ObterRegistros();

            contadorRegistros++;

            novaEntidade.id = contadorRegistros;

            listaRegistros.Add(novaEntidade);

            contextoDados.GravarEmArquivoJson();
        }

        public TEntidade SelecionarPorId(int id)
        {
            List<TEntidade> listaRegistros = ObterRegistros();

            return listaRegistros.FirstOrDefault(x => x.id == id);
        }

        public List<TEntidade> SelecionarTodos()
        {
            return ObterRegistros();
        }

        public void AtualizarContador()
        {
            if (ObterRegistros().Count > 0)
                contadorRegistros = ObterRegistros().Max(x => x.id);
        }
    }
}
