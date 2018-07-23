using System;
using TechnicalTask.Excepitons;

namespace TechnicalTask
{
    class Program
    {
        static void Main(string[] args)
        {
            var magicSegment = new MagicNumber();
            Console.Write("Please enter range where \nN: ");
            magicSegment.N = Int32.Parse(Console.ReadLine());
            Console.Write("K: ");
            magicSegment.K = Int32.Parse(Console.ReadLine());

            if (magicSegment.N > magicSegment.K || magicSegment.N <= 0)
                throw new MagicNumberWrongSegmentException("The segment shouldn't contain with " +
                                                           "negative numbers and N must be less than K");
            else
                magicSegment.GetPart();

            Console.ReadKey();
        }
    }
}
