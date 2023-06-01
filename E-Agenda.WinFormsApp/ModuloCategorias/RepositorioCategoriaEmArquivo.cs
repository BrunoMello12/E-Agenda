using E_Agenda.WinFormsApp.Compartilhado;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Agenda.WinFormsApp.ModuloCategorias
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
