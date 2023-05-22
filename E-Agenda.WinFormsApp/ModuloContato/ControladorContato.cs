using E_Agenda.WinFormsApp.Compartilhado;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Agenda.WinFormsApp.ModuloContato
{
    public class ControladorContato : ControladorBase
    {
        RepositorioContato repositorioContato;
        ListaContatoControl listagemContato;

        public ControladorContato(RepositorioContato repositorioContato)
        {
            this.repositorioContato = repositorioContato;
        }

        public override string ToolTipInserir { get { return "Inserir um novo Contato"; } }

        public override string ToolTipEditar { get { return "Editar um Contato existente"; } }

        public override string ToolTipExcluir { get { return "Excluir um Contato existente"; } }

        public override void Inserir()
        {
            TelaContatoForm telaContato = new TelaContatoForm();

            DialogResult opcaoEscolhida = telaContato.ShowDialog();

            if(opcaoEscolhida == DialogResult.OK)
            {
                Contato contato = telaContato.Contato;

                repositorioContato.Inserir(contato);

                CarregarContatos();
            }
        }

        private void CarregarContatos()
        {
            List<Contato> contatos = repositorioContato.SelecionarTodos();

            listagemContato.AtualizarRegistros(contatos);
        }

        public override UserControl ObterListagem()
        {
            if(listagemContato == null)
                listagemContato = new ListaContatoControl();

            CarregarContatos();

            return listagemContato;
        }

        public override string ObterTipoCadastro()
        {
            return "Cadastro de Contatos";
        }

        public override void Editar()
        {
            if (repositorioContato.contatoList.Count == 0) return;

            TelaContatoForm telaContato = new TelaContatoForm();

            telaContato.Contato = listagemContato.ObterContatoSelecionado();

            DialogResult opcaoEscolhida = telaContato.ShowDialog();

            if(opcaoEscolhida == DialogResult.OK)
            {
                Contato contato = telaContato.Contato;

                repositorioContato.Editar(contato);

                CarregarContatos();
            }
        }

        public override void Excluir()
        {
            if (repositorioContato.contatoList.Count == 0) return;

            Contato contato = listagemContato.ObterContatoSelecionado();

            DialogResult opcaoEscolhida = MessageBox.Show($"Deseja excluir o contato {contato.nome}?", "Exclusão de Contatos", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (opcaoEscolhida == DialogResult.OK)
            {
                repositorioContato.Excluir(contato);

                CarregarContatos();
            }
        }

        public override void Filtrar()
        {
            throw new NotImplementedException();
        }
    }
}
