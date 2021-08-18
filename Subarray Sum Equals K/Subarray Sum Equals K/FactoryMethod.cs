namespace Subarray_Sum_Equals_K {
    public enum StrategyType {
        Bruteforce = 1,
        HashMap,
        CumulativeSum,
        WithoutSpace
    }

    public class FactoryMethod {
        public static IStrategy GetStrategy(int type) {
            IStrategy result = new SolutionWithStrategyPatternWithBrutforce();
            return result;
        }
    }
}