using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Undertale
{
    public class Items
    {
        private string nome;
        private int cura;
        public string Nome
        {
            get { return nome; }
            set
            {
                if(string.IsNullOrEmpty(value) || value.Length < 3)
                {
                    throw new Exception();
                }
                nome = value;
            }
        }

        public int Cura
        {
            get { return cura; }
            set
            {
                if (value < 0)
                {
                    throw new Exception();
                }
                cura = value;
            }
        }

        public Items(string n, int c) {
            Nome = n;
            Cura = c;
        }

        public override string ToString()
        {
            return $"{Nome} {Cura}";
        }
    }
}
