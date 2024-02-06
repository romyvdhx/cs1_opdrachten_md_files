namespace RekenMachine
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
            plus = new Button();
            six = new Button();
            five = new Button();
            four = new Button();
            three = new Button();
            two = new Button();
            one = new Button();
            seven = new Button();
            eigth = new Button();
            nine = new Button();
            minus = new Button();
            result = new TextBox();
            calc = new Button();
            SuspendLayout();
            // 
            // plus
            // 
            plus.Location = new Point(319, 162);
            plus.Name = "plus";
            plus.Size = new Size(50, 42);
            plus.TabIndex = 0;
            plus.Text = "+";
            plus.UseVisualStyleBackColor = true;
            plus.Click += plus_Click;
            // 
            // six
            // 
            six.Location = new Point(189, 210);
            six.Name = "six";
            six.Size = new Size(50, 42);
            six.TabIndex = 1;
            six.Text = "6";
            six.UseVisualStyleBackColor = true;
            six.Click += six_Click;
            // 
            // five
            // 
            five.Location = new Point(124, 210);
            five.Name = "five";
            five.Size = new Size(50, 42);
            five.TabIndex = 2;
            five.Text = "5";
            five.UseVisualStyleBackColor = true;
            five.Click += five_Click;
            // 
            // four
            // 
            four.Location = new Point(55, 210);
            four.Name = "four";
            four.Size = new Size(50, 42);
            four.TabIndex = 3;
            four.Text = "4";
            four.UseVisualStyleBackColor = true;
            four.Click += four_Click;
            // 
            // three
            // 
            three.Location = new Point(189, 162);
            three.Name = "three";
            three.Size = new Size(50, 42);
            three.TabIndex = 4;
            three.Text = "3";
            three.UseVisualStyleBackColor = true;
            three.Click += three_Click;
            // 
            // two
            // 
            two.Location = new Point(124, 162);
            two.Name = "two";
            two.Size = new Size(50, 42);
            two.TabIndex = 5;
            two.Text = "2";
            two.UseVisualStyleBackColor = true;
            two.Click += two_Click;
            // 
            // one
            // 
            one.Location = new Point(55, 162);
            one.Name = "one";
            one.Size = new Size(50, 42);
            one.TabIndex = 6;
            one.Text = "1";
            one.UseVisualStyleBackColor = true;
            one.Click += one_Click;
            // 
            // seven
            // 
            seven.Location = new Point(55, 258);
            seven.Name = "seven";
            seven.Size = new Size(50, 42);
            seven.TabIndex = 9;
            seven.Text = "7";
            seven.UseVisualStyleBackColor = true;
            seven.Click += seven_Click;
            // 
            // eigth
            // 
            eigth.Location = new Point(124, 258);
            eigth.Name = "eigth";
            eigth.Size = new Size(50, 42);
            eigth.TabIndex = 8;
            eigth.Text = "8";
            eigth.UseVisualStyleBackColor = true;
            eigth.Click += eigth_Click;
            // 
            // nine
            // 
            nine.Location = new Point(189, 258);
            nine.Name = "nine";
            nine.Size = new Size(50, 42);
            nine.TabIndex = 7;
            nine.Text = "9";
            nine.UseVisualStyleBackColor = true;
            nine.Click += nine_Click;
            // 
            // minus
            // 
            minus.Location = new Point(319, 210);
            minus.Name = "minus";
            minus.Size = new Size(50, 42);
            minus.TabIndex = 10;
            minus.Text = "-";
            minus.UseVisualStyleBackColor = true;
            minus.Click += minus_Click;
            // 
            // result
            // 
            result.Enabled = false;
            result.Location = new Point(55, 96);
            result.Name = "result";
            result.Size = new Size(184, 23);
            result.TabIndex = 11;
            // 
            // calc
            // 
            calc.Location = new Point(55, 316);
            calc.Name = "calc";
            calc.Size = new Size(184, 42);
            calc.TabIndex = 12;
            calc.Text = "=";
            calc.UseVisualStyleBackColor = true;
            calc.Click += calc_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(calc);
            Controls.Add(result);
            Controls.Add(minus);
            Controls.Add(seven);
            Controls.Add(eigth);
            Controls.Add(nine);
            Controls.Add(one);
            Controls.Add(two);
            Controls.Add(three);
            Controls.Add(four);
            Controls.Add(five);
            Controls.Add(six);
            Controls.Add(plus);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button plus;
        private Button six;
        private Button five;
        private Button four;
        private Button three;
        private Button two;
        private Button one;
        private Button seven;
        private Button eigth;
        private Button nine;
        private Button minus;
        private TextBox result;
        private Button calc;
    }
}
