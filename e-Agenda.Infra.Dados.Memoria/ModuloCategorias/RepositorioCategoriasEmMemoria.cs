using E_Agenda.Dominio.ModuloCategorias;
using E_Agenda.WinFormsApp.Compartilhado;


namespace E_Agenda.WinFormsApp.ModuloCategorias
{
    public class RepositorioCategoriasEmMemoria : RepositorioEmMemoriaBase<Categoria>
    {
        public RepositorioCategoriasEmMemoria(List<Categoria> categorias)
        {
            listaRegistros = categorias;
        }
    }
}
