using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Undertale
{
    public class Kunigami : Personaggio
    {
        public override int Attacca()
        {
            return 3;
        }

        public int BodyBlock()
        {
            return 5;
        }

        public int PowerShot()
        {
            return 8; //salta il turno dopo
        }

        public override void Azione(int indice,ref Mostro m)
        {
            if(indice == -1)
            {
                m.setHp(Attacca());

            }
            else
            {
                if (indice == 0) m.setHp(PowerShot());
                if (indice == 1) m.setHp(BodyBlock());
            }
        }
        public Kunigami(string i) : base(i) 
        {
            hp = 30;
            maxHp = 30;
            nome = "Kunigami";
        }
        public override string ToString()
        {
            return $"{nome} - {hp}";
        }
    }
}
