using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GhilA_InfoTest
{
    internal class GhilA_Candidato
    {
        private int _GhilA_Matricola;
        private string _GhilA_Nome;

        public int Matricola
        {
            get { return _GhilA_Matricola; }
            set { _GhilA_Matricola = value; }
        }
        public string Nome
        {
            get { return _GhilA_Nome; }
            set { _GhilA_Nome = value; }
        }

        public GhilA_Candidato()
        {
            _GhilA_Matricola = 0;
            _GhilA_Nome = null;
        }
        public GhilA_Candidato(int n)
        {
            _GhilA_Matricola = n;
            _GhilA_Nome = null;
        }
        public GhilA_Candidato(string s)
        {
            _GhilA_Matricola = 0;
            _GhilA_Nome = s;
        }
        public GhilA_Candidato(int n, string s)
        {
            _GhilA_Matricola = n;
            _GhilA_Nome = s;
        }

        abstract bool isIdoneo(string nome)
        {
            if (nome != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        abstract int punteggio(string nome)
        {
            if (nome != null)
            {
                return 0;
            }
            else
            {
                return 1;
            }
        }
    }
}
