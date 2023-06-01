using E_Agenda.WinFormsApp.ModuloCompromisso;
using E_Agenda.WinFormsApp.ModuloContato;
using E_Agenda.WinFormsApp.ModuloDespesas;
using E_Agenda.WinFormsApp.ModuloTarefa;
using Microsoft.Win32;
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

        public void Editar(int id, TEntidade entidade)
        {
            TEntidade entidadeSelecionada = SelecionarPorId(id);

            entidade.AtualizarInformacoes(entidadeSelecionada);

            GravarTarefasEmArquivo(entidade);
        }

        public void Excluir(TEntidade entidadeSelecionada)
        {
            listaRegistros.Remove(entidadeSelecionada);

            GravarTarefasEmArquivo(entidadeSelecionada);
        }

        public void Inserir(TEntidade novaEntidade)
        {
            contadorRegistros++;

            novaEntidade.id = contadorRegistros;

            listaRegistros.Add(novaEntidade);

            GravarTarefasEmArquivo(novaEntidade);
        }

        public TEntidade SelecionarPorId(int id)
        {
            return listaRegistros.FirstOrDefault(x => x.id == id);
        }

        public List<TEntidade> SelecionarTodos()
        {
            return listaRegistros;
        }

        public void CarregarRegistrosDoArquivo(TEntidade entidade)
        {
            string caminho = VerificarCaminho(entidade);

            BinaryFormatter serializador = new BinaryFormatter();

            byte[] registrosEmBytes = File.ReadAllBytes(caminho);

            MemoryStream registroStream = new MemoryStream(registrosEmBytes);

            listaRegistros = (List<TEntidade>)serializador.Deserialize(registroStream);

            AtualizarContador();
        }

        public void AtualizarContador()
        {
            if(listaRegistros.Count == 0) return;

            contadorRegistros = listaRegistros.Max(x => x.id);
        }

        public void GravarTarefasEmArquivo(TEntidade entidade)
        {
            string caminho = VerificarCaminho(entidade);

            BinaryFormatter serializador = new BinaryFormatter();

            MemoryStream registroStream = new MemoryStream();

            serializador.Serialize(registroStream, listaRegistros);

            byte[] registrosEmBytes = registroStream.ToArray();

            File.WriteAllBytes(caminho, registrosEmBytes);
        }

        public string VerificarCaminho(TEntidade registro)
        {

            string caminho;

            if (registro.GetType() == typeof(Contato))
            {
                caminho = "contatos.bin";
            }
            else if (registro.GetType() == typeof(Compromisso))
            {
                caminho = "compromissos.bin";
            }
            else if (registro.GetType() == typeof(Despesa))
            {
                caminho = "despesas.bin";
            }
            else if (registro.GetType() == typeof(Tarefa))
            {
                caminho = "tarefas.bin";
            }
            else
            {
                caminho = "categorias.bin";
            }

            return caminho;

        }

    }
}
