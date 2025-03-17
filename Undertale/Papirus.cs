using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Undertale
{
    public class Papirus : Mostro
    {
        public override int Attacca()
        {
            int prob = rnd.Next(1, 11);
            if (prob <= 4) return 4;
            return 0;
        }
        
        public void Cura()
        {
            hp += 3;
        }
        public void Difendi(int dannoSubito)
        {
            if (hp - (dannoSubito-2) < 0)
            {
                hp = 0;
            }
            else
            {
                hp -= (dannoSubito-2);
            }
        }
        public override void Schiva()
        {
            immagine.Location = new Point(immagine.Location.X + 100, immagine.Location.Y);
        }
        public override void Azione(int d, ref Personaggio p)
        {
            int perc = rnd.Next(1, 101);
            if (hp == 35)
            {
                if (perc <= 75)
                {
                    p.setHp(Attacca());
                }
                if (perc > 75 && perc <= 90)
                {
                   Cura();
                }
                if (perc > 90)
                {
                    Difendi(d);
                }
            }
            if (hp < 10)
            {
                if (perc <= 50)
                {
                    p.setHp(Attacca());
                }
                if (perc > 50 && perc <= 80)
                {
                    Cura();
                }
                if (perc > 80)
                {
                    
                  Difendi(d);
                }
            }

            if (hp < 5)
            {
                if (perc <= 30)
                {
                    p.setHp(Attacca());
                }
                if (perc > 30 && perc <= 80)
                {
                    Cura();
                }
                if (perc > 80)
                {
                    Difendi(d);

                }
            }

        }
        public Papirus(string immagine) : base(immagine) 
        {
            hp = 20;
            nome = "Papirus";
            rnd = new Random();
        }
        public override string ToString()
        {
            return $"{nome} - {hp}";
        }
    }
}
