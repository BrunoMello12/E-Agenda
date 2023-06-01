using E_Agenda.WinFormsApp.Compartilhado;
using E_Agenda.WinFormsApp.ModuloCategorias;
using E_Agenda.WinFormsApp.ModuloTarefa;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Agenda.WinFormsApp.ModuloDespesas
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
