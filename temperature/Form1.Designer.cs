namespace temperature
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
            textBox1 = new TextBox();
            ConvertBtn = new Button();
            deleteBtn = new Button();
            label1 = new Label();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(259, 132);
            button1.Name = "button1";
            button1.Size = new Size(64, 51);
            button1.TabIndex = 0;
            button1.Text = "1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += NumButton_Click;
            // 
            // button2
            // 
            button2.Location = new Point(329, 132);
            button2.Name = "button2";
            button2.Size = new Size(64, 51);
            button2.TabIndex = 1;
            button2.Text = "2";
            button2.UseVisualStyleBackColor = true;
            button2.Click += NumButton_Click;
            // 
            // button3
            // 
            button3.Location = new Point(399, 132);
            button3.Name = "button3";
            button3.Size = new Size(64, 51);
            button3.TabIndex = 2;
            button3.Text = "3";
            button3.UseVisualStyleBackColor = true;
            button3.Click += NumButton_Click;
            // 
            // button4
            // 
            button4.Location = new Point(259, 189);
            button4.Name = "button4";
            button4.Size = new Size(64, 51);
            button4.TabIndex = 3;
            button4.Text = "4";
            button4.UseVisualStyleBackColor = true;
            button4.Click += NumButton_Click;
            // 
            // button5
            // 
            button5.Location = new Point(329, 189);
            button5.Name = "button5";
            button5.Size = new Size(64, 51);
            button5.TabIndex = 4;
            button5.Text = "5";
            button5.UseVisualStyleBackColor = true;
            button5.Click += NumButton_Click;
            // 
            // button6
            // 
            button6.Location = new Point(399, 189);
            button6.Name = "button6";
            button6.Size = new Size(64, 51);
            button6.TabIndex = 5;
            button6.Text = "6";
            button6.UseVisualStyleBackColor = true;
            button6.Click += NumButton_Click;
            // 
            // button7
            // 
            button7.Location = new Point(259, 246);
            button7.Name = "button7";
            button7.Size = new Size(64, 51);
            button7.TabIndex = 6;
            button7.Text = "7";
            button7.UseVisualStyleBackColor = true;
            button7.Click += NumButton_Click;
            // 
            // button8
            // 
            button8.Location = new Point(329, 246);
            button8.Name = "button8";
            button8.Size = new Size(64, 51);
            button8.TabIndex = 7;
            button8.Text = "8";
            button8.UseVisualStyleBackColor = true;
            button8.Click += NumButton_Click;
            // 
            // button9
            // 
            button9.Location = new Point(399, 246);
            button9.Name = "button9";
            button9.Size = new Size(64, 51);
            button9.TabIndex = 8;
            button9.Text = "9";
            button9.UseVisualStyleBackColor = true;
            button9.Click += NumButton_Click;
            // 
            // button10
            // 
            button10.Location = new Point(329, 303);
            button10.Name = "button10";
            button10.Size = new Size(64, 51);
            button10.TabIndex = 9;
            button10.Text = ".";
            button10.UseVisualStyleBackColor = true;
            button10.Click += NumButton_Click;
            // 
            // button11
            // 
            button11.Location = new Point(259, 303);
            button11.Name = "button11";
            button11.Size = new Size(64, 51);
            button11.TabIndex = 10;
            button11.Text = "0";
            button11.UseVisualStyleBackColor = true;
            button11.Click += NumButton_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(542, 169);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(223, 30);
            textBox1.TabIndex = 11;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // ConvertBtn
            // 
            ConvertBtn.Location = new Point(542, 224);
            ConvertBtn.Name = "ConvertBtn";
            ConvertBtn.Size = new Size(108, 54);
            ConvertBtn.TabIndex = 12;
            ConvertBtn.Text = "轉換";
            ConvertBtn.UseVisualStyleBackColor = true;
            ConvertBtn.Click += button12_Click;
            // 
            // deleteBtn
            // 
            deleteBtn.Location = new Point(657, 224);
            deleteBtn.Name = "deleteBtn";
            deleteBtn.Size = new Size(108, 54);
            deleteBtn.TabIndex = 13;
            deleteBtn.Text = "清除";
            deleteBtn.UseVisualStyleBackColor = true;
            deleteBtn.Click += deleteBtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(542, 317);
            label1.Name = "label1";
            label1.Size = new Size(50, 23);
            label1.TabIndex = 14;
            label1.Text = "結果:";
            label1.Click += label1_Click;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(40, 169);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(161, 27);
            radioButton1.TabIndex = 15;
            radioButton1.TabStop = true;
            radioButton1.Text = "攝氏轉換為華氏";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(40, 213);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(161, 27);
            radioButton2.TabIndex = 16;
            radioButton2.TabStop = true;
            radioButton2.Text = "華氏轉換為攝氏";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 532);
            Controls.Add(radioButton2);
            Controls.Add(radioButton1);
            Controls.Add(label1);
            Controls.Add(deleteBtn);
            Controls.Add(ConvertBtn);
            Controls.Add(textBox1);
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
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

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
        private TextBox textBox1;
        private Button ConvertBtn;
        private Button deleteBtn;
        private Label label1;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
    }
}
