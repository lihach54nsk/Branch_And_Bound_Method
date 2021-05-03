using Branch_And_Bound_Method.Modules.Models;

namespace Branch_And_Bound_Method.Modules.Interfaces
{
    public interface ITotalComponent
    {
        public double CalculateTotalProbability(InputData[] inputData);
        public double CaclulateTotalCost(InputData[] inputData);
        public double CalculateTotalTime(InputData[] inputData);
    }
}
