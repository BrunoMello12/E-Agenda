using E_Agenda.Dominio.ModuloContato;
using E_Agenda.WinFormsApp.Compartilhado;


namespace E_Agenda.WinFormsApp.ModuloContato
{
    public class RepositorioContatoEmMemoria : RepositorioEmMemoriaBase<Contato>
    {
        public RepositorioContatoEmMemoria(List<Contato> contatos)
        {
            listaRegistros = contatos;
        }
    }
}
