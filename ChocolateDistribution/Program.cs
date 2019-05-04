using System;

namespace ChocolateDistribution
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Chocolate ditribution problem!");
            Console.WriteLine("------------------------------");

            int[] array = ArrayUtility.GetArrayFromUser();
            try
            {
                Console.WriteLine("Enter the number of students to whom these" +
                    " packtes should be distributed");
                int numberOfStrudents = int.Parse(Console.ReadLine().Trim());
                Console.WriteLine("The minimum difference is " + ArrayUtility.GetMinimumDifferenceBetweenDistributedPackets(array, numberOfStrudents));
            }
            catch (Exception exception) {
                Console.WriteLine("Thrown exception is "+exception.Message);
            }
            

            Console.ReadLine();
        }
    }
}
