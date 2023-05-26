using E_Agenda.WinFormsApp.ModuloCompromisso;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Agenda.WinFormsApp.Compartilhado
{
    public class RepositorioBase<TEntidade> where TEntidade : EntidadeBase<TEntidade>
    {
        public List<TEntidade> listaRegistros;
        private static int contador = 1;

        public void Inserir(TEntidade entidade)
        {
            entidade.id = contador++;
            listaRegistros.Add(entidade);
        }

        public virtual void Editar(int id, TEntidade registroAtualizado)
        {
            TEntidade registroSelecionado = SelecionarPorId(id);

            registroSelecionado.AtualizarInformacoes(registroAtualizado);
        }

        public TEntidade SelecionarPorId(int id)
        {
            return listaRegistros.FirstOrDefault(x => x.id == id);
        }

        public void Excluir(TEntidade compromisso)
        {
            listaRegistros.Remove(compromisso);
        }

        public List<TEntidade> SelecionarTodos()
        {
            return listaRegistros;
        }
    }
}
