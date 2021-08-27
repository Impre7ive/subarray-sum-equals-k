using System;

namespace Subarray_Sum_Equals_K {
    public class Context {
        private IStrategy _strategy;

        public void SetStrategy(IStrategy strategy) {
            _strategy = strategy;
        }

        public void ExecuteStrategy(int[] nums, int k) {
            int result = _strategy.SubarraySum(nums, k);

            Console.WriteLine($"Total number of continuous subarrays whose sum equals to {k} is {result}");
        }
    }
}
