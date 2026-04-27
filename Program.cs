using System;

namespace BS_checker
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine(" Cate trofee ai pe brawler-ul tau preferat    ");
            int trofee = Convert.ToInt32(Console.ReadLine());

            if (trofee >= 4000)
            {
                Console.WriteLine("In Moldova nu exista playeri cu atatea trofee ");
            }
            else if (trofee >= 3000)
            {
                Console.WriteLine("Ai al 3-lea prime si esti top 1 in moldova ");
            }
            else if (trofee >= 2000)
            {
                Console.WriteLine("Ai al doilea prime si deja ajungi in top in Moldova ");
            }
            else if (trofee >= 1000)
            {
                Console.WriteLine(" Ai primul prime  ");
            }
            else if (trofee >= 500)
            {
                Console.WriteLine("Mai ai inca pana la primul prime ");
            }
            else if (trofee >= 0)
            {
                Console.WriteLine("De abia ai inceput sa joci cu acest personaj ");
            }
            else
            {
                System.Console.WriteLine("Nu exista atatea trofeuri  ");
            }









        }
    }
}