//Використовуючи Visual Studio, створіть проект за шаблоном Console Application.
//Створіть метод з ім'ям Calculate, який приймає як параметри три цілих аргументи і виводить на екран середнє арифметичне значень аргументів.

Console.WriteLine("Hello, World!");


Console.WriteLine("Enter the first number ");
var input1 = Console.ReadLine();
int.TryParse(input1, out int operand1);

Console.WriteLine("Enter the second number ");  
var input2 = Console.ReadLine();
int.TryParse(input2, out int operand2);

Console.WriteLine("Enter the third number ");  
var input3 = Console.ReadLine();
int.TryParse(input3, out int operand3);

double avarageValue = AvarageValue(operand1, operand2, operand3);
Console.WriteLine($"Avarage value is {avarageValue}");

static double AvarageValue(int operand1, int operand2, int operand3)
{
    return (operand1 + operand2 + operand3) / 3;
}
