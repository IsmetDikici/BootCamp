using System;

namespace DegerVeReferansTipler
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayi1 = 10;
            int sayi2 = 30;
            sayi1 = sayi2;
            sayi2 = 65;

            int[] sayilar1 = new int[] { 1, 2 };
            int[] sayilar2 = new int[] { 3, 4 };
            sayilar1 = sayilar2;
            sayilar2[0] = 500;
            Console.WriteLine(sayilar1[0]);
        }
    }
}