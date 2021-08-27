namespace Subarray_Sum_Equals_K {
    public interface IStrategy {
        int SubarraySum(int[] nums, int k);
    }

    public class SolutionStrategyPatternWithBrutforce : IStrategy {
        public int SubarraySum(int[] nums, int k) {
            int result = 0;

            for (int i = 0; i < nums.Length; ++i) {
                for (int j = i; j < nums.Length; ++j) {
                    int sum = 0;

                    for (int z = i; z <= j; ++z)
                        sum += nums[z];

                    if (sum == k)
                        ++result;
                }
            }

            return result;
        }
    }
}
