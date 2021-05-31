using System;

namespace Class
{
    class Program
    {
        static void Main(string[] args)
        {
            Calisan calisan1 = new Calisan();
            calisan1.Ad = "Eren";
            calisan1.Soyad = "Yılmaz";
            calisan1.No = 32131231;
            calisan1.Departman = "Yazılım";


            Calisan calisan2 = new Calisan();
            calisan1.Ad = "Deniz";
            calisan1.Soyad = "Arda";
            calisan1.No = 32131231;
            calisan1.Departman = "Pazarlama";

            calisan1.CalisanBilgileri();
            calisan2.CalisanBilgileri();
        }
    }


    class Calisan
    {
        public string Ad;
        public string Soyad;
        public int No;
        public string Departman;


        public void CalisanBilgileri()
        {
            Console.WriteLine($"Çalışan Adı : {Ad}");
            Console.WriteLine($"Çalışan Soyadı : {Soyad}");
            Console.WriteLine($"Çalışan Numarası : {No}");
            Console.WriteLine($"Çalışan Departmanı : {Departman}");
        }
    }
}
