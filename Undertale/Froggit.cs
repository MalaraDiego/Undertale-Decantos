using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Undertale
{
    public class Froggit : Mostro
    {   
        System.Windows.Forms.Timer t = new System.Windows.Forms.Timer();
        public override int Attacca()
        {
            int prob = rnd.Next(1, 11);
            if(prob <=4) return 2;
            return 0;
        }
        public void Salta()
        {
            t.Start();
            immagine.Location = new Point(immagine.Location.X , immagine.Location.Y+100);
            immagine.Location = new Point(immagine.Location.X, immagine.Location.Y-100);
            t.Stop();
        }
        public void Gira()
        {
            //cambia immagine della picture box --> usare un timer, utilizza animazioni
        }
        
        public override void Schiva()
        {
            t.Start();
            immagine.Location = new Point(immagine.Location.X+100, immagine.Location.Y);
            immagine.Location = new Point(immagine.Location.X - 100, immagine.Location.Y);
            t.Stop();
        }
        private void ticks(object sender, EventArgs e)
        {

        }
        public override void Azione(int danno, ref Personaggio p)
        {
            int c = rnd.Next(1,4);
            if(c == 1) p.setHp(Attacca());
            if(c == 2) Schiva(); 
            if(c == 3) Salta();
        }
        public Froggit(string immagine) : base(immagine)
        {
            hp = 8;
            nome = "Froggit";
            rnd = new Random();
            t.Tick += ticks;
            t.Interval = 100;
        }
        public override string ToString()
        {
            return $"{nome} - {hp}";
        }

    }
}
