namespace Forms
{
    partial class GraphForm
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
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Table_RK4 = new System.Windows.Forms.DataGridView();
            this.Table_EK = new System.Windows.Forms.DataGridView();
            this.Table_Eu = new System.Windows.Forms.DataGridView();
            this.Iteration = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Eu_X = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Eu_Y = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CheckBox_RK4 = new System.Windows.Forms.CheckBox();
            this.CheckBox_EK = new System.Windows.Forms.CheckBox();
            this.CheckBox_E = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Iteration_2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EK_x = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EK_Y = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Iteration_3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RK4_x = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RG4_y = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Table_RK4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Table_EK)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Table_Eu)).BeginInit();
            this.SuspendLayout();
            // 
            // chart1
            // 
            this.chart1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chart1.AntiAliasing = System.Windows.Forms.DataVisualization.Charting.AntiAliasingStyles.Text;
            chartArea1.AlignmentOrientation = ((System.Windows.Forms.DataVisualization.Charting.AreaAlignmentOrientations)((System.Windows.Forms.DataVisualization.Charting.AreaAlignmentOrientations.Vertical | System.Windows.Forms.DataVisualization.Charting.AreaAlignmentOrientations.Horizontal)));
            chartArea1.AxisX.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.True;
            chartArea1.AxisX2.LabelStyle.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Auto;
            chartArea1.AxisX2.LabelStyle.IsEndLabelVisible = false;
            chartArea1.AxisY.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.True;
            chartArea1.CursorX.IsUserEnabled = true;
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            legend1.Position.Auto = false;
            legend1.Position.Height = 15.28455F;
            legend1.Position.Width = 20.17893F;
            legend1.Position.X = 76.82108F;
            legend1.Position.Y = 3F;
            legend1.TableStyle = System.Windows.Forms.DataVisualization.Charting.LegendTableStyle.Tall;
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(-31, 36);
            this.chart1.Name = "chart1";
            this.chart1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            series1.BorderWidth = 2;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Color = System.Drawing.Color.DarkGreen;
            series1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            series1.Legend = "Legend1";
            series1.Name = "Функция";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(22)))), ((int)(((byte)(226)))));
            series2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            series2.Legend = "Legend1";
            series2.Name = "Метод Эйлера";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series3.Color = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(57)))), ((int)(((byte)(253)))));
            series3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            series3.Legend = "Legend1";
            series3.Name = "Метод Эйлера-Коши";
            series3.YValuesPerPoint = 4;
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series4.Color = System.Drawing.Color.Red;
            series4.Legend = "Legend1";
            series4.Name = "Метод Рунге-Кутта 4 порядка";
            series5.BorderWidth = 3;
            series5.ChartArea = "ChartArea1";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series5.Color = System.Drawing.Color.Black;
            series5.Legend = "Legend1";
            series5.Name = "Ось X";
            series6.BorderWidth = 3;
            series6.ChartArea = "ChartArea1";
            series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series6.Color = System.Drawing.Color.Black;
            series6.Legend = "Legend1";
            series6.Name = "Ось Y";
            this.chart1.Series.Add(series1);
            this.chart1.Series.Add(series2);
            this.chart1.Series.Add(series3);
            this.chart1.Series.Add(series4);
            this.chart1.Series.Add(series5);
            this.chart1.Series.Add(series6);
            this.chart1.Size = new System.Drawing.Size(919, 663);
            this.chart1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.Table_RK4);
            this.panel1.Controls.Add(this.Table_EK);
            this.panel1.Controls.Add(this.Table_Eu);
            this.panel1.Controls.Add(this.CheckBox_RK4);
            this.panel1.Controls.Add(this.CheckBox_EK);
            this.panel1.Controls.Add(this.CheckBox_E);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.chart1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1483, 726);
            this.panel1.TabIndex = 1;
            // 
            // Table_RK4
            // 
            this.Table_RK4.BackgroundColor = System.Drawing.Color.White;
            this.Table_RK4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Table_RK4.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Iteration_3,
            this.RK4_x,
            this.RG4_y});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Table_RK4.DefaultCellStyle = dataGridViewCellStyle1;
            this.Table_RK4.Location = new System.Drawing.Point(1122, 479);
            this.Table_RK4.Name = "Table_RK4";
            this.Table_RK4.ReadOnly = true;
            this.Table_RK4.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Table_RK4.Size = new System.Drawing.Size(340, 222);
            this.Table_RK4.TabIndex = 15;
            // 
            // Table_EK
            // 
            this.Table_EK.BackgroundColor = System.Drawing.Color.White;
            this.Table_EK.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Table_EK.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Iteration_2,
            this.EK_x,
            this.EK_Y});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Table_EK.DefaultCellStyle = dataGridViewCellStyle2;
            this.Table_EK.Location = new System.Drawing.Point(1122, 250);
            this.Table_EK.Name = "Table_EK";
            this.Table_EK.ReadOnly = true;
            this.Table_EK.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Table_EK.Size = new System.Drawing.Size(340, 223);
            this.Table_EK.TabIndex = 14;
            // 
            // Table_Eu
            // 
            this.Table_Eu.BackgroundColor = System.Drawing.Color.White;
            this.Table_Eu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Table_Eu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Iteration,
            this.Eu_X,
            this.Eu_Y});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Table_Eu.DefaultCellStyle = dataGridViewCellStyle3;
            this.Table_Eu.Location = new System.Drawing.Point(1122, 21);
            this.Table_Eu.Name = "Table_Eu";
            this.Table_Eu.ReadOnly = true;
            this.Table_Eu.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Table_Eu.Size = new System.Drawing.Size(340, 223);
            this.Table_Eu.TabIndex = 13;
            // 
            // Iteration
            // 
            this.Iteration.HeaderText = "Итерация";
            this.Iteration.Name = "Iteration";
            this.Iteration.ReadOnly = true;
            // 
            // Eu_X
            // 
            this.Eu_X.HeaderText = "x";
            this.Eu_X.Name = "Eu_X";
            this.Eu_X.ReadOnly = true;
            // 
            // Eu_Y
            // 
            this.Eu_Y.HeaderText = "y";
            this.Eu_Y.Name = "Eu_Y";
            this.Eu_Y.ReadOnly = true;
            // 
            // CheckBox_RK4
            // 
            this.CheckBox_RK4.AutoSize = true;
            this.CheckBox_RK4.Checked = true;
            this.CheckBox_RK4.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CheckBox_RK4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CheckBox_RK4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.CheckBox_RK4.Location = new System.Drawing.Point(869, 479);
            this.CheckBox_RK4.Name = "CheckBox_RK4";
            this.CheckBox_RK4.Size = new System.Drawing.Size(222, 54);
            this.CheckBox_RK4.TabIndex = 12;
            this.CheckBox_RK4.Text = "Метод Рунге-Кутта\r\n4 порядка";
            this.CheckBox_RK4.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.CheckBox_RK4.UseVisualStyleBackColor = true;
            this.CheckBox_RK4.CheckedChanged += new System.EventHandler(this.CheckBox_RK4_CheckedChanged);
            // 
            // CheckBox_EK
            // 
            this.CheckBox_EK.AutoSize = true;
            this.CheckBox_EK.Checked = true;
            this.CheckBox_EK.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CheckBox_EK.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CheckBox_EK.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.CheckBox_EK.Location = new System.Drawing.Point(869, 250);
            this.CheckBox_EK.Name = "CheckBox_EK";
            this.CheckBox_EK.Size = new System.Drawing.Size(238, 29);
            this.CheckBox_EK.TabIndex = 11;
            this.CheckBox_EK.Text = "Метод Эйлера-Коши";
            this.CheckBox_EK.UseVisualStyleBackColor = true;
            this.CheckBox_EK.CheckedChanged += new System.EventHandler(this.CheckBox_EK_CheckedChanged);
            // 
            // CheckBox_E
            // 
            this.CheckBox_E.AutoSize = true;
            this.CheckBox_E.Checked = true;
            this.CheckBox_E.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CheckBox_E.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CheckBox_E.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.CheckBox_E.Location = new System.Drawing.Point(869, 21);
            this.CheckBox_E.Name = "CheckBox_E";
            this.CheckBox_E.Size = new System.Drawing.Size(176, 29);
            this.CheckBox_E.TabIndex = 10;
            this.CheckBox_E.Text = "Метод Эйлера";
            this.CheckBox_E.UseVisualStyleBackColor = true;
            this.CheckBox_E.CheckedChanged += new System.EventHandler(this.CheckBox_E_CheckedChanged);
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(124, 30);
            this.button1.TabIndex = 0;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // Iteration_2
            // 
            this.Iteration_2.HeaderText = "Итерация";
            this.Iteration_2.Name = "Iteration_2";
            this.Iteration_2.ReadOnly = true;
            // 
            // EK_x
            // 
            this.EK_x.HeaderText = "x";
            this.EK_x.Name = "EK_x";
            this.EK_x.ReadOnly = true;
            // 
            // EK_Y
            // 
            this.EK_Y.HeaderText = "y";
            this.EK_Y.Name = "EK_Y";
            this.EK_Y.ReadOnly = true;
            // 
            // Iteration_3
            // 
            this.Iteration_3.HeaderText = "Итерация";
            this.Iteration_3.Name = "Iteration_3";
            this.Iteration_3.ReadOnly = true;
            // 
            // RK4_x
            // 
            this.RK4_x.HeaderText = "x";
            this.RK4_x.Name = "RK4_x";
            this.RK4_x.ReadOnly = true;
            // 
            // RG4_y
            // 
            this.RG4_y.HeaderText = "y";
            this.RG4_y.Name = "RG4_y";
            this.RG4_y.ReadOnly = true;
            // 
            // GraphForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(1483, 726);
            this.Controls.Add(this.panel1);
            this.Name = "GraphForm";
            this.Text = "Графики функций";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Table_RK4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Table_EK)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Table_Eu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.CheckBox CheckBox_RK4;
        private System.Windows.Forms.CheckBox CheckBox_EK;
        private System.Windows.Forms.CheckBox CheckBox_E;
        private System.Windows.Forms.DataGridView Table_Eu;
        private System.Windows.Forms.DataGridViewTextBoxColumn Iteration;
        private System.Windows.Forms.DataGridViewTextBoxColumn Eu_X;
        private System.Windows.Forms.DataGridViewTextBoxColumn Eu_Y;
        private System.Windows.Forms.DataGridView Table_RK4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private System.Windows.Forms.DataGridView Table_EK;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Iteration_3;
        private System.Windows.Forms.DataGridViewTextBoxColumn RK4_x;
        private System.Windows.Forms.DataGridViewTextBoxColumn RG4_y;
        private System.Windows.Forms.DataGridViewTextBoxColumn Iteration_2;
        private System.Windows.Forms.DataGridViewTextBoxColumn EK_x;
        private System.Windows.Forms.DataGridViewTextBoxColumn EK_Y;
    }
}