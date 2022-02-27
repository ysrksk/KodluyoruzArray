using System;

namespace Array2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Dizi Tanımlama
            string[] renkler = new string[1];
            string[] hayvanlar = {"kedi","Köpek", "Kuş", "Maymun"};


            int[] dizi;
            dizi = new int[5];

            //Dizilere değer atama
            renkler[0] = "mavi";
            dizi[3] = 10;

            System.Console.WriteLine(hayvanlar[1]);
            System.Console.WriteLine(dizi[3]);
            System.Console.WriteLine(renkler[0]);

            //Döngüler dizi kullanımı
            //Klavyeden girilen n tane sayının ortalamassını hesaplayan program

            System.Console.WriteLine("Lütfen dizinin eleman sayısını giriniz: ");
            int diziUzunlığu = int.Parse(Console.ReadLine());
            int[] sayiDizisi = new int[diziUzunlığu];

            for (int i = 0; i < diziUzunlığu; i++)
            {
                System.Console.WriteLine("Lütfen {0}. sayısını giriniz", i+1);
                sayiDizisi[i] = int.Parse(Console.ReadLine());
            }

            int toplam = 0;
            foreach (var sayi in sayiDizisi)
            {
                toplam += sayi;
            }

            System.Console.WriteLine("Ortalama: " + toplam/diziUzunlığu);

        }
    }
}
