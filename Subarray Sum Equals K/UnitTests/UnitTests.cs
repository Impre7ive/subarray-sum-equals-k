using NUnit.Framework;
using Subarray_Sum_Equals_K;

namespace UnitTests {
    [TestFixture]
    public class UnitTests {
        [TestCase(2, 2, new int[] { 1, 1, 1 })]
        [TestCase(3, 2, new int[] { 1, 2, 3 })]
        public void SubarraySum_RealArray_ReturnTrue(int k, int expect, int[] nums) {
            SolutionStrategyPatternWithBrutforce entity = new SolutionStrategyPatternWithBrutforce();

            int result = entity.SubarraySum(nums, k);

            Assert.AreEqual(expect, result);
        }
    }
}
