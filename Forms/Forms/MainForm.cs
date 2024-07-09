using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forms
{
    public partial class MainForm : Form
    {
        public double A;
        public double B;
        public double Y0;
        public double X0;
        public int N;
        public string Func;

        public MainForm()
        {
            InitializeComponent();
        }


        private void button1_MouseClick(object sender, MouseEventArgs e)
        {

            try
            {
                GraphForm graphForm = new GraphForm(-2, 0, -2, 3, 10, "x+Cos(y/Sqrt(2))");
                graphForm.Show();
                /*              
                Func = FuncBox.Text.Trim();
                X0 = Convert.ToDouble(X0Box.Text.Trim());
                Y0 = Convert.ToDouble(Y0Box.Text.Trim());
                A = Convert.ToDouble(LeftEdge_A.Text.Trim());
                B = Convert.ToDouble(RightEdge_B.Text.Trim());
                N = Convert.ToInt32(StepBox.Text.Trim());

                GraphForm graphForm = new GraphForm(A, B, X0, Y0, N, Func);
                graphForm.Show();
                */
            }
            catch
            {
                MessageBox.Show("Вы ввели что-то неправильно, исправьте");
            }
        }

        private void button1_KeyDown(object sender, KeyEventArgs e)
        {

            try
            {
                Func = FuncBox.Text.Trim();
                X0 = Convert.ToDouble(X0Box.Text.Trim());
                Y0 = Convert.ToDouble(Y0Box.Text.Trim());
                A = Convert.ToDouble(LeftEdge_A.Text.Trim());
                B = Convert.ToDouble(RightEdge_B.Text.Trim());
                N = Convert.ToInt32(StepBox.Text.Trim());

                GraphForm graphForm = new GraphForm(A, B, X0, Y0, N, Func);
                graphForm.Show();
            }
            catch
            {
                MessageBox.Show("Вы ввели что-то неправильно, исправьте");
            }
            /*
                        GraphForm graphForm = new GraphForm(-2, 0, -2, 3, 10, "x+Cos(y/Sqrt(2))");
                        graphForm.Show();
            */
        }

    }
}
