using E_Agenda.WinFormsApp.Compartilhado;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Agenda.WinFormsApp.ModuloContato
{
    public class RepositorioContatoEmArquivo : RepositorioEmArquivoBase<Contato>, IRepositorioContato
    {
        public RepositorioContatoEmArquivo(ContextoDados contextoDados) : base(contextoDados)
        {
            
        }

        protected override List<Contato> ObterRegistros()
        {
            return contextoDados.contatos;
        }
    }
}
