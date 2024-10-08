namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Dizinin Uzunluğunu Giriniz : ");
            int uzunluk = Convert.ToInt32(Console.ReadLine());
            int[] sayilar = new int[uzunluk];

            for (int i = 0; i < uzunluk; i++)
            {
                Console.WriteLine("Dizinin {0}. Elemanını Giriniz : ", i +1);
                sayilar[i] = int.Parse(Console.ReadLine());
            }
            int enBuyuk = EnBuyukBul(sayilar);
            Console.WriteLine("Dizinin En Büyük Sayısı : {0}", enBuyuk);
            int enKucuk = EnKucukBul(sayilar);
            Console.WriteLine("Dizinin En Küçük Sayısı : {0}", enKucuk);
            double ortalama = Ortalama(sayilar);
            Console.WriteLine("Sayıların Ortalaması : {0}", ortalama);
        }
        static int EnKucukBul(int[] dizi)
        {
            int enKucuk = dizi[0];
            foreach (int sayi in dizi)
            {
                if (sayi <enKucuk)
                {
                    enKucuk = sayi;
                }
            }
            return enKucuk;
        }
        static int EnBuyukBul(int[] dizi)
        {
            int enBuyuk = dizi[0];
            foreach (int sayi in dizi)
            {
                if (sayi > enBuyuk)
                {
                    enBuyuk = sayi;
                }
            }
            return enBuyuk;
        }
        static double Ortalama(int[] dizi)
        {
            double toplam = 0;
            foreach (int sayi in dizi)
            {
                toplam += sayi;
            }
            return toplam / dizi.Length;
        }
    }
}
