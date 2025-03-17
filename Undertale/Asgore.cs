﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Undertale
{
    public class Asgore : Mostro
    {
        public override int Attacca()
        {
            int prob = rnd.Next(1, 11);
            if (prob <= 4) return 7;
            return 0;
        }
        
        public void Cura()
        {
            hp += 3;
        }
        public int NTB()
        {
            return 2;
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
        public int ColpoSicuro()
        {
            return 7;
        }
        public override void Schiva()
        {
            immagine.Location = new Point(immagine.Location.X + 100, immagine.Location.Y);
        }

        public override void Azione(int d, ref Personaggio p)
        {
            int perc = rnd.Next(1, 101);
            if(hp == 35)
            {
                if (perc <= 75)
                {
                    p.setHp(Attacca());
                }
                if(perc > 75 && perc <= 85)
                {
                    p.setHp(ColpoSicuro());
                }
                if(perc > 85)
                {
                    int choice = rnd.Next(1,4);
                    if (choice == 1) NTB();
                    if (choice == 2) Cura();
                    if (choice == 3) Difendi(d);
                }
            }
            if (hp <20)
            {
                if (perc <= 50)
                {
                    p.setHp(Attacca());
                }
                if (perc > 50 && perc <= 75)
                {
                    p.setHp(ColpoSicuro());
                }
                if (perc > 75)
                {
                    int choice = rnd.Next(1, 4);
                    if (choice == 1) NTB(); //una volta ogni 2 turni
                    if (choice == 2) Cura();
                    if (choice == 3) Difendi(d);
                }
            }

            if (hp < 7)
            {
                if (perc <= 30)
                {
                    p.setHp(Attacca());
                }
                if (perc > 30 && perc <= 80)
                {
                    p.setHp(ColpoSicuro());
                }
                if (perc > 80)
                {
                    int choice = rnd.Next(1, 4);
                    if (choice == 1) NTB();
                    
                }
            }

        }

        public Asgore(string immagine) : base(immagine) 
        {
            hp = 35;
            nome = "Asgore";
            rnd = new Random();
        }

        public override string ToString()
        {
            return $"{nome} - {hp}";
        }
    }
}
