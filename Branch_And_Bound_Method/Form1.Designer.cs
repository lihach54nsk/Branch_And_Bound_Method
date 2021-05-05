
namespace Branch_And_Bound_Method
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridViewInput = new System.Windows.Forms.DataGridView();
            this.P = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.S = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.t = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.G = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Is1oo1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Is1oo2 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Is2oo3 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewOutput = new System.Windows.Forms.DataGridView();
            this.Solution = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProbabilityOutput = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SOutput = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TOutput = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.calculateButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.timeTextBoxInput = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOutput)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewInput
            // 
            this.dataGridViewInput.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewInput.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.P,
            this.S,
            this.t,
            this.G,
            this.Is1oo1,
            this.Is1oo2,
            this.Is2oo3});
            this.dataGridViewInput.Location = new System.Drawing.Point(13, 13);
            this.dataGridViewInput.Name = "dataGridViewInput";
            this.dataGridViewInput.RowTemplate.Height = 25;
            this.dataGridViewInput.Size = new System.Drawing.Size(745, 206);
            this.dataGridViewInput.TabIndex = 0;
            // 
            // P
            // 
            this.P.HeaderText = "P";
            this.P.Name = "P";
            // 
            // S
            // 
            this.S.HeaderText = "S";
            this.S.Name = "S";
            // 
            // t
            // 
            this.t.HeaderText = "t";
            this.t.Name = "t";
            // 
            // G
            // 
            this.G.HeaderText = "G";
            this.G.Name = "G";
            // 
            // Is1oo1
            // 
            this.Is1oo1.HeaderText = "1oo1";
            this.Is1oo1.Name = "Is1oo1";
            // 
            // Is1oo2
            // 
            this.Is1oo2.HeaderText = "1oo2";
            this.Is1oo2.Name = "Is1oo2";
            // 
            // Is2oo3
            // 
            this.Is2oo3.HeaderText = "2oo3";
            this.Is2oo3.Name = "Is2oo3";
            // 
            // dataGridViewOutput
            // 
            this.dataGridViewOutput.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOutput.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Solution,
            this.ProbabilityOutput,
            this.SOutput,
            this.TOutput});
            this.dataGridViewOutput.Location = new System.Drawing.Point(13, 235);
            this.dataGridViewOutput.Name = "dataGridViewOutput";
            this.dataGridViewOutput.RowTemplate.Height = 25;
            this.dataGridViewOutput.Size = new System.Drawing.Size(446, 206);
            this.dataGridViewOutput.TabIndex = 1;
            // 
            // Solution
            // 
            this.Solution.HeaderText = "Solution";
            this.Solution.Name = "Solution";
            // 
            // ProbabilityOutput
            // 
            this.ProbabilityOutput.HeaderText = "Probability";
            this.ProbabilityOutput.Name = "ProbabilityOutput";
            // 
            // SOutput
            // 
            this.SOutput.HeaderText = "Cost";
            this.SOutput.Name = "SOutput";
            // 
            // TOutput
            // 
            this.TOutput.HeaderText = "T";
            this.TOutput.Name = "TOutput";
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(465, 265);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(106, 23);
            this.calculateButton.TabIndex = 2;
            this.calculateButton.Text = "Calculate";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(469, 235);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Time of the work: ";
            // 
            // timeTextBoxInput
            // 
            this.timeTextBoxInput.Location = new System.Drawing.Point(577, 232);
            this.timeTextBoxInput.Name = "timeTextBoxInput";
            this.timeTextBoxInput.Size = new System.Drawing.Size(100, 23);
            this.timeTextBoxInput.TabIndex = 4;
            this.timeTextBoxInput.Text = "0,5";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(768, 455);
            this.Controls.Add(this.timeTextBoxInput);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.dataGridViewOutput);
            this.Controls.Add(this.dataGridViewInput);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOutput)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewInput;
        private System.Windows.Forms.DataGridView dataGridViewOutput;
        private System.Windows.Forms.DataGridViewTextBoxColumn P;
        private System.Windows.Forms.DataGridViewTextBoxColumn S;
        private System.Windows.Forms.DataGridViewTextBoxColumn t;
        private System.Windows.Forms.DataGridViewTextBoxColumn G;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Is1oo1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Is1oo2;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Is2oo3;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn Solution;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProbabilityOutput;
        private System.Windows.Forms.DataGridViewTextBoxColumn SOutput;
        private System.Windows.Forms.DataGridViewTextBoxColumn TOutput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox timeTextBoxInput;
    }
}

