using E_Agenda.WinFormsApp.Compartilhado;
using E_Agenda.WinFormsApp.ModuloCategorias;
using E_Agenda.WinFormsApp.ModuloCompromisso;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Agenda.WinFormsApp.ModuloDespesas
{
    public class Despesa : EntidadeBase<Despesa>
    {
        public string descricao;
        public DateTime data;
        public string valor;
        public FormaPagamentoEnum formaPagamento;
        public List<Categoria> categorias;

        public Despesa(int id, string descricao, DateTime data, string valor, FormaPagamentoEnum formaPagamento)
        {
            this.id = id;
            this.descricao = descricao;
            this.data = data;
            this.valor = valor;
            this.formaPagamento = formaPagamento;
            categorias = new List<Categoria>();
        }


        public override void AtualizarInformacoes(Despesa entidadeAtualizada)
        {
            id = entidadeAtualizada.id;
            descricao = entidadeAtualizada.descricao;
            data = entidadeAtualizada.data.Date;
            valor = entidadeAtualizada .valor;
            formaPagamento = entidadeAtualizada.formaPagamento;
            categorias = entidadeAtualizada.categorias;
        }

        public override bool Equals(object? obj)
        {
            return obj is Despesa despesa &&
                   id == despesa.id &&
                   descricao == despesa.descricao &&
                   data == despesa.data &&
                   valor == despesa.valor;
        }

        public override string[] Validar()
        {
            List<string> erros = new List<string>();

            if (string.IsNullOrEmpty(descricao))
                erros.Add("O campo descrição é obrigatório");

            if (string.IsNullOrEmpty(valor))
                erros.Add("O campo valor é obrigatório");

            if (formaPagamento == null)
                erros.Add("O campo forma de pagamento é obrigatório");

            return erros.ToArray(); 
        }

        public override string ToString()
        {
            return descricao + " feita no dia " + data.ToString("dd/MM/yyyy");
        }
    }
}
