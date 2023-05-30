using E_Agenda.WinFormsApp.Compartilhado;
using E_Agenda.WinFormsApp.ModuloCategorias;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
