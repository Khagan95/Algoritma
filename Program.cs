using System;

namespace UcgenCizimUygulamasi
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Üçgenin boyutu: ");
            int boyut = Convert.ToInt32(Console.ReadLine());

            UcgenCizici ucgenCizici = new UcgenCizici();
            ucgenCizici.UcgenCiz(boyut);
        }
    }

    class UcgenCizici
    {
        public void UcgenCiz(int boyut)
        {
            for (int i = 1; i <= boyut; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}