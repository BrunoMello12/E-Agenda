using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Agenda.WinFormsApp.Compartilhado
{
    public abstract class ControladorBase
    {
        public abstract string ToolTipInserir { get; }

        public abstract string ToolTipEditar { get; }

        public abstract string ToolTipExcluir { get; }

        public virtual string ToolTipFiltrar { get; }

        public virtual string ToolTipAdicionar { get; }

        public virtual bool InserirHabilitado { get { return true; } }
        public virtual bool EditarHabilitado { get { return true; } }
        public virtual bool ExcluirHabilitado { get { return true; } }

        public virtual bool FiltrarHabilitado { get { return false; } }
        public virtual bool AdicionarItensHabilitado { get { return false; } }
        public virtual bool ConcluirItensHabilitado { get { return false; } }


        public abstract void Inserir();

        public abstract UserControl ObterListagem();

        public abstract string ObterTipoCadastro();

        public abstract void Editar();

        public abstract void Excluir();

        public virtual void Filtrar() { }

        public virtual void Adicionar() { }

        public virtual void Atualizar() { }
    }
}
