using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TI_NET_2023_DemoOO_RPG.Utils
{
    public enum DiceType
    {
        D4 = 4,
        D6 = 6,
        D8 = 8,
        D10 = 10,
        D20 = 20,
        D100 = 100
    }

    public static class Dice
    {
        private static int Throw(DiceType d)
        {
            Random r = new Random();
            return r.Next((int)d) + 1;
        }

        public static int Throws(DiceType d, int nbDice = 1, int nbToKeep = 1)
        {
            List<int> throws = new List<int>();

            for (int i = 0; i < nbDice; i++)
            {
                throws.Add(Throw(d));
            }

            return throws.OrderByDescending(nb => nb).Take(nbToKeep).Sum();
        }
    }
}
