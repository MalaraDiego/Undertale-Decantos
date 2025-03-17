using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Undertale
{
    public class Frisk : Personaggio
    {
        public override int Attacca()
        {
            return 4;
        }

       

        public int SuperSlash()
        {
            return 8;
        }

        public override void Azione(int indice, ref Mostro m)
        {
            if (indice == -1)
            {
                m.setHp( Attacca());

            }
            else
            {
                if (indice == 0) m.setHp(SuperSlash());
                
            }
        }
        public Frisk(string i) : base(i) 
        {
            hp = 20;
            maxHp = 20;
            nome = "Frisk";
        }

        public override string ToString()
        {
            return $"{nome} - {hp}";
        }
    }
}
