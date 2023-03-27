using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GhilA_InfoTest
{
    public abstract class GhilA_Disoccupato : GhilA_Candidato
    {
        public int _GhilA_Voto;
        public bool _GhilA_Lode;

        public int GhilA_Voto
        {
            set
            {
                if (value >= 0 && value <= 110)
                {
                    _GhilA_Voto = value;
                }
                else
                {
                    throw new Exception("ERRORE! Il VOTO non è valido.");
                } 
            }
            get
            {
                return _GhilA_Voto;
            }
        }

        public bool GhilA_Lode
        {
            set
            {
                if (_GhilA_Voto == 110)
                {
                    try
                    {
                        _GhilA_Lode = value;
                    }
                    catch
                    {
                        throw new Exception("ERRORE! La LODE non può essere applicata.");
                    }
                }
                else
                {
                    throw new Exception("ERRORE! La LODE non può essere applicata.");
                }   
            }
            get
            {
                return _GhilA_Lode;
            }
        }

        public GhilA_Disoccupato()
        {
            _GhilA_Voto = 0;
            _GhilA_Lode = false;
        }

        public GhilA_Disoccupato(int voto, bool lode)
        {
            GhilA_Voto = voto;
            GhilA_Lode = lode;
        }

        public override int punteggio()
        {
            int a = (GhilA_Voto * 100) / 110;
            if (GhilA_Lode == true)
            {
                a += 5;
            }
            return a;
        }


        public override bool isIdoneo()
        {
            if(punteggio() >= 72)
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
            string s = Matricola + ", " + Nome + ", " + GhilA_Voto + ", " + GhilA_Lode;
            return s;
        }

        public bool Equals(GhilA_Disoccupato x)
        {
            if (x == null)
            {
                return false;
            }
            if (this == x)
            {
                return true;
            }
            if (this.Matricola == x.Matricola || this.Nome == x.Nome || this.GhilA_Voto == x.GhilA_Voto || this.GhilA_Lode == x.GhilA_Lode)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool CompareTo(GhilA_Disoccupato x)
        {
            if (this.punteggio() == x.punteggio())
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public override int GetHashCode()
        {
            return (Matricola, Nome, GhilA_Voto, GhilA_Lode).GetHashCode();
        }
    }
}
