using E_Agenda.WinFormsApp.Compartilhado;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace E_Agenda.WinFormsApp.ModuloDespesas
{
    public partial class TelaDespesasForm : Form
    {
        public TelaDespesasForm()
        {
            InitializeComponent();

            this.ConfigurarDialog();

            CarregarFormasDePagamento();
        }

        public void CarregarFormasDePagamento()
        {
            FormaPagamentoEnum[] formasPagamentos = Enum.GetValues<FormaPagamentoEnum>();

            foreach (FormaPagamentoEnum formaPagamento in formasPagamentos)
            {
                cmbPagamento.Items.Add(formaPagamento);
            }
        }

        public Despesa ObterDespesa()
        {
            int id = int.Parse(txtId.Text);
            DateTime data = txtData.Value;
            string descricao = txtDescricao.Text;
            string valor = txtValor.Text;

            FormaPagamentoEnum formaPagamento = (FormaPagamentoEnum)cmbPagamento.SelectedItem;

            return new Despesa(id, descricao, data, valor, formaPagamento);
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            Despesa despesa = ObterDespesa();

            string[] erros = despesa.Validar();

            if(erros.Length > 0)
            {
                TelaPrincipalForm1.instancia.AtualizarRodape(erros[0]);

                DialogResult = DialogResult.None;
            }
        }

        public void ConfigurarTela(Despesa despesaSelecionada)
        {
            txtId.Text = despesaSelecionada.id.ToString();
            txtDescricao.Text = despesaSelecionada.descricao;
            txtValor.Text = despesaSelecionada.valor.ToString();
            txtData.Value = despesaSelecionada.data.Date;
            cmbPagamento.Text = despesaSelecionada.formaPagamento.ToString();
        }
    }
}
