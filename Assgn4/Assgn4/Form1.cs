/************************************************************

   CSCI 680-00V3       Assignment 4      Fall 2017                                             
                                                          
   Programmers: RAHUL MARUPAKA(Z1802041)
                GAYATRI THOTA(Z1807846)
                SNEHAVI ATLURI(Z1803731)

   Date Due:   11/06/2017                                                           

 ***********************************************************/

 using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assgn4
{
    public partial class Form1 : Form
    {
        private
            int i = 0;

        List<double> numberArray;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            fileRead();
            //Pre Loading CHART 1 with three values 
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint1 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 20D);
            chart1.Series["Series"].Points.Add(dataPoint1);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint2 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 10D);
            chart1.Series["Series"].Points.Add(dataPoint2);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint3 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 15D);
            chart1.Series["Series"].Points.Add(dataPoint3);
            
            // Pre Loading Chart 2 with three values
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint4 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 15D);
            chart2.Series["Series1"].Points.Add(dataPoint4);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint5 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 10D);
            chart2.Series["Series1"].Points.Add(dataPoint5);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint6 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 20D);
            chart2.Series["Series1"].Points.Add(dataPoint6);

            barChart.Checked = true;
        }

        private void fileRead()   //This functions reads the data from the input file
        {
            string fileName1 = "Numbers.txt";                                        //A file name given to a string variable

            string textLine1;
            numberArray = new List<double>();

            if (System.IO.File.Exists(fileName1) == true)
            {
                System.IO.StreamReader objReader;
                objReader = new System.IO.StreamReader(fileName1);                 //This reads the the content in the file and storing the data in 3 different variables 
                textLine1 = objReader.ReadLine();
                while (textLine1 != null)
                {
                    numberArray.Add(Double.Parse(textLine1));
                    textLine1 = objReader.ReadLine();
                }
                objReader.Close();
            }

            else
            {
                Console.WriteLine("No such File" + fileName1); //If the file doesnot exist, it will display this message
            }

            foreach (double n in numberArray)
            {
                //Console.WriteLine(n);
                //MessageBox.Show(Convert.ToString(n));
            }

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)   //This radio button is for Bar Chart
        {
            chart1.Series["Series"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bar;   //setting the chart type of chart 1 to Bar Chart

            chart2.Series["Series1"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bar;   //setting the chart type of chart 2 to Bar Chart

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)     //This Radio Button is for Pie Chart
        {
            chart1.Series["Series"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;  //setting the chart type of chart 1 to Pie Chart

            chart2.Series["Series1"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie; //setting the chart type of chart 2 to Pie Chart

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)     //This Radio Button is for Line Chart
        {
            chart1.Series["Series"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;  //setting the chart type of chart 1 to Line Chart

            chart2.Series["Series1"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;  //setting the chart type of chart 2 to Line Chart

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)     //This Radio Button is for Column Chart
        {
            chart1.Series["Series"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column; //setting the chart type of chart 1 to Column Chart

            chart2.Series["Series1"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;  //setting the chart type of chart 2 to Column Chart

        }

        private void button3_Click(object sender, EventArgs e)  //This is a button to take the input value from the File 
        {
            if (i == 1)
            {
                barChart.Checked = true;
                i = 0;
            }

            if (numberArray.Count > 0)                              //This checks wheather the array count is grater than zero or not
            {

                if (flag == false)
                {
                    chart1.Series["Series"].Points.AddXY(0, numberArray[0]); //This adds point to the series in Chart 1
                }

                if (flag == true)
                {
                    chart2.Series["Series1"].Points.AddXY(0, numberArray[0]); //This adds point to the series in Chart 2
                }

                numberArray.RemoveAt(0);
            }
            InputTextBox.Clear();  //This clears the input text box
        }

        private void button4_Click(object sender, EventArgs e)  // This button is used to add a Random Value to the series
        {
            if (i == 1)
            {
                barChart.Checked = true;
                i = 0;
            }

            InputTextBox.Clear();    // This clears the input text box
            Random r = new Random();
            double rnd = r.NextDouble() * (10.00 - 0.00) + 0.00;                //This generates random values   
            if (flag == false)
            {
                chart1.Series["Series"].Points.AddXY(0, rnd);  // It adds random values to the series in chart 1
            }
            if (flag == true)
            {
                chart2.Series["Series1"].Points.AddXY(0, rnd);  // It adds random values to the series in chart 2
            }
        }

        private void button5_Click(object sender, EventArgs e)  // This takes the value from the input text box which user gives and adds to the series in chart
        {
            if (i == 1)
            {
                barChart.Checked = true;
                i = 0;
            }
            
            double userData;
            if (Double.TryParse(this.InputTextBox.Text, out userData))                  // This parse the values to double
            {

                if (flag == false)
                {
                    chart1.Series["Series"].Points.AddXY(0, userData);               // This adds the point to the series in chart 1

                }
                if (flag == true)
                {
                    chart2.Series["Series1"].Points.AddXY(0, userData);         //This adds the point to the series in chart 2
                }
                this.InputTextBox.Clear();      //This clears the text box

            }

            else
            {
                MessageBox.Show("Please enter a double value");                   // This tells the user to enter a double vaule
                this.InputTextBox.Clear();                                            //It clears the text box
            }


        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)   // This is clear button which clears the data on the form 
        {
            
            chart1.Series["Series"].Points.Clear();         //This clears the chart series in chart 1

            chart2.Series["Series1"].Points.Clear();        //This clears the chart series in chart 2
            //The following deselects the radio buttons if they are checked
            barChart.Checked = false;         
            columnChart.Checked = false;
            pieChart.Checked = false;
            lineChart.Checked = false;
            InputTextBox.Clear();                           //It clears the textbox            
            fileRead();                                 //It calls the file read function
            flag = false;
            chart1.Series["Series"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bar;

            chart2.Series["Series1"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bar;

            i = 1;
        }

        private void button2_Click(object sender, EventArgs e)  //This button is to exit the application
        {
            Application.Exit(); //This is used to exit the application
        }

        private void chart2_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e) //This is for Switch Button
        {
            if(flag == false)    //If flag is false, It is chart 1
            {
                flag = true;    //If flag is true, It is chart 2
                return; 

            }
            if(flag == true)
            {
                flag = false;
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

       
    }
}
