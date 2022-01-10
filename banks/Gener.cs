using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace banks
{
    static public class Gener
    {
        private static string rand;
        private static Random random = new Random();

        public static string Rand { get => rand; set => rand = value; }
        public static Random Random { get => random; set => random = value; }

        public static string Randm(uint rnd)
        {
            for (int i = 0; i < rnd; i++)
            {
                Rand += Random.Next(0, 9).ToString();
            }
            return Rand;
        }

    }
}
