using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GhilA_InfoTest
{
    public abstract class GhilA_Candidato
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

        public abstract bool isIdoneo();

        public abstract int punteggio();


        public override string ToString()
        {
            string s = Matricola + ", " + Nome;
            return s;
        }

        public bool Equals(GhilA_Candidato x)
        {
            if (x == null)
            {
                return false;
            }
            if (this == x)
            {
                return true;
            }
            if (this.Matricola == x.Matricola || this.Nome == x.Nome)
            {
                return true;
            }
            else
            {
                return false;
            }    
        }

        public int CompareTo(GhilA_Candidato other)
        {
            if (other == null)
            {
                return 1;
            }
            if (this.punteggio() == other.punteggio())
            {
                return 0;
            }
            else if (this.punteggio() < other.punteggio())
            {
                return -1;
            }
            else
            {
                return 1;
            }
        }

        public override int GetHashCode()
        {
            return (Matricola, Nome).GetHashCode();
        }
    }
}
