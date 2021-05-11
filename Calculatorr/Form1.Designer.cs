
namespace Calculatorr
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.bC = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.bSqrt = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.button17 = new System.Windows.Forms.Button();
            this.button18 = new System.Windows.Forms.Button();
            this.button19 = new System.Windows.Forms.Button();
            this.button20 = new System.Windows.Forms.Button();
            this.bDot = new System.Windows.Forms.Button();
            this.button21 = new System.Windows.Forms.Button();
            this.bEqual = new System.Windows.Forms.Button();
            this.textBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lb = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(144, 121);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(82, 55);
            this.button1.TabIndex = 0;
            this.button1.Text = "M+";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.MemoryResult);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(232, 121);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(82, 55);
            this.button2.TabIndex = 1;
            this.button2.Text = "M-";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.MemoryResult);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(320, 121);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(82, 55);
            this.button3.TabIndex = 2;
            this.button3.Text = "MC";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.MemoryResult);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(408, 121);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(82, 55);
            this.button4.TabIndex = 3;
            this.button4.Text = "MR";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.MemoryResult);
            // 
            // bC
            // 
            this.bC.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.bC.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bC.Location = new System.Drawing.Point(496, 121);
            this.bC.Name = "bC";
            this.bC.Size = new System.Drawing.Size(82, 55);
            this.bC.TabIndex = 4;
            this.bC.Text = "C";
            this.bC.UseVisualStyleBackColor = false;
            this.bC.Click += new System.EventHandler(this.bC_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.SystemColors.ControlDark;
            this.button6.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Location = new System.Drawing.Point(496, 182);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(82, 55);
            this.button6.TabIndex = 9;
            this.button6.Text = "/";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.Operations);
            // 
            // bSqrt
            // 
            this.bSqrt.BackColor = System.Drawing.SystemColors.ControlDark;
            this.bSqrt.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bSqrt.Location = new System.Drawing.Point(408, 182);
            this.bSqrt.Name = "bSqrt";
            this.bSqrt.Size = new System.Drawing.Size(82, 55);
            this.bSqrt.TabIndex = 8;
            this.bSqrt.Text = "√x ";
            this.bSqrt.UseVisualStyleBackColor = false;
            this.bSqrt.Click += new System.EventHandler(this.bSqrt_Click);
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.SystemColors.ControlDark;
            this.button8.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.Location = new System.Drawing.Point(320, 182);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(82, 55);
            this.button8.TabIndex = 7;
            this.button8.Text = "9";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.NumResult);
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.SystemColors.ControlDark;
            this.button9.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button9.Location = new System.Drawing.Point(232, 182);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(82, 55);
            this.button9.TabIndex = 6;
            this.button9.Text = "8";
            this.button9.UseVisualStyleBackColor = false;
            this.button9.Click += new System.EventHandler(this.NumResult);
            // 
            // button10
            // 
            this.button10.BackColor = System.Drawing.SystemColors.ControlDark;
            this.button10.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button10.Location = new System.Drawing.Point(144, 182);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(82, 55);
            this.button10.TabIndex = 5;
            this.button10.Text = "7";
            this.button10.UseVisualStyleBackColor = false;
            this.button10.Click += new System.EventHandler(this.NumResult);
            // 
            // button11
            // 
            this.button11.BackColor = System.Drawing.SystemColors.ControlDark;
            this.button11.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button11.Location = new System.Drawing.Point(496, 243);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(82, 116);
            this.button11.TabIndex = 14;
            this.button11.Text = "+";
            this.button11.UseVisualStyleBackColor = false;
            this.button11.Click += new System.EventHandler(this.Operations);
            // 
            // button12
            // 
            this.button12.BackColor = System.Drawing.SystemColors.ControlDark;
            this.button12.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button12.Location = new System.Drawing.Point(408, 243);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(82, 55);
            this.button12.TabIndex = 13;
            this.button12.Text = "-";
            this.button12.UseVisualStyleBackColor = false;
            this.button12.Click += new System.EventHandler(this.Operations);
            // 
            // button13
            // 
            this.button13.BackColor = System.Drawing.SystemColors.ControlDark;
            this.button13.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button13.Location = new System.Drawing.Point(320, 243);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(82, 55);
            this.button13.TabIndex = 12;
            this.button13.Text = "6";
            this.button13.UseVisualStyleBackColor = false;
            this.button13.Click += new System.EventHandler(this.NumResult);
            // 
            // button14
            // 
            this.button14.BackColor = System.Drawing.SystemColors.ControlDark;
            this.button14.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button14.Location = new System.Drawing.Point(232, 243);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(82, 55);
            this.button14.TabIndex = 11;
            this.button14.Text = "5";
            this.button14.UseVisualStyleBackColor = false;
            this.button14.Click += new System.EventHandler(this.NumResult);
            // 
            // button15
            // 
            this.button15.BackColor = System.Drawing.SystemColors.ControlDark;
            this.button15.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button15.Location = new System.Drawing.Point(144, 243);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(82, 55);
            this.button15.TabIndex = 10;
            this.button15.Text = "4";
            this.button15.UseVisualStyleBackColor = false;
            this.button15.Click += new System.EventHandler(this.NumResult);
            // 
            // button17
            // 
            this.button17.BackColor = System.Drawing.SystemColors.ControlDark;
            this.button17.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button17.Location = new System.Drawing.Point(408, 304);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(82, 55);
            this.button17.TabIndex = 18;
            this.button17.Text = "*";
            this.button17.UseVisualStyleBackColor = false;
            this.button17.Click += new System.EventHandler(this.Operations);
            // 
            // button18
            // 
            this.button18.BackColor = System.Drawing.SystemColors.ControlDark;
            this.button18.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button18.Location = new System.Drawing.Point(320, 304);
            this.button18.Name = "button18";
            this.button18.Size = new System.Drawing.Size(82, 55);
            this.button18.TabIndex = 17;
            this.button18.Text = "3";
            this.button18.UseVisualStyleBackColor = false;
            this.button18.Click += new System.EventHandler(this.NumResult);
            // 
            // button19
            // 
            this.button19.BackColor = System.Drawing.SystemColors.ControlDark;
            this.button19.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button19.Location = new System.Drawing.Point(232, 304);
            this.button19.Name = "button19";
            this.button19.Size = new System.Drawing.Size(82, 55);
            this.button19.TabIndex = 16;
            this.button19.Text = "2";
            this.button19.UseVisualStyleBackColor = false;
            this.button19.Click += new System.EventHandler(this.NumResult);
            // 
            // button20
            // 
            this.button20.BackColor = System.Drawing.SystemColors.ControlDark;
            this.button20.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button20.Location = new System.Drawing.Point(144, 304);
            this.button20.Name = "button20";
            this.button20.Size = new System.Drawing.Size(82, 55);
            this.button20.TabIndex = 15;
            this.button20.Text = "1";
            this.button20.UseVisualStyleBackColor = false;
            this.button20.Click += new System.EventHandler(this.NumResult);
            // 
            // bDot
            // 
            this.bDot.BackColor = System.Drawing.SystemColors.ControlDark;
            this.bDot.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bDot.Location = new System.Drawing.Point(320, 365);
            this.bDot.Name = "bDot";
            this.bDot.Size = new System.Drawing.Size(82, 55);
            this.bDot.TabIndex = 19;
            this.bDot.Text = ".";
            this.bDot.UseVisualStyleBackColor = false;
            this.bDot.Click += new System.EventHandler(this.bDot_Click);
            // 
            // button21
            // 
            this.button21.BackColor = System.Drawing.SystemColors.ControlDark;
            this.button21.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button21.Location = new System.Drawing.Point(144, 365);
            this.button21.Name = "button21";
            this.button21.Size = new System.Drawing.Size(170, 55);
            this.button21.TabIndex = 20;
            this.button21.Text = "0";
            this.button21.UseVisualStyleBackColor = false;
            this.button21.Click += new System.EventHandler(this.NumResult);
            // 
            // bEqual
            // 
            this.bEqual.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.bEqual.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bEqual.Location = new System.Drawing.Point(408, 365);
            this.bEqual.Name = "bEqual";
            this.bEqual.Size = new System.Drawing.Size(170, 55);
            this.bEqual.TabIndex = 21;
            this.bEqual.Text = "=";
            this.bEqual.UseVisualStyleBackColor = false;
            this.bEqual.Click += new System.EventHandler(this.bEqual_Click);
            // 
            // textBox
            // 
            this.textBox.Location = new System.Drawing.Point(144, 44);
            this.textBox.Multiline = true;
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(434, 71);
            this.textBox.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(194, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 17);
            this.label1.TabIndex = 23;
            // 
            // lb
            // 
            this.lb.AutoSize = true;
            this.lb.Location = new System.Drawing.Point(148, 21);
            this.lb.Name = "lb";
            this.lb.Size = new System.Drawing.Size(0, 17);
            this.lb.TabIndex = 24;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(758, 450);
            this.Controls.Add(this.lb);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox);
            this.Controls.Add(this.bEqual);
            this.Controls.Add(this.button21);
            this.Controls.Add(this.bDot);
            this.Controls.Add(this.button17);
            this.Controls.Add(this.button18);
            this.Controls.Add(this.button19);
            this.Controls.Add(this.button20);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.button13);
            this.Controls.Add(this.button14);
            this.Controls.Add(this.button15);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.bSqrt);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.bC);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button bC;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button bSqrt;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Button button17;
        private System.Windows.Forms.Button button18;
        private System.Windows.Forms.Button button19;
        private System.Windows.Forms.Button button20;
        private System.Windows.Forms.Button bDot;
        private System.Windows.Forms.Button button21;
        private System.Windows.Forms.Button bEqual;
        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lb;
    }
}

