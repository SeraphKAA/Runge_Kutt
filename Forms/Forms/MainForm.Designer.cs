namespace Forms
{
    partial class MainForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.FuncBox = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.StepBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.Y0Box = new System.Windows.Forms.TextBox();
            this.X0Box = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.RightEdge_B = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.LeftEdge_A = new System.Windows.Forms.TextBox();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(136, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 29);
            this.label2.TabIndex = 2;
            this.label2.Text = "ОДУ y\'=";
            // 
            // FuncBox
            // 
            this.FuncBox.Font = new System.Drawing.Font("Times New Roman", 18F);
            this.FuncBox.Location = new System.Drawing.Point(236, 49);
            this.FuncBox.Name = "FuncBox";
            this.FuncBox.Size = new System.Drawing.Size(246, 35);
            this.FuncBox.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.FuncBox);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.StepBox);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.Y0Box);
            this.panel2.Controls.Add(this.X0Box);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.RightEdge_B);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.LeftEdge_A);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(699, 416);
            this.panel2.TabIndex = 3;
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(48, 304);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(38, 29);
            this.label10.TabIndex = 24;
            this.label10.Text = "n =";
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(359, 218);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 29);
            this.label7.TabIndex = 23;
            this.label7.Text = "y0 =";
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(38, 218);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 29);
            this.label6.TabIndex = 22;
            this.label6.Text = "x0 =";
            // 
            // StepBox
            // 
            this.StepBox.Font = new System.Drawing.Font("Times New Roman", 18F);
            this.StepBox.Location = new System.Drawing.Point(92, 299);
            this.StepBox.Name = "StepBox";
            this.StepBox.Size = new System.Drawing.Size(246, 35);
            this.StepBox.TabIndex = 17;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.Location = new System.Drawing.Point(576, 329);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(84, 63);
            this.button1.TabIndex = 3;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.button1_KeyDown);
            this.button1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.button1_MouseClick);
            // 
            // Y0Box
            // 
            this.Y0Box.Font = new System.Drawing.Font("Times New Roman", 18F);
            this.Y0Box.Location = new System.Drawing.Point(414, 213);
            this.Y0Box.Name = "Y0Box";
            this.Y0Box.Size = new System.Drawing.Size(246, 35);
            this.Y0Box.TabIndex = 14;
            // 
            // X0Box
            // 
            this.X0Box.Font = new System.Drawing.Font("Times New Roman", 18F);
            this.X0Box.Location = new System.Drawing.Point(92, 214);
            this.X0Box.Name = "X0Box";
            this.X0Box.Size = new System.Drawing.Size(246, 35);
            this.X0Box.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(370, 141);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 29);
            this.label5.TabIndex = 9;
            this.label5.Text = "b =";
            // 
            // RightEdge_B
            // 
            this.RightEdge_B.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RightEdge_B.Location = new System.Drawing.Point(414, 136);
            this.RightEdge_B.Name = "RightEdge_B";
            this.RightEdge_B.Size = new System.Drawing.Size(246, 35);
            this.RightEdge_B.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(48, 141);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 29);
            this.label4.TabIndex = 6;
            this.label4.Text = "a =";
            // 
            // LeftEdge_A
            // 
            this.LeftEdge_A.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LeftEdge_A.Location = new System.Drawing.Point(92, 137);
            this.LeftEdge_A.Name = "LeftEdge_A";
            this.LeftEdge_A.Size = new System.Drawing.Size(246, 35);
            this.LeftEdge_A.TabIndex = 5;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(699, 416);
            this.Controls.Add(this.panel2);
            this.Name = "MainForm";
            this.Text = "Численные методы решения ОДУ ";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox FuncBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox Y0Box;
        private System.Windows.Forms.TextBox X0Box;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox RightEdge_B;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox LeftEdge_A;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox StepBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label10;
    }
}