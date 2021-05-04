using Branch_And_Bound_Method.Modules;
using Branch_And_Bound_Method.Modules.Models;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Branch_And_Bound_Method
{
    public partial class Form1 : Form
    {
        private readonly CalculationService _calculationService;
        private readonly CombinationService _combinationService;
        private readonly TotalComponent _totalComponent;
        public Form1()
        {
            _calculationService = new CalculationService();
            _combinationService = new CombinationService();
            _totalComponent = new TotalComponent();
            InitializeComponent();
            dataGridViewInput.Rows.Add("0,9", "2", "1", "1,1", true, false, false);
            dataGridViewInput.Rows.Add("0,85", "3", "2", "1,3", true, true, false);
            dataGridViewInput.Rows.Add("0,9", "2", "3", "1,2", true, true, true);
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            InputData[] inputData = new InputData[dataGridViewInput.Rows.Count - 1];

            for (int i = 0; i < dataGridViewInput.Rows.Count - 1; i++)
            {
                inputData[i] = new InputData
                {
                    p = Convert.ToDouble(dataGridViewInput.Rows[i].Cells[0].Value),
                    s = Convert.ToDouble(dataGridViewInput.Rows[i].Cells[1].Value),
                    t = Convert.ToDouble(dataGridViewInput.Rows[i].Cells[2].Value),
                    G = Convert.ToDouble(dataGridViewInput.Rows[i].Cells[3].Value),
                    Is1oo1 = Convert.ToBoolean(dataGridViewInput.Rows[i].Cells[4].Value),
                    Is1oo2 = Convert.ToBoolean(dataGridViewInput.Rows[i].Cells[5].Value),
                    Is2oo3 = Convert.ToBoolean(dataGridViewInput.Rows[i].Cells[6].Value)
                };
            }

            var solution = new int[dataGridViewInput.Rows.Count - 1];
            var solutions = new List<int[]>();
            var tauMax = 10.0;

            var solutionMatrix = _combinationService.GenerateSolutionMatrix(inputData);
            var totalProbability = _totalComponent.CalculateTotalProbability(inputData);
            var totalCost = _totalComponent.CalculateTotalCost(inputData);

            _calculationService.CalculateTheBranches(inputData, solutionMatrix, dataGridViewInput.Rows.Count - 1, tauMax,
                0, solution, ref solutions, totalProbability, totalCost);

            var totalTime = _totalComponent.CalculateTotalTime(inputData);


        }
    }
}
