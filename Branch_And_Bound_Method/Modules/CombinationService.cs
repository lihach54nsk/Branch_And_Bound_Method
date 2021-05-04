using Branch_And_Bound_Method.Modules.Interfaces;
using Branch_And_Bound_Method.Modules.Models;
using System;
using System.Collections.Generic;

namespace Branch_And_Bound_Method.Modules
{
    public class CombinationService : ICombinationService
    {
        public double[,] GenerateSolutionMatrix(InputData[] inputData)
        {
            double[,] resultMatrix = new double[inputData.Length, 3];

            for (int i = 0; i < inputData.Length; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    var is1oo1 = inputData[i].Is1oo1 ? 1 : 0;
                    var is1oo2 = inputData[i].Is1oo2 ? 1 : 0;
                    var is2oo3 = inputData[i].Is2oo3 ? 1 : 0;

                    switch (j)
                    {
                        case 0:
                            resultMatrix[i, 0] = is1oo1;
                            break;
                        case 1:
                            resultMatrix[i, 1] = is1oo2;
                            break;
                        case 2:
                            resultMatrix[i, 2] = is2oo3;
                            break;
                        default:
                            throw new Exception("J is not valid");
                    }
                }
            }
            return resultMatrix;
        }
    }
}
