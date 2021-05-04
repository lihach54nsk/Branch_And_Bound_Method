using Branch_And_Bound_Method.Modules.Interfaces;
using Branch_And_Bound_Method.Modules.Models;
using System.Collections.Generic;

namespace Branch_And_Bound_Method.Modules
{
    public class CalculationService : ICalculationService
    {
        public int[] CalculateTheBranches(InputData[] inputData, double[,] solutionMatrix, int solutionLength, double tauMax,
            int currentComponentIndex, int[] solution, ref List<int[]> solutions)
        {
            var calculateService = new TotalComponent();
            //var totalTime = calculateService.CalculateTotalTime(inputData);

            for (int j = 0; j < 3; j++)
            {
                if (solutionMatrix[currentComponentIndex, j] == 1.0)
                {
                    var tauResult = calculateService.CalculateTotalTime(inputData[0..currentComponentIndex])
                        + GetTauMin(inputData[currentComponentIndex], solutionMatrix[currentComponentIndex, 0], solutionMatrix[currentComponentIndex, 1]);

                    if (tauResult < tauMax)
                    {
                        var currentSolution = (int[])solution.Clone();
                        currentSolution[currentComponentIndex] = j;

                        if (currentComponentIndex != solutionLength - 1)
                            solution = CalculateTheBranches(inputData, solutionMatrix, solutionLength, tauMax, currentComponentIndex + 1, currentSolution, ref solutions);
                        else
                            solutions.Add(currentSolution);
                    }
                }
            }
            return solution;
        }

        private double GetTauMin(InputData inputData, double solution1oo1, double solution1oo2)
        {
            return solution1oo2 == 1.0 ? 2 / (3 * inputData.t) : 1 / inputData.t;
        }
    }
}
