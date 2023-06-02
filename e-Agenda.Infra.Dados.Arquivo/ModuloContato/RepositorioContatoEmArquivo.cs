using E_Agenda.Dominio.Compartilhado;
using E_Agenda.Dominio.ModuloContato;
using E_Agenda.Infra.Compartilhado;


namespace E_Agenda.Infra.ModuloContato
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
