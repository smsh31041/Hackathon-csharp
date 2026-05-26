namespace temperature
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void NumButton_Click(object sender, EventArgs e)
        {
            Button clickedButton = (Button)sender; //抓到當前按鈕
            //打過小數點就不能再打
            if (clickedButton.Text == "." && textBox1.Text.Contains("."))
            {
                return;
            }
            textBox1.Text += clickedButton.Text; //+=表示文字串接
        }

        private void button12_Click(object sender, EventArgs e)
        {
            double inputTemp = double.Parse(textBox1.Text);
            double resultTemp;
            if (radioButton1.Checked) //true
            {
                resultTemp = (9.0 / 5.0) * inputTemp + 32;
                label1.Text = $"結果: {inputTemp}°C ={resultTemp}°F";
            }
            else if (radioButton2.Checked)
            {
                resultTemp = (inputTemp - 32) * (5.0 / 9.0);
                label1.Text = $"結果: {inputTemp}°F ={resultTemp}°C";
            }
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            label1.Text = "結果:";
            textBox1.Text = "";
            radioButton1.Checked = false;
            radioButton2.Checked = false;
        }
    }
}
