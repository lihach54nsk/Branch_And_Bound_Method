using Branch_And_Bound_Method.Modules.Models;

namespace Branch_And_Bound_Method.Modules.Interfaces
{
    public interface ICurrentComponent
    {
        public double CalculateCurrentProbability(InputData[] inputData, int[] solution, int lastIndex);
        public double CalculateCurrentCost(InputData[] inputData, int[] solution, int lastIndex);
        public double CalculateCurrentTime(InputData[] inputData, int[] solution, int lastIndex);
    }
}
