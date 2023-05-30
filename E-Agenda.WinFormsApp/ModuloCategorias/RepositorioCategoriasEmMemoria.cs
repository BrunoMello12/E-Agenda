using E_Agenda.WinFormsApp.Compartilhado;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
