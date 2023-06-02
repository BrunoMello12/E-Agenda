using E_Agenda.Dominio.Compartilhado;
using E_Agenda.Dominio.ModuloDespesas;


namespace E_Agenda.Dominio.ModuloCategorias
{
    [Serializable]
    public class Categoria : EntidadeBase<Categoria>
    {
        public string titulo;
        public List<Despesa> despesas;

        public Categoria()
        {
            
        }

        public Categoria(int id, string titulo)
        {
            this.id = id;
            this.titulo = titulo;
            this.despesas = new List<Despesa>();
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

        public override string ToString()
        {
            return titulo;
        }
    }
}
