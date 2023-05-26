using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace E_Agenda.WinFormsApp.Compartilhado
{
    public static class FormExtension
    {
        public static void ConfigurarDialog(this Form form)
        {
            form.StartPosition = FormStartPosition.CenterScreen;
            form.MinimizeBox = false;
            form.MaximizeBox = false;
            form.FormBorderStyle = FormBorderStyle.FixedDialog;
            form.ShowIcon = false;
            form.ShowInTaskbar = false;
        }
    }
}
