using Branch_And_Bound_Method.Modules.Interfaces;
using Branch_And_Bound_Method.Modules.Models;
using System.Linq;

namespace Branch_And_Bound_Method.Modules
{
    public class CurrentComponent : ICurrentComponent
    {
        public double CalculateCurrentProbability(InputData[] inputData, int[] solution, int lastIndex)
        {
            double[] probabilities = new double[solution.Length];
            for (int i = 0; i < lastIndex + 1; i++)
            {
                switch (solution[i])
                {
                    case 0:
                        probabilities[i] = inputData[i].p;
                        break;
                    case 1:
                        probabilities[i] = (2 * inputData[i].p - inputData[i].p * inputData[i].p);
                        break;
                    case 2:
                        probabilities[i] = (3 * inputData[i].p * inputData[i].p - 2 * inputData[i].p * inputData[i].p * inputData[i].p);
                        break;
                }
            }

            var result = probabilities[0];

            for (int i = 1; i < lastIndex + 1; i++)
                result *= probabilities[i];

            return result;
        }

        public double CalculateCurrentCost(InputData[] inputData, int[] solution, int lastIndex)
        {
            double[] costs = new double[solution.Length];

            for (int i = 0; i < lastIndex + 1; i++)
            {
                switch (solution[i])
                {
                    case 0:
                        costs[i] = inputData[i].s;
                        break;
                    case 1:
                        costs[i] = 2 * inputData[i].G * inputData[i].s;
                        break;
                    case 2:
                        costs[i] = 4 * inputData[i].s;
                        break;
                }
            }
            return costs.Sum();
        }

        public double CalculateCurrentTime(InputData[] inputData, int[] solution, int lastIndex)
        {
            double[] times = new double[solution.Length];

            for (int i = 0; i < lastIndex + 1; i++)
            {
                switch (solution[i])
                {
                    case 0:
                        times[i] = (1 / inputData[i].t);
                        break;
                    case 1:
                        times[i] = (2 / (3 * inputData[i].t));
                        break;
                    case 2:
                        times[i] = (6 / (5 * inputData[i].t));
                        break;
                }
            }
            return times.Sum();
        }
    }
}
