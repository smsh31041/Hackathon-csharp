namespace one.replace
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("請輸入一個至少大於90的整數");
            int input = int.Parse(Console.ReadLine());
            if (input <= 90)
            {
                Console.WriteLine("數字範圍錯誤");
            }
            else
            {
                for (int i = 1; i < input; i++)
                {
                    if (i % 3 == 0 && i % 5 == 0)
                    {
                        Console.WriteLine("Dann");
                    }
                    else if (i % 3 == 0)
                    {
                        Console.WriteLine("Build");
                    }
                    else if (i % 5 == 0)
                    {
                        Console.WriteLine("School");
                    }
                    else
                    {
                        Console.WriteLine($"{i}");
                    }
                }
            }
            
            
           
        }
    }
}
