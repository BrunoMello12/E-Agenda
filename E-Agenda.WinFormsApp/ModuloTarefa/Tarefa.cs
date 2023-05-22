using E_Agenda.WinFormsApp.Compartilhado;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Agenda.WinFormsApp.ModuloTarefa
{
    public class Tarefa : EntidadeBase
    {
        public int id;
        public string titulo;
        public string prioridade;

        public Tarefa(string titulo, string prioridade)
        {
            this.titulo = titulo;
            this.prioridade = prioridade;
        }

        public override string ToString()
        {
            return $"Id: {id}, Titulo: {titulo}, Prioridade: {prioridade}";
        }
    }
}
