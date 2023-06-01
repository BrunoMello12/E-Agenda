using E_Agenda.WinFormsApp.Compartilhado;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Agenda.WinFormsApp.ModuloContato
{
    public class RepositorioContatoEmArquivo : RepositorioEmArquivoBase<Contato>, IRepositorioContato
    {
        private const string NOME_ARQUIVO_CONTATO = "contatos.bin";
        Contato contato = new Contato();

        public RepositorioContatoEmArquivo()
        {
            if (File.Exists(NOME_ARQUIVO_CONTATO))
                CarregarRegistrosDoArquivo(contato);
        }
    }
}
