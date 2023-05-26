﻿using E_Agenda.WinFormsApp.Compartilhado;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Agenda.WinFormsApp.ModuloCompromisso
{
    public class RepositorioCompromisso : RepositorioBase<Compromisso>
    {

        public RepositorioCompromisso(List<Compromisso> compromissos)
        {
            listaRegistros = compromissos;
        }

        public List<Compromisso> SelecionarCompromissosFuturos()
        {
            List<Compromisso> compromissosFuturos = new List<Compromisso>();

            foreach(Compromisso item in listaRegistros)
            {
                if(item.data > DateTime.Now.Date)
                    compromissosFuturos.Add(item);
            }

            return compromissosFuturos;
        }

        public List<Compromisso> SelecionarCompromissosPassados()
        {
            List<Compromisso> compromissosPassados = new List<Compromisso>();

            foreach (Compromisso item in listaRegistros)
            {
                if (item.data < DateTime.Now.Date)
                    compromissosPassados.Add(item);
            }

            return compromissosPassados;
        }
    }
}
