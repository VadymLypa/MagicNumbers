using System;
using TechnicalTask.Interfaces;

namespace TechnicalTask
{
    public class MagicNumber : IMagicNumber
    {
        public int N { get; set; }
        public int K { get; set; }

        public MagicNumber()
        { }

        public MagicNumber(int n, int k)
        {
            N = n;
            K = k;
        }

        public void GetPart()
        {
            Console.Write("Result: ");
            for (int i = N; i <= K; i++)
                Console.Write($"{GetMagicNumber(i)} ");
        }

        private int GetMagicNumber(int number)
        {
            if (number == 1 || number == 2 || number == 3)
                return 1;
            else
                return GetMagicNumber(number - 1) + GetMagicNumber(number - 2) + GetMagicNumber(number - 3);
        }
    }
}
