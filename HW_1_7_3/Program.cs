//Використовуючи Visual Studio, створіть проект за шаблоном Console Application.
//Напишіть метод, який визначатиме:
//1) чи є введене число позитивним чи негативним.
//2) Чи є воно простим (використовуйте техніку перебору значень). (Просте число - це натуральне число,
//яке ділиться на 1 і саме на себе. Щоб визначити просте число чи ні,слід знайти всі цілі дільники.
//Якщо дільників більше 2-х, значить воно не просте.)
//3) Чи ділиться на 2 , 5, 3, 6, 9 без залишку.
//-------------------------------------------------------------------------------------------------------


internal class HW_1_7_3
{
    static string DefinitionSign(int number)
    {
        if (number > 0)
        {
            return "The number is positiv";
        }
        else if (number == 0)
        {
            return "The number is neither positive nor negative";
        }
        else
        {
            return "The number is negative";
        }
    }

    static string PrimeNumber(int number)
    {
        if (number <= 1)
        {
            return "The number is not prime";
        }

        for (int i = 2; i <= Math.Sqrt(number); i++)
        {
            if (number % i == 0)
            {
                return "The number is not prime"; 
            }
        }
        
        return "The number is  prime";

    }

    static string Division(int number)
    {
        if (number % 2 == 0 && number % 5 == 0 && number % 3 == 0 && number % 6 == 0 && number % 9 == 0)
        {
            return "Shares without a remainder";
        }
        
        return "Shares with a remainder";
    }
    
    
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter number ");
        var input1 = Console.ReadLine();
        int.TryParse(input1, out int number);
        
        string definiti = DefinitionSign(number);
        Console.WriteLine(definiti);
        
        string prime = PrimeNumber(number);
        Console.WriteLine(prime);
        
        string division = Division(number);
        Console.WriteLine(division);
    }
}