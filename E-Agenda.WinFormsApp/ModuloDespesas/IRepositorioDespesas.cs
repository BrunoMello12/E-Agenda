using E_Agenda.WinFormsApp.ModuloCategorias;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Agenda.WinFormsApp.ModuloDespesas
{
    public interface IRepositorioDespesas
    {
        void Inserir(Despesa novaDespesa);
        void Editar(int id, Despesa despesa);
        void Excluir(Despesa despesaSelecionada);

        Despesa SelecionarPorId(int id);
        List<Despesa> SelecionarTodos();
        List<Despesa> ListarDespesasPorCategorias(Categoria categoria);
    }
}
