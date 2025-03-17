using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Undertale
{
    public class GestoreGioco
    {
        Mostro a;
        Personaggio b;
        SchermataStart sch;
        private bool turnogioc;
        public void Gioco(Panel p)
        {   
            if(sch.getSchermata().IsDisposed) {
                if (sch.getDati() != null && a == null && b == null)
                {
                    // Selezione del personaggio (indice 0)
                    switch (sch.getDati()[0])
                    {
                        case "Frisk":
                            b = new Frisk("frisk.png");
                            p.Controls.Add(b.getSprite());
                            break;
                        case "Clover":

                            b = new Clover("clover.png");
                            p.Controls.Add(b.getSprite());
                            break;
                        case "Kunigami":

                            b = new Kunigami("kunigami.png");
                            p.Controls.Add(b.getSprite());
                            break;
                        default:
                            throw new ArgumentException("Seleziona un personaggio");

                    }

                    // Selezione del mostro (indice 1)
                    switch (sch.getDati()[1])
                    {
                        case "Froggit":
                            a = new Froggit("froggit.png");
                            p.Controls.Add(a.getSprite());
                            break;
                        case "Papirus":
                            a = new Papirus("papirus.png");
                            p.Controls.Add(a.getSprite());
                            break;
                        case "Asgore":
                            a = new Asgore("asgore.png");
                            p.Controls.Add(a.getSprite());
                            break;
                        default:
                            throw new ArgumentException("Seleziona un mostro");

                    }
                }

            }
        }

        public Panel RS() //return schermata
        {
            return sch.getSchermata();
        }
        public List<string> RD() //return dati
        {
            return sch.getDati();
        }

        public void Attacca(int i)
        {   
            if (turnogioc)
            {
                b.Azione(i,ref a);
                turnogioc = false;
            }
            else
            {
                a.Azione(b.Attacca(), ref b);
                turnogioc = true;
            }
            
        }

        public int HpGiocatore()
        {
            return b.getHp();
        }

        public int HpMostro()
        {
            return a.GetHp();
        }

        public List<Items> RitornaInventario()
        {
            return b.items();
        }

        public void UsaItem(Items i)
        {
            b.UsaItem(i);
        }

        public List<string> getMosse()
        {
            List<string> list = new List<string>();
            if (b is Kunigami) { list.Add("BodyBlock"); list.Add("PowerShot"); }
            if (b is Clover) { list.Add("Ricarica"); list.Add("Spara"); }
            if (b is Frisk) { list.Add("SuperSlash");}
            return list;
        }
        public GestoreGioco() {
            
            sch = new SchermataStart();
            turnogioc = true;


        }

    }
}
