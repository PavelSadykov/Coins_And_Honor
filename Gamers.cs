using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;


namespace ConsoleApp11
{
    class Gamers
    {
        static private int myRandom()
        {
            Random random = new Random();
            var currentTime = DateTime.Now.Millisecond;
            int Number = currentTime;
            Number *= Number;
            int _myRandom = 1 + random.Next(Number) % 100;
            return _myRandom;
        }

        private string name;
        private int coin;
        private int honor;
        private int luck;

        public Gamers(string name)
        {
            this.name = name;
            coin = myRandom();
            honor = 100;
            luck = myRandom();
        }

        public string GetName()
        {
            return name;
        }

        public int GetCoin()
        {
            return coin;
        }

        public int GetHonor()
        {
            return honor;
        }

        public int GetLuck()
        {
            return luck;
        }

        public static bool operator <(Gamers player1, Gamers player2)
        {
            return player1.coin * player1.honor * player1.luck < player2.coin * player2.honor * player2.luck;
        }

        public static bool operator >(Gamers player1, Gamers player2)
        {
            return player1.coin * player1.honor * player1.luck > player2.coin * player2.honor * player2.luck;
        }
    }
}


