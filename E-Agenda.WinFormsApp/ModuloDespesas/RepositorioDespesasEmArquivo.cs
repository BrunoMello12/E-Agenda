using E_Agenda.WinFormsApp.Compartilhado;
using E_Agenda.WinFormsApp.ModuloCategorias;
using E_Agenda.WinFormsApp.ModuloTarefa;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Agenda.WinFormsApp.ModuloDespesas
{
    public class RepositorioDespesasEmArquivo : RepositorioEmArquivoBase<Despesa>, IRepositorioDespesas
    {
        private const string NOME_ARQUIVO_DESPESAS = "despesas.bin";

        public RepositorioDespesasEmArquivo()
        {
            if (File.Exists(NOME_ARQUIVO_DESPESAS))
                CarregarRegistrosDoArquivo(NOME_ARQUIVO_DESPESAS);

            GravarTarefasEmArquivo(NOME_ARQUIVO_DESPESAS);
        }

        public List<Despesa> ListarDespesasPorCategorias(Categoria categoria)
        {
            return listaRegistros.Where(d => d.categorias.Contains(categoria)).ToList();
        }
    }
}
