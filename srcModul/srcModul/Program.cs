namespace srcModul;

public class Program
{
    static void Main(string[] args)
    {
        Console.Write(" son : ");
        var number = Convert.ToInt32(Console.ReadLine());

        var ones = number % 10;
        var tens = number / 10 % 10;
        var hundreds = number / 100 % 10;
        var thundreds = number / 1000;

        var resault = 0;
        if (number > 999 && number < 10000)
        {
            Console.WriteLine(ones + tens + hundreds + thundreds);
        }
        else
        {
            Console.WriteLine("$ honali son kiriting?");
        }
    }
}
