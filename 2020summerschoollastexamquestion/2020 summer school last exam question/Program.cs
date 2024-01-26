using System;

namespace SummerSchoolLastExam
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Alt degeri girin: ");
            if (!int.TryParse(Console.ReadLine(), out int altDeger))
            {
                Console.WriteLine("Hatalı giriş. Tam sayı bekleniyor.");
                return;
            }

            Console.WriteLine("Ust degeri girin: ");
            if (!int.TryParse(Console.ReadLine(), out int ustDeger))
            {
                Console.WriteLine("Hatalı giriş. Tam sayı bekleniyor.");
                return;
            }

            Console.WriteLine("Adet girin: ");
            if (!int.TryParse(Console.ReadLine(), out int adet))
            {
                Console.WriteLine("Hatalı giriş. Tam sayı bekleniyor.");
                return;
            }

            // Rastgele bir dizi üretmek için Islemler.Uret metodunu kullanma
            int[] dizi = Islemler.Uret(altDeger, ustDeger, adet);

            // Üretilen diziyi ekrana yazdırma
            foreach (var item in dizi)
            {
                Console.WriteLine(item);
            }

            // Oluşturulan dizinin uzunluğunu kullanarak kaç adet çıktı verdiğini yazdırma
            Console.WriteLine($"Oluşturulan dizinin uzunluğu (adet): {dizi.Length}");

            Console.ReadLine();
        }
    }

    class Islemler
    {
        // Belirtilen aralıkta rastgele sayılar üreten metot
        public static int[] Uret(int baslangic, int bitis, int adet)
        {
            Random rasgele = new Random();
            int[] dizi = new int[adet];

            // Belirtilen adet kadar rastgele sayı üretme ve diziye ekleme
            for (int i = 0; i < dizi.Length; i++)
            {
                dizi[i] = rasgele.Next(baslangic, bitis);
            }

            // Üretilen diziyi geri döndürme
            return dizi;
        }
    }
}
