using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Undertale
{
    public abstract class Personaggio
    {
        protected int hp;
        protected string nome;
        protected List<Items> inventario;
        protected PictureBox sprite;
        protected int maxHp;
        public abstract int Attacca();
        public void UsaItem(Items selezionato)

        {
            try
            {
                if (selezionato != null)
                {
                    if (hp + selezionato.Cura > maxHp)
                    {
                        hp = maxHp;
                        inventario.Remove(selezionato);
                    }
                    else
                    {
                        hp += selezionato.Cura;
                        inventario.Remove(selezionato);
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Seleziona un item");
            }
           
           
            
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

        public int getHp() { return hp; }

        public PictureBox getSprite()
        {
            return sprite;
        }

        public List<Items> items()
        {
            return inventario;
        }
        public abstract void Azione(int indice, ref Mostro m);
        public Personaggio(string immagine)
        {
            inventario = new List<Items>() { new Items("poz_cura",10), new Items("legendary_hero",4), new Items("mechaton_steak",8), new Items("cinnamon_pie", 15)}; 
            sprite = new PictureBox();
            sprite.Location = new Point(33, 238);
            sprite.Size = new Size(200, 200);
            sprite.BackColor = Color.Green;
            sprite.Image = Image.FromFile(immagine);
            this.sprite.SizeMode = PictureBoxSizeMode.StretchImage;
        }
    }
}
