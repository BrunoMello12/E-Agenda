using E_Agenda.WinFormsApp.Compartilhado;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
