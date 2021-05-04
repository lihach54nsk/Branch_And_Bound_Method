using Branch_And_Bound_Method.Modules.Models;
using System.Collections.Generic;

namespace Branch_And_Bound_Method.Modules.Interfaces
{
    public interface ICombinationService
    {
        public double[,] GenerateSolutionMatrix(InputData[] inputData);
    }
}
