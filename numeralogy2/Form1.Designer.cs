namespace numeralogy2
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
            result = new Label();
            label3 = new Label();
            dateTimePicker1 = new DateTimePicker();
            button1 = new Button();
            label2 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // result
            // 
            result.AutoSize = true;
            result.Location = new Point(568, 179);
            result.Name = "result";
            result.Size = new Size(50, 23);
            result.TabIndex = 11;
            result.Text = "結果:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(594, 179);
            label3.Name = "label3";
            label3.Size = new Size(0, 23);
            label3.TabIndex = 10;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(168, 156);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(300, 30);
            dateTimePicker1.TabIndex = 9;
            // 
            // button1
            // 
            button1.Location = new Point(168, 269);
            button1.Name = "button1";
            button1.Size = new Size(197, 79);
            button1.TabIndex = 8;
            button1.Text = "分析結果";
            button1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(568, 103);
            label2.Name = "label2";
            label2.Size = new Size(64, 23);
            label2.TabIndex = 7;
            label2.Text = "關於你";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(168, 103);
            label1.Name = "label1";
            label1.Size = new Size(100, 23);
            label1.TabIndex = 6;
            label1.Text = "請選擇生日";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(result);
            Controls.Add(label3);
            Controls.Add(dateTimePicker1);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label result;
        private Label label3;
        private DateTimePicker dateTimePicker1;
        private Button button1;
        private Label label2;
        private Label label1;
    }
}
