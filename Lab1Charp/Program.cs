// See https://aka.ms/new-console-template for more information

    static void task1()
    {
        Console.WriteLine("Task 1 (Radius of a circle circumscribed around an equilateral triangle)");
        Console.Write("A= ");
        string? str = Console.ReadLine();
        if (str != null && float.TryParse(str, out float sideA))
        {
            double circRadius = (sideA * Math.Sqrt(3)) / 3;
            Console.WriteLine("Radius=" + circRadius);
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a valid number for side A.");
        }
    }

    static void task2()
    {
        Console.WriteLine("Task 2 (Proof of rectangular triangle A^2 + B^2 = C^2)");
        Console.Write("A= ");
        string? strA = Console.ReadLine();
        Console.Write("B= ");
        string? strB = Console.ReadLine();
        Console.Write("C= ");
        string? strC = Console.ReadLine();

        if (strA != null && strB != null && strC != null &&
            float.TryParse(strA, out float sideA) &&
            float.TryParse(strB, out float sideB) &&
            float.TryParse(strC, out float sideC))
        {
            if (sideA * sideA + sideB * sideB == sideC * sideC)
                Console.WriteLine("Triangle is rectangular");
            else
                Console.WriteLine("Triangle is not rectangular");
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter valid numbers for sides A, B, and C.");
        }
    }
    static void task3(){
        string? str1, str2;
        Console.Write("X= ");
        str1 = Console.ReadLine();
        Console.Write("Y= ");
        str2 = Console.ReadLine();
        if (str1 != null && str2 != null &&
            float.TryParse(str1, out float x) &&
            float.TryParse(str2, out float y))
        {
        if(x <= 5 && x >= 0 && y <= 10 && y >= 0){
        if(x == 5 || y == 10 ||  x == 0 || y == 0) Console.WriteLine("On the edge");
        else Console.WriteLine("Yes");
        }else Console.WriteLine("No");
        }
    }
static void task4()
{
    Console.WriteLine("Виберіть номер телевізійного каналу (від 1 до 3):");
    Console.WriteLine("1. Перший канал");
    Console.WriteLine("2. Другий канал");
    Console.WriteLine("3. Третій канал");

    Console.Write("Введіть номер каналу: ");
    string userInput = Console.ReadLine();

    if (int.TryParse(userInput, out int channel) && channel >= 1 && channel <= 3)
    {
        Console.WriteLine($"Найпопулярніші програми для каналу {channel}:");

        switch (channel)
        {
            case 1:
                Console.WriteLine("1. Новини");
                Console.WriteLine("2. Серіали");
                Console.WriteLine("3. Розважальні шоу");
                break;
            case 2:
                Console.WriteLine("1. Спортивні передачі");
                Console.WriteLine("2. Документальні фільми");
                Console.WriteLine("3. Кулінарні програми");
                break;
            case 3:
                Console.WriteLine("1. Реаліті-шоу");
                Console.WriteLine("2. Музичні вистави");
                Console.WriteLine("3. Комедійні серіали");
                break;
        }
    }
    else
    {
        Console.WriteLine("Неправильне введення. Будь ласка, введіть номер каналу від 1 до 3.");
    }
}

    static void task5() {
        string? str1, str2;
        Console.Write("A= ");
        str1 = Console.ReadLine();
        Console.Write("B= ");
        str2 = Console.ReadLine();
        if (str1 != null && str2 != null &&
            int.TryParse(str1, out int first) &&
            int.TryParse(str2, out int second))
        {
            int sum = first + second;
            int sumToCube = sum * sum * sum ;
            Console.WriteLine("( A + B )^3 = " + sumToCube);
        }
    }
    static void task6() {
    Console.Write("n= ");
    string? str1 = Console.ReadLine();
    Console.Write("m= ");
    string? str2 = Console.ReadLine();

    if (str1 != null && str2 != null &&
        int.TryParse(str1, out int n) &&
        int.TryParse(str2, out int m))
    {
        float nF = (float)n;
        float mF = (float)m;

        float numerator = (nF + 1) / (nF * nF + mF * mF + 1);
        float denominator = 1 / ((nF + 1) * (mF + 1));

        float res = numerator - denominator;

        Console.WriteLine("Result = " + res);
    }
    else 
    {
        Console.WriteLine("Invalid input. Please enter valid integers for n and m.");
    }
}


//task1();
//task2();
//task3();
//task4();
//task5();
//task6();
// continue ...
