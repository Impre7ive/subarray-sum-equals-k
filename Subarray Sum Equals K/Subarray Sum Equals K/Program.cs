using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Subarray_Sum_Equals_K {
    //Given an array of integers nums and an integer k, return the total number of continuous subarrays whose sum equals to k.
    //Input: nums = [1,1,1], k = 2
    //Output: 2
    //Input: nums = [1,2,3], k = 3
    //Output: 2
    class Program {
        static void Main(string[] args) {
            int[] selection = new int[] { 1, 2, 3, 4 };
            int k = 3;
            int strategyFromConsole = 0;

            Int32.TryParse(Console.ReadLine(), out strategyFromConsole);

            IStrategy strategy = FactoryMethod.GetStrategy(strategyFromConsole);

            Context strategyContext = new Context();
            
            strategyContext.SetStrategy(strategy);

            strategyContext.ExecuteStrategy(selection, k);
        }
    }
}
