using System;
using System.Text.RegularExpressions;

namespace Naloga2
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 53;
            
            Console.WriteLine($"{i,-6} preštevilo : {i.prastevilo(),5}");

            i = 5;
            Console.WriteLine($"{i,-6} preštevilo : {i.prastevilo(),5}");
            i = 4325;
            Console.WriteLine($"{i,-6} preštevilo : {i.prastevilo(),5}");
            i = 767;
            Console.WriteLine($"{i,-6} preštevilo : {i.prastevilo(),5}");



            string test = "NekoBesedilo lokololoko";
            string iskanoBesedilo= "o";
            Console.WriteLine($"Število pojavitev: {test.steviloBesed(iskanoBesedilo),5}");
            iskanoBesedilo = "ko";
            Console.WriteLine($"Število pojavitev: {test.steviloBesed(iskanoBesedilo),5}");

        }
    }



    //razred mora biti statičen!!!
    public static class Razsiritve
    {
        //razširitev je tudi statična
        public static bool prastevilo(this int stevilo)
        {
            //najprej preverimo, če je število 0 ali 1
            if (stevilo == 0 || stevilo == 1)
            {
                return false;
            }
            else
            {
                //preverimo ali je deljivo s katerim številom
                //tu bi lahko še nadgradili in delili samo z lihimi
                //(samo prvič z 2, ker če ni deljivo z 2 tudi s 4 ni!)
                for (int a = 2; a <= stevilo / 2; a++)
                {
                    if (stevilo % a == 0)
                    {
                        return false ;
                    }
                }
                return true;
            }
        }


        public static int steviloBesed(this string besedilo, string iskanoBesedilo) 
        {
            int odgovor = 0;
              string  s2 = besedilo.Replace(iskanoBesedilo, "");
            odgovor = (besedilo.Length - s2.Length) / iskanoBesedilo.Length;

            //drugi način
            //using System.Text.RegularExpressions;
            odgovor =  Regex.Matches(besedilo, iskanoBesedilo).Count;

            return odgovor;
        }

    }
}
