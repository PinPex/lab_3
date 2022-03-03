public class Program
{
    public static void Main()
    {
        RomanNumber num_1 = new RomanNumber(1500);
        RomanNumber num_2 = new RomanNumber(2100);
        RomanNumber num_3 = new RomanNumber(100);
        RomanNumber num_4 = new RomanNumber(5);
        RomanNumber num_5 = new RomanNumber(2000);
        RomanNumber num_6 = new RomanNumber(299);
        Console.WriteLine("Number №1 = 1500 = " + num_1.ToString());
        Console.WriteLine("Number №2 = 2100 = " + num_2.ToString());
        Console.WriteLine("Number №3 = 100 = " + num_3.ToString());
        Console.WriteLine("Number №4 = 5 = " + num_4.ToString());
        Console.WriteLine("Number №5 = 2000 = " + num_5.ToString());
        Console.WriteLine("Number №6 = 299 = " + num_6.ToString());
        Console.WriteLine("Num№1 + Num№1 + Num№4 = " + (num_1 + num_1 + num_4).ToString());
        //Console.WriteLine("(num_5 + num_5).ToString()); /*exception*/
        Console.WriteLine("Num№1 - Num№4 * Num№6 = " + (num_1 - num_4 * num_6).ToString());
        //Console.WriteLine("(num_5 - num_5).ToString()); /*exception*/
        Console.WriteLine("Num№3 * Num№4 = " + (num_3 * num_4).ToString());
        //Console.WriteLine("(num_5 * num_5).ToString()); /*exception*/
        Console.WriteLine("Num№3 / Num№4 = " + (num_3 / num_4).ToString());
        Console.WriteLine("Num№3 / Num№3 = " + (num_3 / num_3).ToString());

        Console.WriteLine("\nSort");
        RomanNumber[] numbers = { num_1, num_2, num_3, num_4, num_6 };
        Array.Sort(numbers);
        for (int i = 0; i < 5; ++i)
        {
            Console.WriteLine(numbers[i].ToString());
        }
        Console.WriteLine("\nCopy");
        var f = (RomanNumber)num_1.Clone();
        Console.WriteLine(f.ToString());
    }
}