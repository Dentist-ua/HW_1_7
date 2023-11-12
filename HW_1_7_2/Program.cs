//Використовуючи Visual Studio, створіть проект за шаблоном Console Application.
//Напишіть програму, яка буде конвертувати валюти. Користувач вводить: суму грошей у певній валюті. курс конвертації в іншу валюту.
//Організуйте виведення результату операції конвертування валюти на екран.

class HW_1_7_2
{
    public static void Main()
    {
        Console.WriteLine("Enter the amount of money");
        var input1 = Console.ReadLine();
        double.TryParse(input1, out double money);

        Console.WriteLine("Enter the rate");
        var input2 = Console.ReadLine();
        double.TryParse(input2, out double rate);
    
        double convertAmount = ConvertCurrency(money, rate);
    
        Console.WriteLine($"Conversion result {convertAmount}");
        Console.ReadLine();
    }
    static double ConvertCurrency(double money, double rate)
    {
        return money * rate;
    }
    
}
 
