using System;
using System.Collections.Generic;

namespace Naloga1
{
    class Program
    {
        static void Main(string[] args)
        {

            Kocka ko1 = new Kocka(5);
            Kocka ko2 = new Kocka(7);
            List<ITelo> seznam = new List<ITelo>();
            seznam.Add(ko1);
            seznam.Add(ko2);


            Kvader pr1 = new Kvader(5,6,7);
            Kvader pr2 = new Kvader(5,7,6);
            Kvader pr3 = new Kvader(5, 5, 5);
            seznam.Add(pr1);
            seznam.Add(pr2);
            seznam.Add(pr3);


            Krogla kr1 = new Krogla(5);
            Krogla kr2 = new Krogla(9);
            seznam.Add(kr1);
            seznam.Add(kr2);


            foreach (ITelo  aa in seznam) {
                aa.izpis();
            }

 
 
        }
    }

    public static class Razsiritve
    {
        public static bool IsGreaterThan(this int i, int value)
        {
            return i > value;
        }
        public static void izpis(this ITelo aaa)
        {
            Console.WriteLine($"Povšrina: {aaa.povrsina()}");
            Console.WriteLine($"Volumen: {aaa.volumen()}");

            //dodamo kasneje
            // Console.WriteLine($"Volumen: {aaa.najdaljsaDiagonala()}");   
        }

    }
    

    abstract class Shape
    {

        // abstract method
        public   int area()
        {
            return 5;
        }
    }

    class Square : Shape
    {
       
    }
}
