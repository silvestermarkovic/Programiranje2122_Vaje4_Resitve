using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Naloga1
{
    public class Kvader : ITelo
    {
        int a, b, c;

        public Kvader(int a, int b, int c)
        {
            this.a = a;
            this.b = b;
            this.c = c;

        }
        public double povrsina()
        {
            return (2 * a * b + 2 * a * c + 2 * b * c);
        }

        public double volumen()
        {
            return (a * b * c);
        }
         public double najdaljsaDiagonala()
        {
            return Math.Sqrt(a * a+ b * b + c * c);
        }
     
    }

    public class Kocka : ITelo
    {
        public int a;
        public Kocka(int a)
        {
            this.a = a;
        }
        public double povrsina()
        {
            return 6 * a * a;
        }

        public double volumen()
        {
            return a * a * a;
        }
            public double najdaljsaDiagonala()
            {
                return Math.Sqrt(a * a + a * a + a * a);
            }
         
        }

    public class Krogla : ITelo
        {
            int radij = 0;

            public  Krogla(int radij)
            {
                this.radij = radij;
            } 
            public double povrsina()
            {
                return 4 * Math.PI * radij * radij;
            }

            public double volumen()
            {
                return (4/3) * Math.PI * radij * radij * radij;
            }

            public double najdaljsaDiagonala()
            {
                return 2 * radij;
            } 
    }
}
