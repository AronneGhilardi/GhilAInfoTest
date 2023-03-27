using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GhilA_InfoTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<GhilA_Candidato> lista = new List<GhilA_Candidato>();

        public void Aggiungere(GhilA_Candidato y)
        {
            lista.Add(y);
        }

        public string[] Visualizza(List<GhilA_Candidato> y)
        {
            string[] s = new string[999];
            int i = 0;
            foreach (GhilA_Candidato x in lista)
            {
                s[i] = x.ToString();
                i++;
            }
            return s;
        }

        public void Modificare(string nome, int NrMatricola)
        {
            for (int i = 0; i < lista.Count; i++)
            {
                if (lista[i].Matricola == NrMatricola)
                {
                    lista[i].Nome = nome;
                }
            }
        }

        public void Eliminare(int NrMatricola)
        {
            for (int i = 0; i < lista.Count; i++)
            {
                if (lista[i].Matricola == NrMatricola)
                {
                    lista[i] = null;
                }
            }
        }

        public void VisualizzareIdonei()
        {
            string[] s = new string[999];
            int i = 0;
            foreach (GhilA_Candidato x in lista)
            {
                bool b = x.isIdoneo();
                if (b == true)
                {
                    s[i] = x.ToString();
                    i++;
                }
            }
            return s;
        }
    }
}
