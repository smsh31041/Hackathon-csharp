namespace guessNum
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
            startBtn = new Button();
            ansBtn = new Button();
            label1 = new Label();
            textBox = new TextBox();
            checkBtn = new Button();
            retryBtn = new Button();
            label2 = new Label();
            listBox = new ListBox();
            SuspendLayout();
            // 
            // startBtn
            // 
            startBtn.Location = new Point(103, 54);
            startBtn.Name = "startBtn";
            startBtn.Size = new Size(140, 67);
            startBtn.TabIndex = 0;
            startBtn.Text = "開始遊戲";
            startBtn.UseVisualStyleBackColor = true;
            startBtn.Click += startBtn_Click;
            // 
            // ansBtn
            // 
            ansBtn.Location = new Point(103, 150);
            ansBtn.Name = "ansBtn";
            ansBtn.Size = new Size(140, 67);
            ansBtn.TabIndex = 1;
            ansBtn.Text = "看答案";
            ansBtn.UseVisualStyleBackColor = true;
            ansBtn.Click += ansBtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(103, 283);
            label1.Name = "label1";
            label1.Size = new Size(46, 23);
            label1.TabIndex = 2;
            label1.Text = "輸入";
            // 
            // textBox
            // 
            textBox.Location = new Point(103, 318);
            textBox.Name = "textBox";
            textBox.Size = new Size(200, 30);
            textBox.TabIndex = 3;
            textBox.TextChanged += textBox_TextChanged;
            // 
            // checkBtn
            // 
            checkBtn.Location = new Point(103, 398);
            checkBtn.Name = "checkBtn";
            checkBtn.Size = new Size(97, 58);
            checkBtn.TabIndex = 4;
            checkBtn.Text = "檢查答案";
            checkBtn.UseVisualStyleBackColor = true;
            checkBtn.Click += checkBtn_Click;
            // 
            // retryBtn
            // 
            retryBtn.Location = new Point(206, 398);
            retryBtn.Name = "retryBtn";
            retryBtn.Size = new Size(97, 58);
            retryBtn.TabIndex = 5;
            retryBtn.Text = "放棄重來";
            retryBtn.UseVisualStyleBackColor = true;
            retryBtn.Click += retryBtn_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(502, 54);
            label2.Name = "label2";
            label2.Size = new Size(82, 23);
            label2.TabIndex = 6;
            label2.Text = "遊戲歷程";
            label2.Click += label2_Click;
            // 
            // listBox
            // 
            listBox.FormattingEnabled = true;
            listBox.Location = new Point(502, 94);
            listBox.Name = "listBox";
            listBox.Size = new Size(245, 372);
            listBox.TabIndex = 7;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(881, 533);
            Controls.Add(listBox);
            Controls.Add(label2);
            Controls.Add(retryBtn);
            Controls.Add(checkBtn);
            Controls.Add(textBox);
            Controls.Add(label1);
            Controls.Add(ansBtn);
            Controls.Add(startBtn);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button startBtn;
        private Button ansBtn;
        private Label label1;
        private TextBox textBox;
        private Button checkBtn;
        private Button retryBtn;
        private Label label2;
        private ListBox listBox;
    }
}
