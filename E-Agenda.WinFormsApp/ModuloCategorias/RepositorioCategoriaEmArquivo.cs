using E_Agenda.WinFormsApp.Compartilhado;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Agenda.WinFormsApp.ModuloCategorias
{
    public class RepositorioCategoriaEmArquivo : RepositorioEmArquivoBase<Categoria>, IRepositorioCategoria
    {
        private const string NOME_ARQUIVO_CATEGORIA = "categorias.bin";
        Categoria categoria = new Categoria();

        public RepositorioCategoriaEmArquivo()
        {
            if (File.Exists(NOME_ARQUIVO_CATEGORIA))
                CarregarRegistrosDoArquivo(categoria);
        }
    }
}
