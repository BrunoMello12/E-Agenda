using E_Agenda.WinFormsApp.Compartilhado;
using E_Agenda.WinFormsApp.ModuloCategorias;
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
        public TelaDespesasForm(List<Categoria> categorias)
        {
            InitializeComponent();

            this.ConfigurarDialog();

            CarregarFormasDePagamento();

            ConfigurarListaCategorias(categorias);
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

            Despesa despesa =  new Despesa(id, descricao, data, valor, formaPagamento);

            despesa.categorias.AddRange(listCategorias.CheckedItems.Cast<Categoria>());

            return despesa;
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

            int i = 0;

            for (int j = 0; j < listCategorias.Items.Count; j++)
            {
                Categoria categoria = (Categoria)listCategorias.Items[j];

                if (despesaSelecionada.categorias.Contains(categoria))
                {
                    listCategorias.SetItemChecked(i, true);
                }

                i++;
            }
        }

        public void ConfigurarListaCategorias(List<Categoria> categorias)
        {
            listCategorias.Items.Clear();

            listCategorias.Items.AddRange(categorias.ToArray());
        }

    }
}
