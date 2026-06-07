using System;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace numeralogy2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // 當使用者按下「分析結果」按鈕
        private void btnAnalyze_Click(object sender, EventArgs e)
        {
            // 獲取使用者輸入的出生年月日
            DateTime birthday = dateTimePicker1.Value;

            // 【要求 1】：根據邊界日期回傳對應的星座名稱
            string constellation = GetConstellation(birthday);

            // 【要求 2】：計算生命靈數
            int lifeNumber = GetLifeNumber(birthday);

            // 【要求 3 & 4】：以星座搜尋資料庫並進行生命靈數配對，撈出整行文字
            string matchedLine = GetMatchedLine(constellation, lifeNumber);

            // 【要求 5 & 最後輸出】：直接列印出文字 "你的" + 配對上的該行文字
            // 並依照圖檔格式分兩行顯示在 Label 上
            result.Text = $"你的星座是 {constellation}\n" +
                             $"你的{matchedLine}";
        }

        /// <summary>
        /// 【要求 1】根據邊界日期回傳對應的星座名稱
        /// </summary>
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

        /// <summary>
        /// 【要求 2】計算生命靈數（使用迴圈相加至個位數）
        /// </summary>
        private int GetLifeNumber(DateTime date)
        {
            string dateStr = date.ToString("yyyyMMdd");
            int sum = 0;

            // 第一次拆解相加
            foreach (char c in dateStr)
            {
                sum += int.Parse(c.ToString());
            }

            // 用迴圈檢查：如果加總大於 9（兩位數以上），就繼續拆開相加
            while (sum > 9)
            {
                int tempSum = 0;
                foreach (char c in sum.ToString())
                {
                    tempSum += int.Parse(c.ToString());
                }
                sum = tempSum;
            }

            return sum;
        }

        /// <summary>
        /// 【要求 3 & 4】核心文字配對邏輯
        /// </summary>
        private string GetMatchedLine(string constellation, int lifeNumber)
        {
            string fileName = "生命靈數.txt";

            if (!File.Exists(fileName))
            {
                return "錯誤：找不到生命靈數.txt 檔案。";
            }

            try
            {
                // 先用 File.ReadAllText 引入全部資料
                string allText = File.ReadAllText(fileName, Encoding.UTF8);

                // 將內容按行切開，方便一行一行處理
                string[] lines = allText.Split(new string[] { "\r\n", "\n" }, StringSplitOptions.None);

                bool startMatching = false;

                foreach (string line in lines)
                {
                    string trimmedLine = line.Trim();

                    // 【要求 3】：找尋完全對應的文字，此文字必須被包含在 "【】" 中
                    // 例如：檢查這一行是否同時包含 "【"、"】" 以及 "獅子座"
                    if (trimmedLine.Contains("【") && trimmedLine.Contains("】") && trimmedLine.Contains(constellation))
                    {
                        // 找到了！開啟開關，規定「從此行的下一行開始進行生命靈數配對」
                        startMatching = true;
                        continue; // 跳過標題這行，直接進入下一行
                    }

                    // 如果開關已經打開，代表現在位於目標星座的下方區塊
                    if (startMatching)
                    {
                        // 如果遇到了下一個星座的標題（發現別的 【】），代表這個星座看完了，直接停掉，防錯安全機制
                        if (trimmedLine.Contains("【") && trimmedLine.Contains("】"))
                        {
                            break;
                        }

                        // 【要求 4】：進行生命靈數配對（檢查是否包含該靈數關鍵字）
                        if (trimmedLine.Contains($"生命靈數{lifeNumber}") || trimmedLine.Contains($"生命靈數 {lifeNumber}"))
                        {
                            return trimmedLine; // 回傳整行文字（例如："生命靈數 1：你是Leo..."）
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                return "讀取資料庫失敗: " + ex.Message;
            }

            return $"找不到符合 {constellation} 生物靈數 {lifeNumber} 的敘述。";
        }
    }
}
