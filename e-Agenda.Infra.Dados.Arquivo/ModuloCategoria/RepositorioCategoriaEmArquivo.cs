using E_Agenda.Dominio.Compartilhado;
using E_Agenda.Dominio.ModuloCategorias;
using E_Agenda.Infra.Compartilhado;


namespace E_Agenda.Infra.ModuloCategorias
{
    public class RepositorioCategoriaEmArquivo : RepositorioEmArquivoBase<Categoria>, IRepositorioCategoria
    {
        public RepositorioCategoriaEmArquivo(ContextoDados contexto) : base(contexto)
        {
        }

        protected override List<Categoria> ObterRegistros()
        {
            return contextoDados.categorias;
        }
    }
}
