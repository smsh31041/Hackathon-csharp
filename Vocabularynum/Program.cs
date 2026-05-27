namespace Vocabularynum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("請輸入一段有意義的英文字句");
            string input = Console.ReadLine();
            string[] split = input.ToLower().Split(' ', StringSplitOptions.RemoveEmptyEntries);//空白去掉

            Dictionary<string, int> words = new Dictionary<string, int>();
            foreach (string word in split)
            {
                if (words.ContainsKey(word))
                {
                    words[word]++;
                }
                else
                {
                    words[word] = 1;
                }
            }
            //逐一取出字典內的值
            //var實際的型別是KeyValuePair<string, int>
            foreach (var result in words)
            {
                Console.WriteLine($"{result.Key}: {result.Value}");
            }

        }
    }
}
