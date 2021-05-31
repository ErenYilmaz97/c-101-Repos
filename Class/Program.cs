using System;

namespace Class
{
    class Program
    {
        static void Main(string[] args)
        {
            Calisan calisan1 = new Calisan("Eren","Yılmaz",312312,"Yazılım");
            


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


        public Calisan()
        {
            
        }


        public Calisan(string ad, string soyad)
        {
            this.Ad = ad;
            this.Soyad = soyad;
        }



        public Calisan(string ad, string soyad, int no, string departman):this(ad,soyad)
        {
            this.No = no;
            this.Departman = departman;
        }



        public void CalisanBilgileri()
        {
            Console.WriteLine($"Çalışan Adı : {Ad}");
            Console.WriteLine($"Çalışan Soyadı : {Soyad}");
            Console.WriteLine($"Çalışan Numarası : {No}");
            Console.WriteLine($"Çalışan Departmanı : {Departman}");
        }
    }
}
