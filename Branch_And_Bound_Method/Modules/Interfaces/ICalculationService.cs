using Branch_And_Bound_Method.Modules.Models;
using System.Collections.Generic;

namespace Branch_And_Bound_Method.Modules.Interfaces
{
    public interface ICalculationService
    {
        public int[] CalculateTheBranches(InputData[] inputData, double[,] solutionMatrix, int solutionLength, double tauMax, int currentComponentIndex, int[] solution, ref List<int[]> solutions);
    }
}
