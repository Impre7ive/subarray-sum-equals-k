using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Subarray_Sum_Equals_K {
    public interface IStrategy {
        int SubarraySum(int[] nums, int k);
    }

    class SolutionWithStrategyPatternWithBrutforce : IStrategy {
        public int SubarraySum(int[] nums, int k) {
            return 0;   
        }
    }
}
