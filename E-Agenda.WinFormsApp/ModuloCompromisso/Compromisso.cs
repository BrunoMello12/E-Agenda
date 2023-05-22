using E_Agenda.WinFormsApp.Compartilhado;
using E_Agenda.WinFormsApp.ModuloContato;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Agenda.WinFormsApp.ModuloCompromisso
{
    public class Compromisso : EntidadeBase
    {
        public int id;
        public DateTime data;
        public DateTime horaInicio;
        public DateTime horaTermino;
        public string assunto;
        public string local;
        public Contato contatoCompromisso;

        public Compromisso(DateTime data, DateTime horaInicio, DateTime horaTermino, string assunto, Contato contato)
        {
            this.data = data;
            this.horaInicio = horaInicio;
            this.horaTermino = horaTermino;
            this.assunto = assunto;
            contatoCompromisso = contato;
        }

        public override string ToString()
        {
            string contato = contatoCompromisso == null ?
                " - Sem Contato" : ", Contato: " + contatoCompromisso.nome;
            return "Id: " + id + ", Assunto: " + assunto + 
                ", Data: " + data.ToString() + ", Hora Início: " + horaInicio.ToString("HH:mm") +
                ", Hora Término: " + horaTermino.ToString("HH:mm") + contato;
        }
    }
}
