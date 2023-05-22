using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Agenda.WinFormsApp.ModuloContato
{
    public class RepositorioContato
    {
        private static int contador = 1;
        public List<Contato> contatoList = new List<Contato>();

        public void Inserir(Contato contato)
        {
            contato.id = contador++;
            contatoList.Add(contato);
        }

        public List<Contato> SelecionarTodos()
        {
            return contatoList;
        }

        public void Editar(Contato contato)
        {
            Contato contatoSelecionado = SelecionarPorId(contato.id);

            contatoSelecionado.nome = contato.nome;
            contatoSelecionado.email = contato.email;
            contatoSelecionado.empresa = contato.empresa;
            contatoSelecionado.cargo = contato.cargo;
            contatoSelecionado.telefone = contato.telefone;
        }

        private Contato SelecionarPorId(int id)
        {
            return contatoList.FirstOrDefault(x => x.id == id);
        }

        public void Excluir(Contato contato)
        { 
            contatoList.Remove(contato);
        }
    }
}
