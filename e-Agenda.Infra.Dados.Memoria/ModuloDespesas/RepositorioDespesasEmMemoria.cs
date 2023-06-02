using E_Agenda.Dominio.ModuloCategorias;
using E_Agenda.Dominio.ModuloDespesas;
using E_Agenda.WinFormsApp.Compartilhado;


namespace E_Agenda.WinFormsApp.ModuloDespesas
{
    public class RepositorioDespesasEmMemoria : RepositorioEmMemoriaBase<Despesa>
    {
        public RepositorioDespesasEmMemoria(List<Despesa> despesas)
        {
            listaRegistros = despesas;
        }

        internal List<Despesa> ListarDespesasPorCategorias(Categoria categoria)
        {
            throw new NotImplementedException();
        }
    }
}
