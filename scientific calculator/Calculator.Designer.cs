namespace scientific_calculator
{
    partial class Calculator
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
            Screen = new TextBox();
            Clear = new Button();
            Erase = new Button();
            Modulus = new Button();
            Divide = new Button();
            Multiply = new Button();
            Minus = new Button();
            Plus = new Button();
            Result = new Button();
            Nine = new Button();
            Six = new Button();
            Three = new Button();
            Negation = new Button();
            Eight = new Button();
            Five = new Button();
            Two = new Button();
            Point = new Button();
            Seven = new Button();
            Four = new Button();
            One = new Button();
            Zero = new Button();
            Factorial = new Button();
            Power = new Button();
            Sin = new Button();
            Cosine = new Button();
            Tangent = new Button();
            Logarithm = new Button();
            Sinhyperbolic = new Button();
            coshyperbolic = new Button();
            tanhyperbolic = new Button();
            SuspendLayout();
            // 
            // Screen
            // 
            Screen.BackColor = SystemColors.ActiveBorder;
            Screen.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            Screen.Location = new Point(57, 42);
            Screen.Name = "Screen";
            Screen.ReadOnly = true;
            Screen.Size = new Size(471, 47);
            Screen.TabIndex = 0;
            Screen.Text = "0";
            Screen.TextAlign = HorizontalAlignment.Right;
            // 
            // Clear
            // 
            Clear.BackColor = Color.SpringGreen;
            Clear.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Clear.ForeColor = Color.Red;
            Clear.Location = new Point(57, 122);
            Clear.Name = "Clear";
            Clear.Size = new Size(77, 41);
            Clear.TabIndex = 1;
            Clear.Text = "C";
            Clear.UseVisualStyleBackColor = false;
            Clear.Click += Clear_Click;
            // 
            // Erase
            // 
            Erase.BackColor = Color.Yellow;
            Erase.Location = new Point(187, 123);
            Erase.Name = "Erase";
            Erase.Size = new Size(77, 41);
            Erase.TabIndex = 2;
            Erase.Text = "E";
            Erase.UseVisualStyleBackColor = false;
            Erase.Click += Erase_Click;
            // 
            // Modulus
            // 
            Modulus.BackColor = Color.Red;
            Modulus.Location = new Point(326, 123);
            Modulus.Name = "Modulus";
            Modulus.Size = new Size(77, 41);
            Modulus.TabIndex = 3;
            Modulus.Text = "%";
            Modulus.UseVisualStyleBackColor = false;
            Modulus.Click += Modulus_Click;
            // 
            // Divide
            // 
            Divide.BackColor = Color.Red;
            Divide.Location = new Point(451, 123);
            Divide.Name = "Divide";
            Divide.Size = new Size(77, 41);
            Divide.TabIndex = 4;
            Divide.Text = "/";
            Divide.UseVisualStyleBackColor = false;
            Divide.Click += Divide_Click;
            // 
            // Multiply
            // 
            Multiply.BackColor = Color.Red;
            Multiply.Location = new Point(451, 206);
            Multiply.Name = "Multiply";
            Multiply.Size = new Size(77, 41);
            Multiply.TabIndex = 5;
            Multiply.Text = "*";
            Multiply.UseVisualStyleBackColor = false;
            Multiply.Click += Multiply_Click;
            // 
            // Minus
            // 
            Minus.BackColor = Color.Red;
            Minus.Location = new Point(451, 283);
            Minus.Name = "Minus";
            Minus.Size = new Size(77, 41);
            Minus.TabIndex = 6;
            Minus.Text = "-";
            Minus.UseVisualStyleBackColor = false;
            Minus.Click += Minus_Click;
            // 
            // Plus
            // 
            Plus.BackColor = Color.Red;
            Plus.Location = new Point(451, 366);
            Plus.Name = "Plus";
            Plus.Size = new Size(77, 41);
            Plus.TabIndex = 7;
            Plus.Text = "+";
            Plus.UseVisualStyleBackColor = false;
            Plus.Click += Plus_Click;
            // 
            // Result
            // 
            Result.BackColor = SystemColors.MenuHighlight;
            Result.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Result.ForeColor = Color.Black;
            Result.Location = new Point(451, 445);
            Result.Name = "Result";
            Result.Size = new Size(77, 41);
            Result.TabIndex = 8;
            Result.Text = "=";
            Result.UseVisualStyleBackColor = false;
            Result.Click += Result_Click;
            // 
            // Nine
            // 
            Nine.Location = new Point(326, 206);
            Nine.Name = "Nine";
            Nine.Size = new Size(77, 41);
            Nine.TabIndex = 9;
            Nine.Text = "9";
            Nine.UseVisualStyleBackColor = true;
            Nine.Click += Nine_Click;
            // 
            // Six
            // 
            Six.Location = new Point(326, 283);
            Six.Name = "Six";
            Six.Size = new Size(77, 41);
            Six.TabIndex = 10;
            Six.Text = "6";
            Six.UseVisualStyleBackColor = true;
            Six.Click += Six_Click;
            // 
            // Three
            // 
            Three.Location = new Point(326, 366);
            Three.Name = "Three";
            Three.Size = new Size(77, 41);
            Three.TabIndex = 11;
            Three.Text = "3";
            Three.UseVisualStyleBackColor = true;
            Three.Click += Three_Click;
            // 
            // Negation
            // 
            Negation.Location = new Point(326, 445);
            Negation.Name = "Negation";
            Negation.Size = new Size(77, 41);
            Negation.TabIndex = 12;
            Negation.Text = "+/-";
            Negation.UseVisualStyleBackColor = true;
            Negation.Click += Negation_Click;
            // 
            // Eight
            // 
            Eight.Location = new Point(187, 206);
            Eight.Name = "Eight";
            Eight.Size = new Size(77, 41);
            Eight.TabIndex = 13;
            Eight.Text = "8";
            Eight.UseVisualStyleBackColor = true;
            Eight.Click += Eight_Click;
            // 
            // Five
            // 
            Five.Location = new Point(187, 283);
            Five.Name = "Five";
            Five.Size = new Size(77, 41);
            Five.TabIndex = 14;
            Five.Text = "5";
            Five.UseVisualStyleBackColor = true;
            Five.Click += Five_Click;
            // 
            // Two
            // 
            Two.Location = new Point(187, 366);
            Two.Name = "Two";
            Two.Size = new Size(77, 41);
            Two.TabIndex = 15;
            Two.Text = "2";
            Two.UseVisualStyleBackColor = true;
            Two.Click += Two_Click;
            // 
            // Point
            // 
            Point.Location = new Point(187, 445);
            Point.Name = "Point";
            Point.Size = new Size(77, 41);
            Point.TabIndex = 16;
            Point.Text = ".";
            Point.UseVisualStyleBackColor = true;
            Point.Click += Point_Click;
            // 
            // Seven
            // 
            Seven.Location = new Point(57, 206);
            Seven.Name = "Seven";
            Seven.Size = new Size(77, 41);
            Seven.TabIndex = 17;
            Seven.Text = "7";
            Seven.UseVisualStyleBackColor = true;
            Seven.Click += Seven_Click;
            // 
            // Four
            // 
            Four.Location = new Point(57, 283);
            Four.Name = "Four";
            Four.Size = new Size(77, 41);
            Four.TabIndex = 18;
            Four.Text = "4";
            Four.UseVisualStyleBackColor = true;
            Four.Click += Four_Click;
            // 
            // One
            // 
            One.Location = new Point(57, 366);
            One.Name = "One";
            One.Size = new Size(77, 41);
            One.TabIndex = 19;
            One.Text = "1";
            One.UseVisualStyleBackColor = true;
            One.Click += One_Click;
            // 
            // Zero
            // 
            Zero.Location = new Point(57, 445);
            Zero.Name = "Zero";
            Zero.Size = new Size(77, 41);
            Zero.TabIndex = 20;
            Zero.Text = "0";
            Zero.UseVisualStyleBackColor = true;
            Zero.Click += Zero_Click;
            // 
            // Factorial
            // 
            Factorial.Location = new Point(634, 42);
            Factorial.Name = "Factorial";
            Factorial.Size = new Size(79, 39);
            Factorial.TabIndex = 21;
            Factorial.Text = "!";
            Factorial.UseVisualStyleBackColor = true;
            Factorial.Click += Factorial_Click;
            // 
            // Power
            // 
            Power.Location = new Point(634, 122);
            Power.Name = "Power";
            Power.Size = new Size(79, 38);
            Power.TabIndex = 22;
            Power.Text = "^";
            Power.UseVisualStyleBackColor = true;
            Power.Click += Power_Click;
            // 
            // Sin
            // 
            Sin.BackColor = SystemColors.Highlight;
            Sin.Location = new Point(634, 206);
            Sin.Name = "Sin";
            Sin.Size = new Size(79, 39);
            Sin.TabIndex = 23;
            Sin.Text = "sin()";
            Sin.UseVisualStyleBackColor = false;
            Sin.Click += Sin_Click;
            // 
            // Cosine
            // 
            Cosine.BackColor = Color.RoyalBlue;
            Cosine.Location = new Point(634, 282);
            Cosine.Name = "Cosine";
            Cosine.Size = new Size(79, 42);
            Cosine.TabIndex = 24;
            Cosine.Text = "cos()";
            Cosine.UseVisualStyleBackColor = false;
            Cosine.Click += Cosine_Click;
            // 
            // Tangent
            // 
            Tangent.BackColor = Color.RoyalBlue;
            Tangent.Location = new Point(634, 365);
            Tangent.Name = "Tangent";
            Tangent.Size = new Size(79, 42);
            Tangent.TabIndex = 25;
            Tangent.Text = "tan()";
            Tangent.UseVisualStyleBackColor = false;
            Tangent.Click += Tangent_Click;
            // 
            // Logarithm
            // 
            Logarithm.Location = new Point(634, 445);
            Logarithm.Name = "Logarithm";
            Logarithm.Size = new Size(79, 39);
            Logarithm.TabIndex = 26;
            Logarithm.Text = "log";
            Logarithm.UseVisualStyleBackColor = true;
            Logarithm.Click += Logarithm_Click;
            // 
            // Sinhyperbolic
            // 
            Sinhyperbolic.Location = new Point(818, 86);
            Sinhyperbolic.Name = "Sinhyperbolic";
            Sinhyperbolic.Size = new Size(198, 43);
            Sinhyperbolic.TabIndex = 27;
            Sinhyperbolic.Text = "sinh";
            Sinhyperbolic.UseVisualStyleBackColor = true;
            Sinhyperbolic.Click += Sinhyperbolic_Click;
            // 
            // coshyperbolic
            // 
            coshyperbolic.Location = new Point(818, 243);
            coshyperbolic.Name = "coshyperbolic";
            coshyperbolic.Size = new Size(198, 43);
            coshyperbolic.TabIndex = 28;
            coshyperbolic.Text = "cosh";
            coshyperbolic.UseVisualStyleBackColor = true;
            coshyperbolic.Click += coshyperbolic_Click;
            // 
            // tanhyperbolic
            // 
            tanhyperbolic.Location = new Point(818, 398);
            tanhyperbolic.Name = "tanhyperbolic";
            tanhyperbolic.Size = new Size(198, 43);
            tanhyperbolic.TabIndex = 29;
            tanhyperbolic.Text = "tanh";
            tanhyperbolic.UseVisualStyleBackColor = true;
            tanhyperbolic.Click += tanhyperbolic_Click;
            // 
            // Calculator
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(1071, 533);
            Controls.Add(tanhyperbolic);
            Controls.Add(coshyperbolic);
            Controls.Add(Sinhyperbolic);
            Controls.Add(Logarithm);
            Controls.Add(Tangent);
            Controls.Add(Cosine);
            Controls.Add(Sin);
            Controls.Add(Power);
            Controls.Add(Factorial);
            Controls.Add(Zero);
            Controls.Add(One);
            Controls.Add(Four);
            Controls.Add(Seven);
            Controls.Add(Point);
            Controls.Add(Two);
            Controls.Add(Five);
            Controls.Add(Eight);
            Controls.Add(Negation);
            Controls.Add(Three);
            Controls.Add(Six);
            Controls.Add(Nine);
            Controls.Add(Result);
            Controls.Add(Plus);
            Controls.Add(Minus);
            Controls.Add(Multiply);
            Controls.Add(Divide);
            Controls.Add(Modulus);
            Controls.Add(Erase);
            Controls.Add(Clear);
            Controls.Add(Screen);
            Name = "Calculator";
            Text = "Calculator";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox Screen;
        private Button Clear;
        private Button Erase;
        private Button Modulus;
        private Button Divide;
        private Button Multiply;
        private Button Minus;
        private Button Plus;
        private Button Result;
        private Button Nine;
        private Button Six;
        private Button Three;
        private Button Negation;
        private Button Eight;
        private Button Five;
        private Button Two;
        private Button Point;
        private Button Seven;
        private Button Four;
        private Button One;
        private Button Zero;
        private Button Factorial;
        private Button Power;
        private Button Sin;
        private Button Cosine;
        private Button Tangent;
        private Button Logarithm;
        private Button Sinhyperbolic;
        private Button coshyperbolic;
        private Button tanhyperbolic;
    }
}