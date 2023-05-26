using E_Agenda.WinFormsApp.Compartilhado;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Agenda.WinFormsApp.ModuloTarefa
{
    public class Tarefa : EntidadeBase<Tarefa>
    {
        public string titulo;
        public string prioridade;
        public DateTime data;
        public ArrayList subTarefa = new ArrayList();
        public double porcentagem;

        public Tarefa(string titulo, string prioridade, DateTime data)
        {
            this.titulo = titulo;
            this.prioridade = prioridade;
            this.data = data;
        }

        public override void AtualizarInformacoes(Tarefa entidadeAtualizada)
        {
           titulo = entidadeAtualizada.titulo;
           prioridade = entidadeAtualizada .prioridade;
           data = entidadeAtualizada.data;
        }

        public override string ToString()
        {
            return $"Id: {id}, Titulo: {titulo}, Prioridade: {prioridade}, Data: {data.Date.ToString("dd/MM/yyyy")}";
        }

        public override string[] Validar()
        {
            throw new NotImplementedException();
        }
    }
}
