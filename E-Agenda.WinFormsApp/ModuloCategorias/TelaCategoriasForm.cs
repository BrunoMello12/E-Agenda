using E_Agenda.Dominio.ModuloCategorias;
using E_Agenda.WinFormsApp.Compartilhado;
using E_Agenda.WinFormsApp.ModuloDespesas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace E_Agenda.WinFormsApp.ModuloCategorias
{
    public partial class TelaCategoriasForm : Form
    {
        public TelaCategoriasForm()
        {
            InitializeComponent();

            this.ConfigurarDialog();
        }

        public Categoria ObterCategoria()
        {
            int id = int.Parse(txtId.Text);
            string titulo = txtTitulo.Text;

            return new Categoria(id, titulo);
        }

        public void ConfigurarTela(Categoria categoriaSelecionada)
        {
            txtId.Text = categoriaSelecionada.id.ToString();
            txtTitulo.Text = categoriaSelecionada.titulo;
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            Categoria categoria = ObterCategoria();

            string[] erros = categoria.Validar();

            foreach (string erro in erros)
            {
                TelaPrincipalForm1.instancia.AtualizarRodape(erros[0]);

                DialogResult = DialogResult.None;
            }
        }
    }
}
