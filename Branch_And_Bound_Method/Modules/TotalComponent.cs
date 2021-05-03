using Branch_And_Bound_Method.Modules.Interfaces;
using Branch_And_Bound_Method.Modules.Models;
using System.Linq;

namespace Branch_And_Bound_Method.Modules
{
    public class TotalComponent : ITotalComponent
    {
        public double CalculateTotalProbability(InputData[] inputData)
        {
            double[] probabilities = new double[inputData.Length];

            for (int i = 0; i < inputData.Length; i++)
            {
                var is1oo1 = inputData[i].Is1oo1 ? 1 : 0;
                var is1oo2 = inputData[i].Is1oo2 ? 1 : 0;
                var is2oo3 = inputData[i].Is2oo3 ? 1 : 0;

                probabilities[i] = inputData[i].p * is1oo1
                    + 2 * (inputData[i].p - inputData[i].p * inputData[i].p) * is1oo2
                    + (3 * inputData[i].p * inputData[i].p - 2 - inputData[i].p * inputData[i].p * inputData[i].p) * is2oo3;
            }

            var result = probabilities[0];

            for (int i = 1; i < probabilities.Length; i++)
                result *= probabilities[i];

            return result;
        }

        public double CaclulateTotalCost(InputData[] inputData)
        {
            double[] costs = new double[inputData.Length];

            for (int i = 0; i < inputData.Length; i++)
            {
                var is1oo1 = inputData[i].Is1oo1 ? 1 : 0;
                var is1oo2 = inputData[i].Is1oo2 ? 1 : 0;
                var is2oo3 = inputData[i].Is2oo3 ? 1 : 0;

                costs[i] = inputData[i].s * is1oo1
                    + 2 * inputData[i].G * inputData[i].s * is1oo2
                    + 4 * inputData[i].G * is2oo3;
            }
            return costs.Sum();
        }

        public double CalculateTotalTime(InputData[] inputData)
        {
            double[] times = new double[inputData.Length];

            for (int i = 0; i < inputData.Length; i++)
            {
                var is1oo1 = inputData[i].Is1oo1 ? 1 : 0;
                var is1oo2 = inputData[i].Is1oo2 ? 1 : 0;
                var is2oo3 = inputData[i].Is2oo3 ? 1 : 0;

                times[i] = (1 / inputData[i].t) * is1oo1
                    + (2 / (3 * inputData[i].t)) * is1oo2
                    + (6 / (5 * inputData[i].t)) * is2oo3;
            }
            return times.Sum();
        }
    }
}
