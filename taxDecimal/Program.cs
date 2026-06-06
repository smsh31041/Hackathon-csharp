namespace taxDecimal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal First = 540000 * 5m / 100m;
            decimal Second = First + ((1210000 - 540000) * 12m / 100m);
            decimal Third = Second + ((2420000 - 1210000) * 20m / 100m);
            decimal Forth = Third + ((4530000 - 2420000) * 30m / 100m);
            decimal Fifth = Forth + ((10310000 - 4530000) * 40m / 100m);

            Console.WriteLine("請輸入年收入: ");
            decimal input = decimal.Parse(Console.ReadLine());
            if (input <= 0)
            {
                Console.WriteLine("請輸入有效金額");
            }
            else if (input > 0 && input <= 540000)
            {
                Console.WriteLine(input * 5m / 100m);
            }
            else if (input >= 540001 && input <= 1210000)
            {
                Console.WriteLine(First + ((input - 540000) * 12m / 100m));
            }
            else if (input >= 1210001 && input <= 2420000)
            {
                Console.WriteLine(Second + ((input - 1210000) * 20m / 100m));
            }
            else if (input >= 2420001 && input <= 4530000)
            {
                Console.WriteLine(Third + ((input - 2420000) * 30m / 100m));
            }
            else if (input >= 4530001 && input <= 10310000)
            {
                Console.WriteLine(Forth + ((input - 4530000) * 40m / 100m));
            }
            else
            {
                Console.WriteLine(Fifth + ((input - 10310000) * 50m / 100m));
            }
        }


    }
}

