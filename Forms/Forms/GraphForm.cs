using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using NCalc;

namespace Forms
{
    public partial class GraphForm : Form
    {
        public double a;
        public double b;
        public double x0;
        public double y0;
        public int n;
        public string func_string;
        public GraphForm(double a, double b, double x0, double y0, int n, string func_string)
        {
            InitializeComponent();
            this.a = a;
            this.b = b; 
            this.x0 = x0;
            this.y0 = y0;
            this.n = n;
            this.func_string = func_string;
        }


        private void button1_Click(object sender, EventArgs e)
        {

            Class_for_methods Class_for_methods = new Class_for_methods();
            if (Class_for_methods.F(func_string, x0, y0) == -10000000000000) { return; }
            else
            {
                List<List<double>> Func_Points_Euler = Class_for_methods.Euler(a, b, y0, n, func_string);
                List<List<double>> Func_Points_EulerKoshi = Class_for_methods.EulerKoshi(a, b, y0, n, func_string);
                List<List<double>> Func_Points_Runge_Kut_4 = Class_for_methods.Runge_Kutt_4(a, b, y0, n, func_string);
                /*
                x = a;
                y = y0;
                double h = (b - a) / Convert.ToDouble(n);
                while (x <= b)
                {
                    this.chart1.Series[0].Points.AddXY(x, y);
                    y = Class_for_methods.F(func_string, x, y);
                    x += h;
                }*/

                List<List<double>> Main_Func = Class_for_methods.Funccc(a, b, y0, func_string);
                double min = 100000, max = -1000000;
                foreach (List<double> i in Main_Func)
                {
                    this.chart1.Series[0].Points.AddXY(i[0], i[1]);
                }

                foreach (List<double> i in Func_Points_Euler)
                {
                    this.chart1.Series[1].Points.AddXY(i[0], i[1]);

                }
                foreach (List<double> i in Func_Points_EulerKoshi)
                {
                    this.chart1.Series[2].Points.AddXY(i[0], i[1]);

                }
                foreach (List<double> i in Func_Points_Runge_Kut_4)
                {
                    this.chart1.Series[3].Points.AddXY(i[0], i[1]);

                    if (min > i[1])
                    {
                        min = i[1];
                    }

                    if (max < i[1])
                    {
                        max = i[1];
                    }
                }
                this.chart1.Series[5].Points.AddXY(0, -1000);
                this.chart1.Series[5].Points.AddXY(0, 1000);
                this.chart1.Series[4].Points.AddXY(1000, 0);
                this.chart1.Series[4].Points.AddXY(-1000, 0);
                chart1.ChartAreas["ChartArea1"].AxisX.IsStartedFromZero = true;
                chart1.ChartAreas["ChartArea1"].AxisY.IsStartedFromZero = true;

                chart1.ChartAreas["ChartArea1"].AxisX.Minimum = a - 0.5;
                chart1.ChartAreas["ChartArea1"].AxisX.Maximum = b + 0.5;

                chart1.ChartAreas["ChartArea1"].AxisY.Minimum = min - 0.5;
                chart1.ChartAreas["ChartArea1"].AxisY.Maximum = max + 0.5;

                chart1.ChartAreas[0].AxisX.ScaleView.Zoomable = true;
                chart1.ChartAreas[0].AxisY.ScaleView.Zoomable = true;
                chart1.ChartAreas[0].CursorX.AutoScroll = true;
                chart1.ChartAreas[0].CursorY.AutoScroll = true;
                chart1.ChartAreas[0].CursorX.IsUserSelectionEnabled = true;
                chart1.ChartAreas[0].CursorY.IsUserSelectionEnabled = true;
                chart1.ChartAreas[0].AxisX.ScrollBar.Enabled = true;
                chart1.ChartAreas[0].AxisY.ScrollBar.Enabled = true;
                chart1.ChartAreas[0].AxisX.ScrollBar.ButtonStyle = ScrollBarButtonStyles.All;
                chart1.ChartAreas[0].CursorX.Interval = 0.01;

                Changing_Table(Func_Points_Euler, Func_Points_EulerKoshi, Func_Points_Runge_Kut_4, n);
            }
        }

        private void CheckBox_E_CheckedChanged(object sender, EventArgs e)
        {

            if (CheckBox_E.Checked == false) chart1.Series[1].Enabled = false;
            else chart1.Series[1].Enabled = true;

        }

        private void CheckBox_EK_CheckedChanged(object sender, EventArgs e)
        {

            if (CheckBox_EK.Checked == false) chart1.Series[2].Enabled = false;
            else chart1.Series[2].Enabled = true;

        }

        private void CheckBox_RK4_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckBox_RK4.Checked == false) chart1.Series[3].Enabled = false;
            else chart1.Series[3].Enabled = true;
        }

        private void Changing_Table(List<List<double>> Eu, List<List<double>> EK, List<List<double>> RK4, int n) 
        {

            for (int i = 0; i <= n; i++) 
            {
                DataGridViewRow newRow = new DataGridViewRow();
                newRow.CreateCells(Table_Eu);

                newRow.Cells[0].Value = i;
                newRow.Cells[1].Value = Eu[i][0];
                newRow.Cells[2].Value = Eu[i][1];
                Table_Eu.Rows.Add(newRow);

                DataGridViewRow newRow1 = new DataGridViewRow();
                newRow1.CreateCells(Table_EK);

                newRow1.Cells[0].Value = i;
                newRow1.Cells[1].Value = EK[i][0];
                newRow1.Cells[2].Value = EK[i][1];
                Table_EK.Rows.Add(newRow1);

                DataGridViewRow newRow2 = new DataGridViewRow();
                newRow2.CreateCells(Table_RK4);

                newRow2.Cells[0].Value = i;
                newRow2.Cells[1].Value = RK4[i][0];
                newRow2.Cells[2].Value = RK4[i][1];
                Table_RK4.Rows.Add(newRow2);

            }

        }
    }
}
