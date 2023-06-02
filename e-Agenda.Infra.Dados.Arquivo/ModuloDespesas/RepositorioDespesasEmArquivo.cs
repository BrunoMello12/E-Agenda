using E_Agenda.Dominio.Compartilhado;
using E_Agenda.Dominio.ModuloCategorias;
using E_Agenda.Dominio.ModuloDespesas;

using E_Agenda.Infra.Compartilhado;


namespace E_Agenda.Infra.ModuloDespesas
{
    public class RepositorioDespesasEmArquivo : RepositorioEmArquivoBase<Despesa>, IRepositorioDespesas
    {
        public RepositorioDespesasEmArquivo(ContextoDados contexto) : base(contexto)
        {
        }

        protected override List<Despesa> ObterRegistros()
        {
            return contextoDados.despesas;
        }
        

        public List<Despesa> ListarDespesasPorCategorias(Categoria categoria)
        {
            return ObterRegistros().Where(d => d.categorias.Contains(categoria)).ToList();
        }

        
    }
}
