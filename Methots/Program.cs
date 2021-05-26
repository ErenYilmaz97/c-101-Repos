using System;

namespace Methots
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 2;
            int b = 3;
            Console.WriteLine(a + b);

            int sonuc = Topla(a, b);
            Console.Write(sonuc);

            Methotlar ornek = new Methotlar();
            ornek.EkranaYazdir(Convert.ToString(sonuc));


            int sonuc2 = ornek.ArttirveTopla(a, b);
            ornek.EkranaYazdir(Convert.ToString(sonuc2));
            ornek.EkranaYazdir(Convert.ToString(a + b));
        }



        static int Topla(int deger1, int deger2)
        {
            return deger1 + deger2;
        }
    }


    class Methotlar
    {
        public void EkranaYazdir(string veri)
        {
            Console.WriteLine(veri);
        }

        public int ArttirveTopla(int deger1, int deger2)
        {
            deger1 += 1;
            deger2 += 2;
            return deger1 + deger2;
        }
    }
}
