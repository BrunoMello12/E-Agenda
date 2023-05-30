using E_Agenda.WinFormsApp.ModuloTarefa;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace E_Agenda.WinFormsApp.Compartilhado
{
    public class RepositorioEmArquivoBase<TEntidade> where TEntidade : EntidadeBase<TEntidade>
    {
        protected int contadorRegistros = 0;
        protected List<TEntidade> listaRegistros = new List<TEntidade>();

        public void CarregarRegistrosDoArquivo(string caminho)
        {
            BinaryFormatter serializador = new BinaryFormatter();

            byte[] registrosEmBytes = File.ReadAllBytes(caminho);

            MemoryStream registroStream = new MemoryStream(registrosEmBytes);

            listaRegistros = (List<TEntidade>)serializador.Deserialize(registroStream);

            AtualizarContador();
        }

        public void AtualizarContador()
        {
            contadorRegistros = listaRegistros.Max(x => x.id);
        }

        public void GravarTarefasEmArquivo(string caminho)
        {
            BinaryFormatter serializador = new BinaryFormatter();

            MemoryStream registroStream = new MemoryStream();

            serializador.Serialize(registroStream, listaRegistros);

            byte[] registrosEmBytes = registroStream.ToArray();

            File.WriteAllBytes(caminho, registrosEmBytes);
        }
    }
}
