﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GhilA_InfoTest
{
    public abstract class GhilA_Lavoratore : GhilA_Candidato
    {
        public int _GhilA_Esperienze;

        public int GhilA_Esperienze
        {
            set
            {
                if (value <= 5)
                {
                    _GhilA_Esperienze = value;
                }
                else
                {
                    throw new Exception("ERRORE! Il numero di Esperienze non è valido.");
                }
            }
            get
            {
                return _GhilA_Esperienze;
            }
        }

        public GhilA_Lavoratore()
        {
            _GhilA_Esperienze = 0;
        }

        public GhilA_Lavoratore(int esperienze, int matricola, string nome) : base(matricola, nome)
        {
            GhilA_Esperienze = esperienze;
        }

        public override int punteggio()
        {
            int a = GhilA_Esperienze * 20;
            return a;
        }

        public override bool isIdoneo()
        {
            if (punteggio() >= 60)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        public override string ToString()
        {
            string s = Matricola + ", " + Nome + ", " + GhilA_Esperienze;
            return s;
        }

        public bool Equals(GhilA_Lavoratore x)
        {
            if (x == null)
            {
                return false;
            }
            if (this == x)
            {
                return true;
            }
            if (this.Matricola == x.Matricola || this.Nome == x.Nome || this.GhilA_Esperienze == x.GhilA_Esperienze)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public int CompareTo(GhilA_Lavoratore other)
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
            return (Matricola, Nome, GhilA_Esperienze).GetHashCode();
        }
    }
}
