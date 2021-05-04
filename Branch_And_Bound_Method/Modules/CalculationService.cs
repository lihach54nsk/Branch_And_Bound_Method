using Branch_And_Bound_Method.Modules.Interfaces;
using Branch_And_Bound_Method.Modules.Models;
using System.Collections.Generic;

namespace Branch_And_Bound_Method.Modules
{
    public class CalculationService : ICalculationService
    {
        public int[] CalculateTheBranches(InputData[] inputData, double[,] solutionMatrix, int solutionLength, double tauMax,
            int currentComponentIndex, int[] solution, ref List<int[]> solutions, double totalProbability, double totalCost)
        {
            var calculateService = new TotalComponent();
            var currentService = new CurrentComponent();

            for (int j = 0; j < 3; j++)
            {
                if (solutionMatrix[currentComponentIndex, j] == 1.0)
                {
                    var currentSolution = (int[])solution.Clone();
                    currentSolution[currentComponentIndex] = j;
                    var tauResult = currentService.CalculateCurrentTime(inputData, currentSolution, currentComponentIndex);
                    //var tauResult = calculateService.CalculateTotalTime(inputData[0..(currentComponentIndex + 1)]);

                    for (int k = currentComponentIndex + 1; k < solutionLength; k++)
                        tauResult += GetTauMin(inputData[k], solutionMatrix[k, 1]);

                    if (tauResult < tauMax)
                    {
                        var currentProbability = currentService.CalculateCurrentProbability(inputData, currentSolution, currentComponentIndex);
                        //var currentProbability = calculateService.CalculateTotalProbability(inputData[0..(currentComponentIndex + 1)]);
                        var currentCost = currentService.CalculateCurrentCost(inputData, currentSolution, currentComponentIndex);
                        //var currentCost = calculateService.CalculateTotalCost(inputData[0..(currentComponentIndex + 1)]);

                        for (int k = currentComponentIndex + 1; k < solutionLength; k++)
                        {
                            currentProbability *= GetProbabilityMax(inputData[k], solutionMatrix[k, 1]);
                            currentCost += inputData[k].s;
                        }

                        if (currentProbability >= totalProbability && currentCost <= totalCost)
                        {
                            if (currentComponentIndex != solutionLength - 1)
                                solution = CalculateTheBranches(inputData, solutionMatrix, solutionLength, tauMax,
                                    currentComponentIndex + 1, currentSolution, ref solutions, totalProbability, totalCost);
                            else
                                solutions.Add(currentSolution);
                        }
                    }
                }
            }
            return solution;
        }

        private double GetTauMin(InputData inputData, double solution1oo2)
        {
            return solution1oo2 == 1.0 ? 2 / (3 * inputData.t) : 1 / inputData.t;
        }

        private double GetProbabilityMax(InputData inputData, double solution1oo2)
        {
            return solution1oo2 == 1.0 ? (2 * inputData.p - inputData.p * inputData.p)
                : (3 * inputData.p * inputData.p - 2 * inputData.p * inputData.p * inputData.p);
        }
    }
}
