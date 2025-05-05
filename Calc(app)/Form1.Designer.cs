namespace Calc_app_
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
            AnsTxt = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            button10 = new Button();
            button11 = new Button();
            button12 = new Button();
            BtnExit = new Button();
            button13 = new Button();
            button14 = new Button();
            button15 = new Button();
            button16 = new Button();
            SuspendLayout();
            // 
            // AnsTxt
            // 
            AnsTxt.Location = new Point(151, 83);
            AnsTxt.Name = "AnsTxt";
            AnsTxt.ReadOnly = true;
            AnsTxt.Size = new Size(294, 23);
            AnsTxt.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(48, 145);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 1;
            button1.Text = "1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button_Click;
            // 
            // button2
            // 
            button2.Location = new Point(159, 145);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 2;
            button2.Text = "2";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button_Click;
            // 
            // button3
            // 
            button3.Location = new Point(266, 145);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 3;
            button3.Text = "3";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button_Click;
            // 
            // button4
            // 
            button4.Location = new Point(48, 203);
            button4.Name = "button4";
            button4.Size = new Size(75, 23);
            button4.TabIndex = 4;
            button4.Text = "4";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button_Click;
            // 
            // button5
            // 
            button5.Location = new Point(159, 203);
            button5.Name = "button5";
            button5.Size = new Size(75, 23);
            button5.TabIndex = 5;
            button5.Text = "5";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button_Click;
            // 
            // button6
            // 
            button6.Location = new Point(266, 203);
            button6.Name = "button6";
            button6.Size = new Size(75, 23);
            button6.TabIndex = 6;
            button6.Text = "6";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button_Click;
            // 
            // button7
            // 
            button7.Location = new Point(48, 262);
            button7.Name = "button7";
            button7.Size = new Size(75, 23);
            button7.TabIndex = 7;
            button7.Text = "7";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button_Click;
            // 
            // button8
            // 
            button8.Location = new Point(159, 262);
            button8.Name = "button8";
            button8.Size = new Size(75, 23);
            button8.TabIndex = 8;
            button8.Text = "8";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button_Click;
            // 
            // button9
            // 
            button9.Location = new Point(266, 262);
            button9.Name = "button9";
            button9.Size = new Size(75, 23);
            button9.TabIndex = 9;
            button9.Text = "9";
            button9.UseVisualStyleBackColor = true;
            button9.Click += button_Click;
            // 
            // button10
            // 
            button10.Location = new Point(48, 320);
            button10.Name = "button10";
            button10.Size = new Size(75, 23);
            button10.TabIndex = 10;
            button10.Text = "0";
            button10.UseVisualStyleBackColor = true;
            button10.Click += button_Click;
            // 
            // button11
            // 
            button11.Location = new Point(317, 392);
            button11.Name = "button11";
            button11.Size = new Size(75, 23);
            button11.TabIndex = 11;
            button11.Text = "Clear";
            button11.UseVisualStyleBackColor = true;
            button11.Click += BtnClear_Click;
            // 
            // button12
            // 
            button12.Location = new Point(159, 320);
            button12.Name = "button12";
            button12.Size = new Size(75, 23);
            button12.TabIndex = 12;
            button12.Text = "=";
            button12.UseVisualStyleBackColor = true;
            button12.Click += BtnEqual_click;
            // 
            // BtnExit
            // 
            BtnExit.Location = new Point(416, 392);
            BtnExit.Name = "BtnExit";
            BtnExit.Size = new Size(75, 23);
            BtnExit.TabIndex = 13;
            BtnExit.Text = "Exit";
            BtnExit.UseVisualStyleBackColor = true;
            BtnExit.Click += BtnExit_click;
            // 
            // button13
            // 
            button13.Location = new Point(370, 262);
            button13.Name = "button13";
            button13.Size = new Size(75, 23);
            button13.TabIndex = 14;
            button13.Text = "-";
            button13.UseVisualStyleBackColor = true;
            button13.Click += BtnOp_click;
            // 
            // button14
            // 
            button14.Location = new Point(370, 145);
            button14.Name = "button14";
            button14.Size = new Size(75, 23);
            button14.TabIndex = 15;
            button14.Text = "+";
            button14.UseVisualStyleBackColor = true;
            button14.Click += BtnOp_click;
            // 
            // button15
            // 
            button15.Location = new Point(370, 203);
            button15.Name = "button15";
            button15.Size = new Size(75, 23);
            button15.TabIndex = 16;
            button15.Text = "/";
            button15.UseVisualStyleBackColor = true;
            // 
            // button16
            // 
            button16.Location = new Point(266, 320);
            button16.Name = "button16";
            button16.Size = new Size(75, 23);
            button16.TabIndex = 17;
            button16.Text = "*";
            button16.UseVisualStyleBackColor = true;
            button16.Click += BtnOp_click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button16);
            Controls.Add(button15);
            Controls.Add(button14);
            Controls.Add(button13);
            Controls.Add(BtnExit);
            Controls.Add(button12);
            Controls.Add(button11);
            Controls.Add(button10);
            Controls.Add(button9);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(AnsTxt);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox AnsTxt;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
        private Button button10;
        private Button button11;
        private Button button12;
        private Button BtnExit;
        private Button button13;
        private Button button14;
        private Button button15;
        private Button button16;
    }
}
