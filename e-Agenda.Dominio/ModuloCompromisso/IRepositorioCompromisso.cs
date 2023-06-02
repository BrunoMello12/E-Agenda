using E_Agenda.Dominio.Compartilhado;


namespace E_Agenda.Dominio.ModuloCompromisso
{
    public interface IRepositorioCompromisso : IRepositorioBase<Compromisso>
    {
        List<Compromisso> SelecionarCompromissosFuturos();
        List<Compromisso> SelecionarCompromissosPassados();
    }
}
