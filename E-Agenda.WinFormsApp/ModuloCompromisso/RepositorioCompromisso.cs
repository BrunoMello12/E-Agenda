using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Agenda.WinFormsApp.ModuloCompromisso
{
    public class RepositorioCompromisso
    {
        public List<Compromisso> compromissosList = new List<Compromisso>();
        private static int contador = 1;

        public List<Compromisso> SelecionarTodos()
        {
            return compromissosList;
        }

        public void Inserir(Compromisso compromisso)
        {
            compromisso.id = contador++;
            compromissosList.Add(compromisso);
        }

        public void Editar(Compromisso compromisso)
        {
            Compromisso compromissoSelecionado = SelecionarPorId(compromisso.id);

            compromissoSelecionado.horaInicio = compromisso.horaInicio;
            compromissoSelecionado.horaTermino = compromisso.horaTermino;
            compromissoSelecionado.local = compromisso.local;
            compromissoSelecionado.data = compromisso.data;
            compromissoSelecionado.assunto = compromisso.assunto;
            compromissoSelecionado.contatoCompromisso = compromisso.contatoCompromisso;
        }

        public Compromisso SelecionarPorId(int id)
        {
            return compromissosList.FirstOrDefault(x => x.id == id);
        }

        public void Excluir(Compromisso compromisso)
        {
            compromissosList.Remove(compromisso);
        }

        public List<Compromisso> SelecionarCompromissosFuturos()
        {
            List<Compromisso> compromissosFuturos = new List<Compromisso>();

            foreach(Compromisso item in compromissosList)
            {
                if(item.data > DateTime.Now.Date)
                    compromissosFuturos.Add(item);
            }

            return compromissosFuturos;
        }

        public List<Compromisso> SelecionarCompromissosPassados()
        {
            List<Compromisso> compromissosPassados = new List<Compromisso>();

            foreach (Compromisso item in compromissosList)
            {
                if (item.data < DateTime.Now.Date)
                    compromissosPassados.Add(item);
            }

            return compromissosPassados;
        }
    }
}
