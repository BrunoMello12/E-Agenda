using E_Agenda.WinFormsApp.Compartilhado;
using E_Agenda.WinFormsApp.ModuloCategorias;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Agenda.WinFormsApp.ModuloDespesas
{
    public interface IRepositorioDespesas : IRepositorioBase<Despesa>
    {
        List<Despesa> ListarDespesasPorCategorias(Categoria categoria);
    }
}
