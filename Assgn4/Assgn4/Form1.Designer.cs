/************************************************************

   CSCI 680-00V3       Assignment 4      Fall 2017                                             
                                                          
   Programmers: RAHUL MARUPAKA(Z1802041)
                GAYATRI THOTA(Z1807846)
                SNEHAVI ATLURI(Z1803731)

   Date Due:   11/06/2017                                                           

 ***********************************************************/




namespace Assgn4
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.InputTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lineChart = new System.Windows.Forms.RadioButton();
            this.pieChart = new System.Windows.Forms.RadioButton();
            this.columnChart = new System.Windows.Forms.RadioButton();
            this.barChart = new System.Windows.Forms.RadioButton();
            this.clearButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.valueFromFile = new System.Windows.Forms.Button();
            this.valueFromRandom = new System.Windows.Forms.Button();
            this.valueFromUser = new System.Windows.Forms.Button();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.switchButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            this.SuspendLayout();
            // 
            // chart1
            // 
            this.chart1.BackColor = System.Drawing.Color.NavajoWhite;
            this.chart1.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.VerticalCenter;
            this.chart1.BorderlineColor = System.Drawing.Color.Tan;
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(297, 41);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bar;
            series1.Legend = "Legend1";
            series1.Name = "Series";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(527, 429);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            this.chart1.Click += new System.EventHandler(this.chart1_Click);
            // 
            // InputTextBox
            // 
            this.InputTextBox.Location = new System.Drawing.Point(137, 41);
            this.InputTextBox.Name = "InputTextBox";
            this.InputTextBox.Size = new System.Drawing.Size(144, 26);
            this.InputTextBox.TabIndex = 1;
            this.InputTextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Input Number:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lineChart);
            this.groupBox1.Controls.Add(this.pieChart);
            this.groupBox1.Controls.Add(this.columnChart);
            this.groupBox1.Controls.Add(this.barChart);
            this.groupBox1.Location = new System.Drawing.Point(36, 100);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(245, 186);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Select the type of Chart:";
            // 
            // lineChart
            // 
            this.lineChart.AutoSize = true;
            this.lineChart.Location = new System.Drawing.Point(18, 147);
            this.lineChart.Name = "lineChart";
            this.lineChart.Size = new System.Drawing.Size(107, 24);
            this.lineChart.TabIndex = 3;
            this.lineChart.TabStop = true;
            this.lineChart.Text = "Line Chart";
            this.lineChart.UseVisualStyleBackColor = true;
            this.lineChart.CheckedChanged += new System.EventHandler(this.radioButton4_CheckedChanged);
            // 
            // pieChart
            // 
            this.pieChart.AutoSize = true;
            this.pieChart.Location = new System.Drawing.Point(18, 107);
            this.pieChart.Name = "pieChart";
            this.pieChart.Size = new System.Drawing.Size(99, 24);
            this.pieChart.TabIndex = 2;
            this.pieChart.TabStop = true;
            this.pieChart.Text = "Pie Chart";
            this.pieChart.UseVisualStyleBackColor = true;
            this.pieChart.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // columnChart
            // 
            this.columnChart.AutoSize = true;
            this.columnChart.Location = new System.Drawing.Point(18, 65);
            this.columnChart.Name = "columnChart";
            this.columnChart.Size = new System.Drawing.Size(131, 24);
            this.columnChart.TabIndex = 1;
            this.columnChart.TabStop = true;
            this.columnChart.Text = "Column Chart";
            this.columnChart.UseVisualStyleBackColor = true;
            this.columnChart.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // barChart
            // 
            this.barChart.AutoSize = true;
            this.barChart.Location = new System.Drawing.Point(18, 25);
            this.barChart.Name = "barChart";
            this.barChart.Size = new System.Drawing.Size(102, 24);
            this.barChart.TabIndex = 0;
            this.barChart.TabStop = true;
            this.barChart.Text = "Bar Chart";
            this.barChart.UseVisualStyleBackColor = true;
            this.barChart.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(664, 492);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(252, 33);
            this.clearButton.TabIndex = 4;
            this.clearButton.Text = "CLEAR";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(1115, 492);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(248, 33);
            this.exitButton.TabIndex = 5;
            this.exitButton.Text = "EXIT";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // valueFromFile
            // 
            this.valueFromFile.Location = new System.Drawing.Point(36, 307);
            this.valueFromFile.Name = "valueFromFile";
            this.valueFromFile.Size = new System.Drawing.Size(245, 32);
            this.valueFromFile.TabIndex = 6;
            this.valueFromFile.Text = "Value from File";
            this.valueFromFile.UseVisualStyleBackColor = true;
            this.valueFromFile.Click += new System.EventHandler(this.button3_Click);
            // 
            // valueFromRandom
            // 
            this.valueFromRandom.Location = new System.Drawing.Point(36, 368);
            this.valueFromRandom.Name = "valueFromRandom";
            this.valueFromRandom.Size = new System.Drawing.Size(245, 30);
            this.valueFromRandom.TabIndex = 7;
            this.valueFromRandom.Text = "Value at Random";
            this.valueFromRandom.UseVisualStyleBackColor = true;
            this.valueFromRandom.Click += new System.EventHandler(this.button4_Click);
            // 
            // valueFromUser
            // 
            this.valueFromUser.Location = new System.Drawing.Point(36, 436);
            this.valueFromUser.Name = "valueFromUser";
            this.valueFromUser.Size = new System.Drawing.Size(245, 34);
            this.valueFromUser.TabIndex = 8;
            this.valueFromUser.Text = "Value from User";
            this.valueFromUser.UseVisualStyleBackColor = true;
            this.valueFromUser.Click += new System.EventHandler(this.button5_Click);
            // 
            // chart2
            // 
            this.chart2.BackColor = System.Drawing.Color.SandyBrown;
            this.chart2.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.VerticalCenter;
            chartArea2.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart2.Legends.Add(legend2);
            this.chart2.Location = new System.Drawing.Point(865, 44);
            this.chart2.Name = "chart2";
            this.chart2.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bar;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chart2.Series.Add(series2);
            this.chart2.Size = new System.Drawing.Size(498, 429);
            this.chart2.TabIndex = 9;
            this.chart2.Text = "chart2";
            this.chart2.Click += new System.EventHandler(this.chart2_Click);
            // 
            // switchButton
            // 
            this.switchButton.Location = new System.Drawing.Point(297, 492);
            this.switchButton.Name = "switchButton";
            this.switchButton.Size = new System.Drawing.Size(240, 33);
            this.switchButton.TabIndex = 10;
            this.switchButton.Text = "SWITCH";
            this.switchButton.UseVisualStyleBackColor = true;
            this.switchButton.Click += new System.EventHandler(this.button6_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1384, 539);
            this.Controls.Add(this.switchButton);
            this.Controls.Add(this.chart2);
            this.Controls.Add(this.valueFromUser);
            this.Controls.Add(this.valueFromRandom);
            this.Controls.Add(this.valueFromFile);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.InputTextBox);
            this.Controls.Add(this.chart1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.TextBox InputTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton lineChart;
        private System.Windows.Forms.RadioButton pieChart;
        private System.Windows.Forms.RadioButton columnChart;
        private System.Windows.Forms.RadioButton barChart;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button valueFromFile;
        private System.Windows.Forms.Button valueFromRandom;
        private System.Windows.Forms.Button valueFromUser;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
        private System.Windows.Forms.Button switchButton;

        bool flag = false;  //Setting a boolean value to flag, where flag = false indicates that the operations occur on chart 1 and chart 1 is active.
    }
}

