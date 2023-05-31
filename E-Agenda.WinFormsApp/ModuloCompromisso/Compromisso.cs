using E_Agenda.WinFormsApp.Compartilhado;
using E_Agenda.WinFormsApp.ModuloContato;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace E_Agenda.WinFormsApp.ModuloCompromisso
{
    [Serializable]
    public class Compromisso : EntidadeBase<Compromisso>
    {
        public DateTime data;
        public TimeSpan horaInicio;
        public TimeSpan horaTermino;
        public string assunto;
        public string localPresencial;
        public string localOnline;
        public Contato contatoCompromisso;
        public TipoLocalEnum tipoLocal;

        public Compromisso(DateTime data, TimeSpan horaInicio,
            TimeSpan horaTermino, string assunto, Contato contato,
            TipoLocalEnum tipoLocal, string local, int id)
        {
            this.id = id;
            this.data = data;
            this.horaInicio = horaInicio;
            this.horaTermino = horaTermino;
            this.assunto = assunto;
            contatoCompromisso = contato;
            this.tipoLocal = tipoLocal;


            if (tipoLocal == TipoLocalEnum.Online)
                this.localOnline = local;
            else
                this.localPresencial = local;
        }

        public override void AtualizarInformacoes(Compromisso compromissoAtualizado)
        {
            horaInicio = compromissoAtualizado.horaInicio;
            horaTermino = compromissoAtualizado.horaTermino;
            data = compromissoAtualizado.data;
            assunto = compromissoAtualizado.assunto;
            contatoCompromisso = compromissoAtualizado.contatoCompromisso;
            localOnline = compromissoAtualizado.localOnline;    
            localPresencial = compromissoAtualizado.localPresencial;
            tipoLocal = compromissoAtualizado.tipoLocal;
        }

        public override bool Equals(object? obj)
        {
            return obj is Compromisso compromisso &&
                   id == compromisso.id &&
                   data == compromisso.data &&
                   horaInicio == compromisso.horaInicio &&
                   horaTermino == compromisso.horaTermino &&
                   assunto == compromisso.assunto &&
                   localPresencial == compromisso.localPresencial &&
                   localOnline == compromisso.localOnline &&
                   EqualityComparer<Contato>.Default.Equals(contatoCompromisso, compromisso.contatoCompromisso) &&
                   tipoLocal == compromisso.tipoLocal;
        }

        public override string[] Validar()
        {
            List<string> erros = new List<string>();

            if (string.IsNullOrEmpty(assunto))
                erros.Add("O campo assunto é obrigatório");

            return erros.ToArray();
        }
    }
}
