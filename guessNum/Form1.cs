namespace guessNum
{
    public partial class Form1 : Form
    {
        string ans = "";

        public Form1()
        {
            InitializeComponent();
            textBox.Enabled = false;
            checkBtn.Enabled = false;
            retryBtn.Enabled = false;
            ansBtn.Enabled = false;
        }

        private void startBtn_Click(object sender, EventArgs e)
        {
            textBox.Clear();
            listBox.Items.Clear();
            textBox.Enabled = true;
            checkBtn.Enabled = true;
            retryBtn.Enabled = true;
            ansBtn.Enabled = true;

            Random random = new Random();
            ans = string.Join("", Enumerable.Range(0, 10).OrderBy(x => random.Next()).Take(4));

            textBox.Focus();
        }

        private void label2_Click(object sender, EventArgs e)
        { }

        private void ansBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"本局答案是:{ans}，請重新開始遊戲");
            textBox.Enabled = false;
            checkBtn.Enabled = false;
            retryBtn.Enabled = false;
            ansBtn.Enabled = false;
        }

        private void textBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBtn_Click(object sender, EventArgs e)
        {
            string input = textBox.Text.Trim();
            int a = 0;
            int b = 0;
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (input[i] == ans[j])
                    {
                        if (i == j)
                        {
                            a++;
                        }
                        else
                        {
                            b++;
                        }

                    }

                }

            }
            ;
            string reback = $"{a}A{b}B : {input}";

            if (input == ans)
            {
                MessageBox.Show("4A~恭喜過關~請按開始按鈕重新開始");
            }
            listBox.Items.Add(reback);
            textBox.Clear();
            textBox.Focus();
        }

        private void retryBtn_Click(object sender, EventArgs e)
        {
            textBox.Clear();
            listBox.Items.Clear();

            textBox.Enabled = false;
            checkBtn.Enabled = false;
            retryBtn.Enabled = false;
            ansBtn.Enabled = false;
        }
    }
}
