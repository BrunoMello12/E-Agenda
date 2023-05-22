using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace E_Agenda.WinFormsApp.ModuloContato
{
    public partial class ListaContatoControl : UserControl
    {

        public ListaContatoControl()
        {
            InitializeComponent();
        }

        public void AtualizarRegistros(List<Contato> contatos)
        {
            listContato.Items.Clear();

            foreach(Contato contato in contatos)
            {
                listContato.Items.Add(contato);
            }
        }

        public Contato ObterContatoSelecionado()
        {
            return (Contato)listContato.SelectedItem;
        }
    }
}
