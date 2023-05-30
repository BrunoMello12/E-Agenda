using E_Agenda.WinFormsApp.Compartilhado;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Agenda.WinFormsApp.ModuloCategorias
{
    public class Categoria : EntidadeBase<Categoria>
    {
        public string titulo;

        public Categoria(int id, string titulo)
        {
            this.id = id;
            this.titulo = titulo;
        }

        public override void AtualizarInformacoes(Categoria entidadeAtualizada)
        {
            id = entidadeAtualizada.id;
            titulo = entidadeAtualizada.titulo;
        }

        public override string[] Validar()
        {
            List<string> erros = new List<string>();

            if (string.IsNullOrEmpty(titulo))
                erros.Add("O campo título é obrigatório");

            return erros.ToArray();
        }
    }
}
