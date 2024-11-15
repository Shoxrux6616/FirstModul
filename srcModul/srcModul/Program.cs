namespace srcModul;

public class Program
{
    /////////////////////////////////////////////////
    //HOMEWORK
    /////////////////////////////////////////////////

    /*// 1
    static void Main(string[] args)
    {
        List<int> resault = new List<int>() { 13, 324, 24, 456, 2358, 686, 796 };

        var caunt = 0;
        foreach (int character in resault)
        {
            if (character > 99 && character < 1000)
            {
                caunt++;
            }
        }
        Console.WriteLine($"3 xonali sonlar {caunt} ta");
    }*/

    /*// 2
    static void Main(string[] args)
    {
        List<int> number = new List<int>() { 1, 2, 3, 4, 5, 7, 3, 46, 74, 3, 36, 65 };

        var caunt = 0;
        foreach (int character in number)
        {
            if (character % 2 == 0)
            {
                caunt++;
            }
        }
        Console.WriteLine($"Juft sonlar {caunt} ta");
    }*/

    /*// 3
    static void Main(string[] args)
    {
        List<int> number = new List<int>() { 1, 2, 3, 4, 5, 7, 3, 46, 74, 3, 36, 65 };

        var caunt = 0;
        foreach (int character in number)
        {
            if (character % 2 != 0)
            {
                caunt++;
            }
        }
        Console.WriteLine($"Toq sonlar {caunt} ta");
    }*/

    /*// 4
    static void Main(string[] args)
    {
        List<int> number = new List<int>() { 1, 21, 33, 4, 5, 7, 3, 46, 74, 3, 36, 65 };

        var caunt = 0;
        foreach (int character in number)
        {
            if (character % 3 == 0 || character % 7 == 0)
            {
                caunt++;
            }
        }
        Console.WriteLine($"3 va 7 ga karralilar {caunt} ta");
    }*/

    /*// 5
    static void Main(string[] args)
    {
        List<int> number = new List<int>() { 13, 32, 24, 456, 358, 66, 79 };

        var caunt = 0;
        var resault = 0;

        foreach (int character in number)
        {
            if (character > 9 && character < 100 && character % 2 != 0)
            {
                caunt++;
                resault += character;
            }

        }
        Console.WriteLine($"2 xonali toq sonlar {caunt} ta");
        Console.WriteLine($"Ularning yig'indisi {resault}");
    }*/

    /*// 6
    static void Main()
    {
        List<int> numbers = new List<int> { 10, 20, 30, 40, 50 };

        if (numbers.Count > 1)
        {
            var temp = numbers[0];  
            numbers[0] = numbers[numbers.Count - 1];  
            numbers[numbers.Count - 1] = temp;  
        }

        Console.WriteLine("Yangilangan list:");
        foreach (int character in numbers)
        {
            Console.Write($"{character} {" "}");
        }
    }*/

    /*// 7
    static void Main()
    {
        List<int> numbers = new List<int> { 10, 20, 30, 40, 50 };

        if (numbers.Count > 2)
        {
            var temp = numbers[0] + numbers[1] + numbers[2];
            Console.WriteLine($"Dastlabki 3 tasini yig'indisi {temp}");
        }
    }*/

    /*// 8
    static void Main()
    {
        List<int> numbers = new List<int> { 10, 20, 30, 40, 50 };

        if (numbers.Count > 2)
        {
            var temp = numbers[numbers.Count - 1] + numbers[numbers.Count - 2] + numbers[numbers.Count - 3];
            Console.WriteLine($"Dastlabki 3 tasini yig'indisi {temp}");
        }
    }*/

    /*// 9
    static void Main()
    {
        List<int> numbers = new List<int> { 10, 21, 32, 43, 54, 65, 76, 87, 99 };

        int oddCount = 0;
        int evenCount = 0;

        foreach (int character in numbers)
        {
            if (character % 2 != 0)
            {
                oddCount++;
            }
            else if (character % 2 == 0)
            {
                evenCount++;
            }
        }
        if (oddCount > evenCount)
        {
            Console.WriteLine("true");
        }
        else
        {
            Console.WriteLine("false");
        }
    }*/

    /*// 10
    static void Main()
    {
        List<int> numbers = new List<int> { 10, 21, 32, 43, 54, 65, 76, 87, 99 };

        for (int i = 0; i < numbers.Count; i++)
        {
            if (numbers[i] % 2 == 0)
            {
                numbers[i] *= 3;
            }
        }

        Console.WriteLine("Yangilangan list:");
        foreach (int character in numbers)
        {
            Console.Write($"{character} {" "}");
        }
    }*/

    /*// 11
    static void Main()
    {
        List<int> numbers = new List<int> { 10, 25, 55, 5, 20 };

        bool boolResault = true;

        foreach (int charcter in numbers)
        {
            if (charcter % 5 != 0)
            {
                boolResault = false;
                break;
            }
        }
        Console.WriteLine(boolResault);
    }*/

    /*// 12
    static void Main()
    {
        List<int> numbers = new List<int> { 16, 25, 53, 5, 20 };

        bool boolResault = false;

        for (int i = 0; i < numbers.Count; i++)
        {
            if (numbers[numbers.Count - 1] > 2)
            {
                if (numbers[0] > 9 && numbers[0] < 100 && numbers[1] > 9 && numbers[1] < 100 && numbers[2] > 9 && numbers[2] < 100)
                {
                    boolResault = true;
                    break;
                }
            }
        }

        Console.WriteLine(boolResault);
    }*/

    /*// 13
    static void Main()
    {
        List<int> numbers = new List<int> { 16, 24, 53, 5, 21 };

        bool boolResault = false;

        for (int i = 0; i < numbers.Count; i++)
        {
            if (numbers[numbers.Count - 1] > 3)
            {
                if (numbers[0] % 2 == 0 && numbers[1] % 2 == 0 && numbers[numbers.Count - 1] % 2 != 0 && numbers[numbers.Count - 2] % 2 != 0)
                {
                    boolResault = true;
                    break;
                }
            }
        }

        Console.WriteLine(boolResault);
    }*/


}
