using E_Agenda.WinFormsApp.Compartilhado;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Agenda.WinFormsApp.ModuloDespesas
{
    public class ControladorDespesa : ControladorBase
    {
        private TabelaDespesaControl tabelaDespesa;
        private RepositorioDespesa repositorioDespesa;

        public ControladorDespesa(RepositorioDespesa repositorioDespesa)
        {
            this.repositorioDespesa = repositorioDespesa;
        }

        public override string ToolTipInserir => "Inserir Despesa";

        public override string ToolTipEditar => "Editar Despesa";

        public override string ToolTipExcluir => "Excluir Despesa";

        public override void Editar()
        {
            TelaDespesasForm telaDespesasForm = new TelaDespesasForm();

            Despesa despesaSelecionada = ObterDespesaSelecionada();

            telaDespesasForm.ConfigurarTela(despesaSelecionada);

            DialogResult opcaoEscolhida = telaDespesasForm.ShowDialog();

            if(opcaoEscolhida == DialogResult.OK)
            {
                Despesa despesa = telaDespesasForm.ObterDespesa();

                repositorioDespesa.Editar(despesa.id, despesa);

                CarregarDespesas();
            }
        }

        private Despesa ObterDespesaSelecionada()
        {
            int id = tabelaDespesa.ObterIdSelecionado();

            Despesa despesa = repositorioDespesa.SelecionarPorId(id);

            return despesa;
        }

        public override void Excluir()
        {
            Despesa despesaSelecionada = ObterDespesaSelecionada();

            DialogResult opcaoEscolhida = MessageBox.Show($"Deseja mesmo excluir a despesa {despesaSelecionada.descricao}?",
                "Exclusão de Despesas", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if(opcaoEscolhida == DialogResult.OK )
            {
                repositorioDespesa.Excluir(despesaSelecionada);

                CarregarDespesas();
            }
        }

        public override void Inserir()
        {
            TelaDespesasForm telaDespesasForm = new TelaDespesasForm();

            DialogResult opcaoEscolhida = telaDespesasForm.ShowDialog();

            if(opcaoEscolhida == DialogResult.OK)
            {
                Despesa despesa = telaDespesasForm.ObterDespesa();

                repositorioDespesa.Inserir(despesa);

                CarregarDespesas();
            }  
        }

        public override UserControl ObterListagem()
        {
            if(tabelaDespesa == null)
                tabelaDespesa = new TabelaDespesaControl();

            CarregarDespesas();

            return tabelaDespesa;
        }

        private void CarregarDespesas()
        {
            List<Despesa> despesas = repositorioDespesa.SelecionarTodos();

            tabelaDespesa.AtualizarRegistros(despesas);
        }

        public override string ObterTipoCadastro()
        {
            return "Cadastro de Despesas";
        }
    }
}
