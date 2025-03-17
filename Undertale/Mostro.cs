using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Undertale
{
    public abstract class Mostro
    {
        protected int hp;
        protected PictureBox immagine;
        protected Random rnd;
        protected string nome;
        public int GetHp()
        {
            return hp;
        }

        public void setHp(int danno)
        {   
            if (hp - danno < 0)
            {
                hp = 0;
            }
            else
            {
                hp -= danno;
            }
               
        }

        public abstract int Attacca();
        public abstract void Schiva();
        public abstract void Azione(int danno, ref Personaggio p); 
        
        public PictureBox getSprite()
        {
            return immagine;
        }

        public Mostro(string immagine)
        {
            this.immagine = new PictureBox();
            this.immagine.Location = new Point(385, 40);
            this.immagine.BackColor = Color.Red;
            this.immagine.Size = new Size(200, 200);
           this.immagine.Image = Image.FromFile(immagine);
            this.immagine.SizeMode = PictureBoxSizeMode.StretchImage;
        }

    }
}
