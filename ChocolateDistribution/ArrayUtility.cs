using System;
using System.Collections.Generic;
using System.Text;

namespace ChocolateDistribution
{
    class ArrayUtility
    {
        public static int[] GetArrayFromUser() {
            int[] array = null;

            Console.WriteLine("Enter the number of elements in the array");
            try
            {
                int numberOfElements = int.Parse(Console.ReadLine().Trim());
                Console.WriteLine("Enter the elements of the array separated by" +
                    " space, comma or semi-colon");
                String[] elements = Console.ReadLine().Split(' ', ',', ';');
                array = new int[numberOfElements];
                for (int index = 0; index < numberOfElements; index++) {
                    array[index] = int.Parse(elements[index]);
                }
            }
            catch (Exception exception) {
                Console.WriteLine("Thrown exception is "+exception.Message);
            }

            return array;
        }

        public static int GetMinimumDifferenceBetweenDistributedPackets(int[] array, int numberOfstudents) {
            int noOfPackets = array.Length;

            if(numberOfstudents > noOfPackets){
                return -1;
            }
            if (noOfPackets == 0 || numberOfstudents == 0) {
                return 0;
            }

            Array.Sort(array);

            int minDifference = int.MaxValue;
            int distributedFirstPacket = 0;
            int distributedLastPacket = 0;

            for (int index = 0; index + numberOfstudents - 1 < noOfPackets; index++) {
                int currentDifference = array[index + numberOfstudents - 1] - array[index];
                if (currentDifference < minDifference) {
                    minDifference = currentDifference;
                    distributedFirstPacket = index;
                    distributedLastPacket = index + numberOfstudents - 1;
                }
            }
            return minDifference;
        }
    }
}
