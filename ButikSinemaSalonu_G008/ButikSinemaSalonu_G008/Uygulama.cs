using System;
using System.Collections.Generic;
using System.Text;

namespace ButikSinemaSalonu_G008
{
    class Uygulama
    {

        Sinema Snm;

        public void Calistir()
        {
            Kur();
            Menu();

            while (true)
            {
                Console.WriteLine();
                string secim = SecimAl();
                Console.WriteLine();
                switch (secim)
                {
                    case "1":
                    case "S":
                        BiletSat();
                        break;

                    case "2":
                    case "İ":
                        BiletIade();
                        break;

                    case "3":
                    case "D":
                        DurumBilgisi();
                        break;
                    case "4":
                    case "X":
                        return;
                }

            }


        }





        public void Kur()
        {
            Console.WriteLine("-------Butik Sinema Salonu-------");
            Console.Write("Film adı:");
            string ad = Console.ReadLine();
            Console.Write("Kapasite:");
            int kap = int.Parse(Console.ReadLine());
            Console.Write("Tam Bilet Fiyatı:");
            int tam = int.Parse(Console.ReadLine());
            Console.Write("Yarım Bilet Fiyatı:");
            int yarim = int.Parse(Console.ReadLine());
            Snm = new Sinema(ad, kap, tam, yarim);
        }

        public void Menu()
        {
            Console.WriteLine("1 - Bilet Sat(S)     ");
            Console.WriteLine("2 - Bilet İade(İ)    ");
            Console.WriteLine("3 - Durum Bilgisi(D) ");
            Console.WriteLine("4 - Çıkış(X)         ");
        }

        public string SecimAl()
        {
            Console.Write("Seçiminiz: ");
            return Console.ReadLine().ToUpper();
        }

        public void BiletSat()
        {
            Console.WriteLine("Bilet Sat:");
            Console.Write("Tam Bilet Adedi:");
            int tam = int.Parse(Console.ReadLine());
            Console.Write("Yarım Bilet Adedi:");
            int yarim = int.Parse(Console.ReadLine());

            bool result = Snm.BiletSat(tam, yarim);

            if (result)
            {
                Console.WriteLine("İşlem gerçekleştirildi.");
            }
            else
            {
                Console.WriteLine("Yeterli boş koltuk kalmadı.");
            }

        }


        public void BiletIade()
        {
            Console.WriteLine("Bilet İade:");
            Console.Write("Tam Bilet Adedi:");
            int tam = int.Parse(Console.ReadLine());
            Console.Write("Yarım Bilet Adedi:");
            int yarim = int.Parse(Console.ReadLine());

            bool result = Snm.BiletIade(tam, yarim);

            if (result)
            {

                Console.WriteLine("İşlem gerçekleştirildi.");
            }
            else
            {
                Console.WriteLine("İade işlemi gerçekleştirilmedi.");
            }
        }



        public void DurumBilgisi()
        {


            Console.WriteLine("Durum Bilgisi");
            Console.WriteLine("Film: " + Snm.FilmAdi);
            Console.WriteLine("Kapasite: " + Snm.Kapasite);
            Console.WriteLine("Ciro: " + Snm.Ciro);
            Console.WriteLine("Boş Koltuk Adedi: " + Snm.BosKoltuk());
            Console.WriteLine("Tam Bilet Adedi : " + Snm.ToplamTamBiletAdedi);
            Console.WriteLine("Yarım Bilet Adedi : " + Snm.ToplamYarimBiletAdedi);
            Console.WriteLine("Tam Bilet Fiyatı : " + Snm.TamBiletFiyati);
            Console.WriteLine("Yarım Bilet Fiyatı : " + Snm.YarimBiletFiyati);

        }



    }
}
