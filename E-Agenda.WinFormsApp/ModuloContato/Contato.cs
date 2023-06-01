using E_Agenda.WinFormsApp.Compartilhado;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Agenda.WinFormsApp.ModuloContato
{
    [Serializable]
    public class Contato : EntidadeBase<Contato>
    {
        public string nome;
        public string telefone;
        public string email;
        public string cargo;
        public string empresa;

        public Contato()
        {
            
        }

        public Contato(string nome, string empresa, string telefone, string email, string cargo, int id)
        {
            this.id = id;
            this.nome = nome;
            this.empresa = empresa;
            this.telefone = telefone;
            this.email = email;
            this.cargo = cargo;
        }

        public override void AtualizarInformacoes(Contato entidadeAtualizada)
        {
            nome = entidadeAtualizada.nome;
            email = entidadeAtualizada.email;
            empresa = entidadeAtualizada.empresa;
            cargo = entidadeAtualizada.cargo;
            telefone = entidadeAtualizada.telefone;
        }

        public override bool Equals(object? obj)
        {
            return obj is Contato contato &&
                   id == contato.id &&
                   nome == contato.nome &&
                   telefone == contato.telefone &&
                   email == contato.email &&
                   cargo == contato.cargo &&
                   empresa == contato.empresa;
        }

        public override string ToString()
        {
            return $"Id: {id}, Nome: {nome}, Empresa: {empresa}";
        }

        public override string[] Validar()
        {
            List<string> errors = new List<string>();

            if (string.IsNullOrEmpty(nome))
                errors.Add("O campo nome é Obrigatório");

            if (string.IsNullOrEmpty(telefone))
                errors.Add("O campo telefone é Obrigatório");

            if (string.IsNullOrEmpty(email))
                errors.Add("O campo email é Obrigatório");

            return errors.ToArray();
        }
    }
}
