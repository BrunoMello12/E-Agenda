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
        public StatusPrioridadeEnum prioridade;
        public DateTime data;

        public Tarefa(int id, string titulo, StatusPrioridadeEnum prioridade, DateTime data)
        {
            this.id = id;
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
            List<string> erros = new List<string>();

            if (string.IsNullOrEmpty(titulo))
                erros.Add("O campo título é obrigatório");

            if (prioridade == null)
                erros.Add("O campo prioridade é obrigatório");

            return erros.ToArray();

        }
    }
}
