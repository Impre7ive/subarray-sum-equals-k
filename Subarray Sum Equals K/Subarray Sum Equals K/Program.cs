using System;

namespace Subarray_Sum_Equals_K {
    //Given an array of integers nums and an integer k, return the total number of continuous subarrays whose sum equals to k.
    //Input: nums = [1,1,1], k = 2
    //Output: 2
    //Input: nums = [1,2,3], k = 3
    //Output: 2
    class Program {
        static void Main(string[] args) {
            int[] selection = new int[] { 1, 2, 3 };
            int k = 3;
            int strategyFromConsole = GetStrategyNumber();

            IStrategy strategy = FactoryMethod.GetStrategy(strategyFromConsole);

            Context strategyContext = new Context();

            strategyContext.SetStrategy(strategy);

            strategyContext.ExecuteStrategy(selection, k);

            Console.ReadLine();
        }

        private static int GetStrategyNumber() {
            int result = 0;

            Console.WriteLine("Welcome to Subarray Sum Equals K program! Choose your method (1-4):");
            Console.WriteLine("1. Bruteforce");

            Int32.TryParse(Console.ReadLine(), out result);

            return result;
        }
    }
}
