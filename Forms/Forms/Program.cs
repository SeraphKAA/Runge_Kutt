using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data;
using System.Linq.Expressions;
using System.Windows.Forms;
using NCalc;
using System.Security.Cryptography;
using MathNet.Numerics;
using MathNet.Numerics.LinearAlgebra;
using System.Windows.Forms.DataVisualization.Charting;

namespace Forms
{
    internal static class Program
    {
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }

    public class Class_for_methods
    {
        public double F(string expression, double x, double y)
        {
            try
            {
                NCalc.Expression e = new NCalc.Expression(expression);
                e.Parameters["x"] = x;
                e.Parameters["y"] = y;
                if (!e.HasErrors())
                    return Convert.ToDouble(e.Evaluate());
            }
            catch
            {
                MessageBox.Show("Ошибка: " + expression + "\nПосмотрите правильно ли введены входные параметры");
                return -10000000000000;
            }
            return -10000000000000;

        }


        public List<List<double>> Euler(double a, double b, double y0, int n, string f)
        {
            List<List<double>> result = new List<List<double>>();
            double h = (b - a) / Convert.ToDouble(n);
            double y = y0;
            double x = a;

            for (int i = 0; i <= n; i++)
            {
                if (i == n)
                {
                    result.Add(new List<double>() { b, Math.Round(y, 5) });
                    y += F(f, x, y) * h;
                    x = 0;
                }
                else
                {
                    result.Add(new List<double>() { Math.Round(x, 5), Math.Round(y, 5) });
                    y += F(f, x, y) * h;
                    x += h;
                }
            }

            return result;
        }


        public List<List<double>> Funccc(double a, double b, double y0, string f)
        {
            return Runge_Kutt_4(a, b, y0, 50, f);
        }


        public List<List<double>> Runge_Kutt_4(double a, double b, double y0, int n, string f)
        {
            List<List<double>> result = new List<List<double>>();
            double h = (b - a) / Convert.ToDouble(n);
            double y = y0;
            double x = a;

            for (int i = 0; i <= n; i++)
            {
                if (i == n)
                {
                    
                    result.Add(new List<double>() { b, Math.Round(y, 5) });
                    double temp0 = F(f, x, y);
                    x += (h / 2);

                    double temp1 = F(f, x, y + (h / 2) * temp0);
                    double temp2 = F(f, x, y + (h / 2) * temp1);
                    x += (h / 2);

                    double temp3 = F(f, x, y + h * temp2);
                    y += (h / 6) * (temp0 + 2 * temp1 + 2 * temp2 + temp3);
                }
                else
                {
                    // Console.WriteLine("{0}) {1} - {2}", i, x, y);
                    result.Add(new List<double>() { Math.Round(x, 5), Math.Round(y, 5) });
                    double temp0 = F(f, x, y);
                    x += (h / 2);

                    double temp1 = F(f, x, y + (h / 2) * temp0);
                    double temp2 = F(f, x, y + (h / 2) * temp1);
                    x += (h / 2);

                    double temp3 = F(f, x, y + h * temp2);
                    y += (h / 6) * (temp0 + 2 * temp1 + 2 * temp2 + temp3);

                }
            }

            return result;
        }


        public List<List<double>> EulerKoshi(double a, double b, double y0, int n, string f)
        {
            List<List<double>> result = new List<List<double>>();
            double h = (b - a) / Convert.ToDouble(n);
            double y = y0;
            double x = a;

            for (int i = 0; i <= n; i++)
            {
                if (i == n)
                {
                    result.Add(new List<double>() { b, Math.Round(y, 5) });
                    double temp = F(f, x, y);
                    y += (h/2)*(temp + F(f, x + h, y + h * temp));
                    x = 0;
                }
                else
                {
                    result.Add(new List<double>() { Math.Round(x, 5), Math.Round(y, 5) });
                    double temp = F(f, x, y);
                    y += (h / 2) * (temp + F(f, x + h, y + h * temp));
                    x += h;
                }
            }

            return result;
        }




    }
}

