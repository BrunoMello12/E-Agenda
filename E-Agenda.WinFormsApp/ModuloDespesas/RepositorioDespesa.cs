using E_Agenda.WinFormsApp.Compartilhado;
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
    }
}
