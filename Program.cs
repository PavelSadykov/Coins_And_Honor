
        using System;
        using System.Collections.Generic;
        using System.Linq;
        using System.Text;
        using System.Threading.Tasks;

namespace ConsoleApp11
{
    class Program
    {
        static void Main(string[] args)
        {
            Gamers[] team1 = new Gamers[4];
            Gamers[] team2 = new Gamers[4];

            // Набор игроков
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine($"Введите имя {i + 1}-го игрока команды 1");
                string name = Console.ReadLine();
                team1[i] = new Gamers(name);

                Console.WriteLine($"Введите имя {i + 1}-го игрока команды 2");
                name = Console.ReadLine();
                team2[i] = new Gamers(name);
            }



            // Объединение игроков в команды
            int totalCoin1 = 0;
            int totalHonor1 = 0;
            int totalLuck1 = 1;
            int totalCoin2 = 0;
            int totalHonor2 = 0;
            int totalLuck2 = 1;


            string team1Name = "";
            string team2Name = "";

            for (int i = 0; i < 4; i++)
            {
                totalCoin1 += team1[i].GetCoin() ;
                totalHonor1 += team1[i].GetHonor() ;
                totalLuck1 *= team1[i].GetLuck();
                totalCoin2 += team2[i].GetCoin();
                totalHonor2 += team2[i].GetHonor();
                totalLuck2 *= team2[i].GetLuck();


                team1Name += team1[i].GetName() + " ";
                team2Name += team2[i].GetName() + " ";
               
                Console.WriteLine($"Игрок {team1[i].GetName()} команды 1: Монеты - {team1[i].GetCoin()}, Доблесть - {team1[i].GetHonor()}, Везучесть - {team1[i].GetLuck()}");
                Console.WriteLine($"Игрок {team2[i].GetName()} команды 2: Монеты - {team2[i].GetCoin()}, Доблесть - {team2[i].GetHonor()}, Везучесть - {team2[i].GetLuck()}");
            }

            Console.WriteLine("\nКоманда 1 ({0}): Монеты - {1}, Доблесть - {2}, Везучесть - {3}", team1Name, totalCoin1, totalHonor1, totalLuck1);
            Console.WriteLine("Команда 2 ({0}): Монеты - {1}, Доблесть - {2}, Везучесть - {3}", team2Name, totalCoin2, totalHonor2, totalLuck2);

            Console.WriteLine("\nКоманда 1 ({0}):", team1Name);
            Console.WriteLine("Монеты: {0}", totalCoin1);
            Console.WriteLine("Доблесть: {0}", totalHonor1);
            Console.WriteLine("Везучесть: {0}", totalLuck1);

            Console.WriteLine("\nКоманда 2 ({0}):", team2Name);
            Console.WriteLine("Монеты: {0}", totalCoin2);
            Console.WriteLine("Доблесть: {0}", totalHonor2);
            Console.WriteLine("Везучесть: {0}", totalLuck2);

            if (totalCoin1 > totalCoin2 || totalHonor1 > totalHonor2)
            {
                Console.WriteLine("Команда 1 побеждает по суммарным параметрам.");
            }
            else if (totalCoin1 < totalCoin2 || totalHonor1 < totalHonor2)
            {
                Console.WriteLine("Команда 2 побеждает по суммарным параметрам.");
            }
            else if (totalCoin1 == totalCoin2 && totalHonor1 == totalHonor2)
            {
                Console.WriteLine("Команды равны по суммарным параметрам. Победа определяется по везучести.");
                if (totalLuck1 > totalLuck2)
                {
                    Console.WriteLine("Команда 1 побеждает по везучести.");
                }
                else if (totalLuck1 < totalLuck2)
                {
                    Console.WriteLine("Команда 2 побеждает по везучести.");
                }
                else
                {
                    Console.WriteLine("Команды равны по везучести.");
                }
            }
          

        }
    }
}



