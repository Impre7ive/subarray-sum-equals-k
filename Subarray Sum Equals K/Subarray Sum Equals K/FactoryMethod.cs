using System.Collections.Generic;

namespace Subarray_Sum_Equals_K {
    public class FactoryMethod {
        private enum StrategyType : ushort {
            Bruteforce = 1
        }

        private static Dictionary<StrategyType, IStrategy> _methods = new Dictionary<StrategyType, IStrategy> {
            {StrategyType.Bruteforce, new SolutionStrategyPatternWithBrutforce() }
        };


        public static IStrategy GetStrategy(int type) {
            IStrategy result = null;

            result = _methods[(StrategyType)type];

            return result;
        }
    }
}