using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Undertale
{
    public class Clover : Personaggio
    {
        private int colpi=0;

        public int GetColpi()
        {
            return colpi;
        }
        public override int Attacca()
        {
            return 3;
        }

        public int Spara()
        {   
            if (colpi > 0)
            {
                return 6;
                colpi--;
            }
            else
            {
                throw new Exception("Non hai colpi");
            }
            
        }
        public void Ricarica()
        {
            colpi++;
        }
        public override void Azione(int indice,ref Mostro m)
        {
            if (indice == -1)
            {
                m.setHp(Attacca());

            }
            else
            {
                if (indice == 0) m.setHp(Spara());
                if (indice == 1) Ricarica();
            }
        }
        public Clover(string i) : base(i) 
        {
            maxHp = 25;
            hp = 25;
            colpi = 6;
        }

        public override string ToString()
        {
            return $"{nome} - {hp}";
        }
    }
}
