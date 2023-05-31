using E_Agenda.WinFormsApp.ModuloDespesas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Agenda.WinFormsApp.Compartilhado
{
    public interface IRepositorioBase<TEntidade> where TEntidade : EntidadeBase<TEntidade>
    {
        void Inserir(TEntidade novaEntidade);
        void Editar(int id, TEntidade entidade);
        void Excluir(TEntidade entidadeSelecionada);

        TEntidade SelecionarPorId(int id);
        List<TEntidade> SelecionarTodos();
    }
}
