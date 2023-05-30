using E_Agenda.WinFormsApp.Compartilhado;
using E_Agenda.WinFormsApp.ModuloDespesas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Agenda.WinFormsApp.ModuloCategorias
{
    public class ControladorCategorias : ControladorBase
    {
        RepositorioDespesa repositorioDespesas;
        RepositorioCategorias repositorioCategorias;
        TabelaCategoriasControl tabelaCategoria;

        public ControladorCategorias(RepositorioCategorias repositorioCategorias, RepositorioDespesa repositorioDespesas)
        {
            this.repositorioCategorias = repositorioCategorias;
            this.repositorioDespesas = repositorioDespesas;
        }

        public override string ToolTipInserir => "Inserir Categoria";

        public override string ToolTipEditar => "Editar Categoria";

        public override string ToolTipExcluir => "Excluir Categoria";

        public override string ToolTipVisualizarCategorias => "Visualizar Categorias com Despesas";

        public override bool VisualizarCategoriasDespesas => true;

        public override void Editar()
        {
            TelaCategoriasForm telaCategoriasForm = new TelaCategoriasForm();

            Categoria categoriaSelecionada = ObterCategoriaSelecionada();

            if (categoriaSelecionada == null)
            {
                MessageBox.Show("Selecione uma categoria primeiro!", "Edição de Categorias",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            telaCategoriasForm.ConfigurarTela(categoriaSelecionada);

            DialogResult opcaoEscolhida = telaCategoriasForm.ShowDialog();

            if(opcaoEscolhida == DialogResult.OK)
            {
                Categoria categoria = telaCategoriasForm.ObterCategoria();

                repositorioCategorias.Editar(categoria.id, categoria);

                CarregarCategorias();
            }
        }

        private Categoria ObterCategoriaSelecionada()
        {
            int id = tabelaCategoria.ObterIdSelecionado();

            return repositorioCategorias.SelecionarPorId(id);
        }

        public override void Excluir()
        {
            Categoria categoriaSelecionada = ObterCategoriaSelecionada();

            if (categoriaSelecionada == null)
            {
                MessageBox.Show("Selecione uma categoria primeiro!", "Exclusão de Categorias",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            DialogResult opcaoEscolhida = MessageBox.Show($"Deseja mesmo excluir a categoria {categoriaSelecionada.titulo}?",
                "Exclusão de Categorias", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if(opcaoEscolhida == DialogResult.OK)
            {
                repositorioCategorias.Excluir(categoriaSelecionada);

                CarregarCategorias();
            }
        }

        public override void Inserir()
        {
            TelaCategoriasForm telaCategoriasForm = new TelaCategoriasForm();

            DialogResult opcaoEscolhida = telaCategoriasForm.ShowDialog();

            if(opcaoEscolhida == DialogResult.OK)
            {
                Categoria categoria = telaCategoriasForm.ObterCategoria();

                repositorioCategorias.Inserir(categoria);

                CarregarCategorias();
            }
        }

        public override void Visualizar()
        {
            Categoria categoria = ObterCategoriaSelecionada();

            if (categoria == null)
            {
                MessageBox.Show("Selecione uma categoria!");
                return;
            }

            List<Despesa> despesasPorCategoria = repositorioDespesas.ListarDespesasPorCategorias(categoria);

            if (despesasPorCategoria.Count == 0)
            {
                MessageBox.Show("Nenhuma despesa para a categoria selecionada!");
                return;
            }

            TelaVisualizarCategoriasForm tela = new TelaVisualizarCategoriasForm(despesasPorCategoria);

            tela.CarregarLabel(categoria);

            tela.ShowDialog();
        }

        private void CarregarCategorias()
        {
            List<Categoria> categorias = repositorioCategorias.SelecionarTodos();

            tabelaCategoria.AtualizarRegistros(categorias);
        }

        public override UserControl ObterListagem()
        {
            if(tabelaCategoria == null)
                tabelaCategoria = new TabelaCategoriasControl();

            CarregarCategorias();

            return tabelaCategoria;
        }

        public override string ObterTipoCadastro()
        {
            return "Cadastro de Categorias";
        }
    }
}
