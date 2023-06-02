using E_Agenda.Dominio.Compartilhado;
using E_Agenda.Dominio.ModuloCategorias;


namespace E_Agenda.Dominio.ModuloDespesas
{
    public interface IRepositorioDespesas : IRepositorioBase<Despesa>
    {
        List<Despesa> ListarDespesasPorCategorias(Categoria categoria);
    }
}
