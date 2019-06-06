using System;
using System.Collections.Generic;

namespace COINS
{
    public class Program
    {
        public static void Main()
        {
            string input;
            while ((input = Console.In.ReadLine()) != null)
            {
                long coin = Convert.ToInt32(input);
                var list = new Dictionary<long, long>();
                long exchanged = FindTheBestExchange(ref list, coin);
                Console.WriteLine(exchanged);
            }
        }

        public static long FindTheBestExchange(ref Dictionary<long, long> past,long coin)
        {
            if (past.ContainsKey(coin))
                return past[coin];
            long[] exchanged = BankExchange(coin);
            long sum = SumOfThree(exchanged);
            if (sum > coin)
            {
                long x = FindTheBestExchange(ref past, exchanged[0]) + FindTheBestExchange(ref past, exchanged[1]) + FindTheBestExchange(ref past, exchanged[2]);
                past[coin] = x;
                return x;
            }
            return coin;
        }

        public static long SumOfThree(long[] coins)
        {
            return coins[0] + coins[1] + coins[2];
        }

        public static long[] BankExchange(long coin)
        {
            long [] coins = new long[3];
            coins[0] = coin / 2;
            coins[1] = coin / 3;
            coins[2] = coin / 4;
            return coins;
        }
    }
}
