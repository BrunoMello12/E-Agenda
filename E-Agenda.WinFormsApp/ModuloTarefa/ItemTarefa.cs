using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Agenda.WinFormsApp.ModuloTarefa
{
    public class ItemTarefa
    {
        public string titulo;
        public bool concluido;

        public ItemTarefa(string titulo)
        {
            this.titulo = titulo;
        }

        public override bool Equals(object? obj)
        {
            return obj is ItemTarefa tarefa &&
                   titulo == tarefa.titulo &&
                   concluido == tarefa.concluido;
        }

        public override string ToString()
        {
            return $"{titulo}";
        }

        public void Concluir()
        {
            concluido = true;
        }

        public void Desmarcar()
        {
            concluido = false;
        }
    }
}
