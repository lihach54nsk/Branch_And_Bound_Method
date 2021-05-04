using Branch_And_Bound_Method.Modules.Interfaces;
using Branch_And_Bound_Method.Modules.Models;
using System.Collections.Generic;
using System.Linq;

namespace Branch_And_Bound_Method.Modules
{
    public class TotalComponent : ITotalComponent
    {
        public double CalculateTotalProbability(InputData[] inputData)
        {
            List<double> probabilities = new();

            for (int i = 0; i < inputData.Length; i++)
            {
                var is1oo1 = inputData[i].Is1oo1 ? 1 : 0;
                var is1oo2 = inputData[i].Is1oo2 ? 1 : 0;
                var is2oo3 = inputData[i].Is2oo3 ? 1 : 0;

                for (int j = 0; j < 3; j++)
                {
                    var probability = 0.0;
                    switch (j)
                    {
                        case 0:
                            probability = inputData[i].p * is1oo1;
                            if (probability != 0.0)
                                probabilities.Add(probability);

                            break;
                        case 1:
                            probability = (2 * inputData[i].p - inputData[i].p * inputData[i].p) * is1oo2;
                            if (probability != 0.0)
                                probabilities.Add(probability);

                            break;
                        case 2:
                            probability = (3 * inputData[i].p * inputData[i].p - 2 * inputData[i].p * inputData[i].p * inputData[i].p) * is2oo3;
                            if (probability != 0.0)
                                probabilities.Add(probability);

                            break;
                    }
                }
            }
            //probabilities[i] = inputData[i].p * is1oo1
            //    + (2 * inputData[i].p - inputData[i].p * inputData[i].p) * is1oo2
            //    + (3 * inputData[i].p * inputData[i].p - 2 * inputData[i].p * inputData[i].p * inputData[i].p) * is2oo3;

            var result = probabilities[0];

            for (int i = 1; i < probabilities.Count; i++)
                result *= probabilities[i];

            return result;
        }

        public double CalculateTotalCost(InputData[] inputData)
        {
            List<double> costs = new();

            for (int i = 0; i < inputData.Length; i++)
            {
                var is1oo1 = inputData[i].Is1oo1 ? 1 : 0;
                var is1oo2 = inputData[i].Is1oo2 ? 1 : 0;
                var is2oo3 = inputData[i].Is2oo3 ? 1 : 0;

                for (int j = 0; j < 3; j++)
                {
                    var cost = 0.0;
                    switch (j)
                    {
                        case 0:
                            cost = inputData[i].s * is1oo1;
                            if (cost != 0.0)
                                costs.Add(cost);

                            break;
                        case 1:
                            cost = 2 * inputData[i].G * inputData[i].s * is1oo2;
                            if (cost != 0.0)
                                costs.Add(cost);

                            break;
                        case 2:
                            cost = 4 * inputData[i].s * is2oo3;
                            if (cost != 0)
                                costs.Add(cost);

                            break;
                    }
                }
                //costs[i] = inputData[i].s * is1oo1
                //    + 2 * inputData[i].G * inputData[i].s * is1oo2
                //    + 4 * inputData[i].s * is2oo3;
            }
            return costs.Sum();
        }

        public double CalculateTotalTime(InputData[] inputData)
        {
            List<double> times = new();

            for (int i = 0; i < inputData.Length; i++)
            {
                var is1oo1 = inputData[i].Is1oo1 ? 1 : 0;
                var is1oo2 = inputData[i].Is1oo2 ? 1 : 0;
                var is2oo3 = inputData[i].Is2oo3 ? 1 : 0;

                for (int j = 0; j < 3; j++)
                {
                    var time = 0.0;
                    switch (j)
                    {
                        case 0:
                            time = (1 / inputData[i].t) * is1oo1;
                            if (time != 0.0)
                                times.Add(time);

                            break;
                        case 1:
                            time = (2 / (3 * inputData[i].t)) * is1oo2;
                            if (time != 0.0)
                                times.Add(time);

                            break;
                        case 2:
                            time = (6 / (5 * inputData[i].t)) * is2oo3;
                            if (time != 0.0)
                                times.Add(time);

                            break;
                    }
                }
                //times[i] = ((1 / inputData[i].t) * is1oo1)
                //    + ((2 / (3 * inputData[i].t)) * is1oo2)
                //    + ((6 / (5 * inputData[i].t)) * is2oo3);
            }
            return times.Sum();
        }
    }
}
