using E_Agenda.WinFormsApp.Compartilhado;
using E_Agenda.WinFormsApp.ModuloCategorias;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Agenda.WinFormsApp.ModuloDespesas
{
    public class RepositorioDespesa : RepositorioBase<Despesa>
    {
        public RepositorioDespesa(List<Despesa> despesas)
        {
            listaRegistros = despesas;
        }

        public List<Despesa> ListarDespesasPorCategorias(Categoria categoria)
        {
            return listaRegistros.Where(d => d.categorias.Contains(categoria)).ToList();
        }
    }
}
