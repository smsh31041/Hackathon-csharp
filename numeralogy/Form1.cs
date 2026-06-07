namespace numeralogy
{
    public partial class resultBtn : Form
    {
        public resultBtn()
        {
            InitializeComponent();
        }

        private void resultBtn_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            RunLifeNumberAnalysis(dateTimePicker1.Value, result);
        }


        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void result_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// 核心啟動大腦：接收日期與 Label 參數，開始進行分析
        /// </summary>
        private void RunLifeNumberAnalysis(DateTime inputDate, Label resultLabel)
        {
            // 計算生命靈數
            int lifeNumber = GetLifeNumber(inputDate);

            // 判斷星座
            string constellation = GetConstellation(inputDate);

            // 從 txt 檔案中撈取敘述
            string description = GetDescriptionFromFile(constellation, lifeNumber);


            resultLabel.Text = $"【分析結果】\n\n" +
                               $"星座：{constellation}\n" +
                               $"生命靈數：{lifeNumber} 號\n\n" +
                               $"特質敘述：\n{description}";
        }

        private int GetLifeNumber(DateTime date)
        {
            string dateStr = date.ToString("yyyyMMdd");
            int sum = CalculateStringSum(dateStr);
            while (sum > 9)
            {
                sum = CalculateStringSum(sum.ToString());
            }
            return sum;
        }

        private int CalculateStringSum(string str)
        {
            int total = 0;
            foreach (char c in str)
            {
                if (char.IsDigit(c)) total += int.Parse(c.ToString());
            }
            return total;
        }

        private string GetConstellation(DateTime date)
        {
            int month = date.Month;
            int day = date.Day;
            if ((month == 3 && day >= 21) || (month == 4 && day <= 19)) return "牧羊座";
            if ((month == 4 && day >= 20) || (month == 5 && day <= 20)) return "金牛座";
            if ((month == 5 && day >= 21) || (month == 6 && day <= 21)) return "雙子座";
            if ((month == 6 && day >= 22) || (month == 7 && day <= 22)) return "巨蟹座";
            if ((month == 7 && day >= 23) || (month == 8 && day <= 22)) return "獅子座";
            if ((month == 8 && day >= 23) || (month == 9 && day <= 22)) return "處女座";
            if ((month == 9 && day >= 23) || (month == 10 && day <= 23)) return "天秤座";
            if ((month == 10 && day >= 24) || (month == 11 && day <= 22)) return "天蠍座";
            if ((month == 11 && day >= 23) || (month == 12 && day <= 21)) return "射手座";
            if ((month == 12 && day >= 22) || (month == 1 && day <= 19)) return "摩羯座";
            if ((month == 1 && day >= 20) || (month == 2 && day <= 18)) return "水瓶座";
            return "雙魚座";
        }

        private string GetDescriptionFromFile(string constellation, int lifeNumber)
        {
            string fileName = "生命靈數.txt";
            if (!File.Exists(fileName)) return "找不到生命靈數資料庫檔案(生命靈數.txt)！";

            try
            {
                string allText = File.ReadAllText(fileName, System.Text.Encoding.UTF8);
                string[] blocks = allText.Split(new char[] { '【' }, StringSplitOptions.RemoveEmptyEntries);

                foreach (string block in blocks)
                {
                    if (block.Contains(constellation))
                    {
                        string[] lines = block.Split(new string[] { "\r\n", "\n" }, StringSplitOptions.RemoveEmptyEntries);
                        foreach (string line in lines)
                        {
                            if (line.Contains($"生命靈數{lifeNumber}"))
                            {
                                string[] parts = line.Split(new char[] { ':' }, 2);
                                return parts.Length > 1 ? parts[1].Trim() : line.Trim();
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                return "讀取資料庫失敗: " + ex.Message;
            }

            return $"找不到符合 {constellation} 生命靈數 {lifeNumber} 的敘述。";
        }
    }
}
        
    

