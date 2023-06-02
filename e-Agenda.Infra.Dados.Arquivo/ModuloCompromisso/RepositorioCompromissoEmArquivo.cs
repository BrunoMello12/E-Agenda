using E_Agenda.Dominio.Compartilhado;
using E_Agenda.Dominio.ModuloCompromisso;
using E_Agenda.Infra.Compartilhado;


namespace E_Agenda.Infra.ModuloCompromisso
{
    public class RepositorioCompromissoEmArquivo : RepositorioEmArquivoBase<Compromisso>, IRepositorioCompromisso
    {
        public RepositorioCompromissoEmArquivo(ContextoDados contexto) : base(contexto)
        {
            
        }

        protected override List<Compromisso> ObterRegistros()
        {
            return contextoDados.compromissos;
        }

        public List<Compromisso> SelecionarCompromissosFuturos()
        {
            List<Compromisso> compromissosFuturos = new List<Compromisso>();

            foreach (Compromisso item in ObterRegistros())
            {
                if (item.data > DateTime.Now.Date)
                    compromissosFuturos.Add(item);
            }

            return compromissosFuturos;
        }

        public List<Compromisso> SelecionarCompromissosPassados()
        {
            List<Compromisso> compromissosPassados = new List<Compromisso>();

            foreach (Compromisso item in ObterRegistros())
            {
                if (item.data < DateTime.Now.Date)
                    compromissosPassados.Add(item);
            }

            return compromissosPassados;
        }

        
    }
}
