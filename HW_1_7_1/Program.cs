//Використовуючи Visual Studio, створіть проект за шаблоном Console Application. Створіть чотири методи до виконання арифметичних операцій,
//з іменами: Add – додавання, Sub – віднімання, Mul – множення, Div – поділ. Кожен метод повинен приймати два цілих аргументи і виводити на екран результат
//виконання арифметичної операції відповідної імені методу. Метод поділу Div повинен виконувати перевірку спроби поділу на нуль.
//Потрібно надати користувачеві можливість вводити з клавіатури значення операндів та знак арифметичної операції для виконання обчислень.

Console.WriteLine("Enter the first number ");
var input1 = Console.ReadLine();
int.TryParse(input1, out int operand1);

Console.WriteLine("Enter the second number ");  
var input2 = Console.ReadLine();
int.TryParse(input2, out int operand2);

Console.WriteLine("Enter arithmetic operation '+' '-' '*' '/': ");
char sing = Convert.ToChar(Console.ReadLine());

int result;

switch (sing)
{
    case '+':
    {
        result = Add(operand1, operand2);
        Console.WriteLine($"Your answer {result}");
        break;
    }
    case '-':
    {
        result = Sub(operand1, operand2);
        Console.WriteLine($"Your answer {result}");
        break;
    }
    case '*':
    {
        result = Nul(operand1, operand2);
        Console.WriteLine($"Your answer {result}");
        break;
    }
    case '/':
    {
        if (operand2 != 0)
        {
            result = Div(operand1, operand2);
            Console.WriteLine($"Your answer {result}");
        }
        else
        {
            Console.WriteLine($"You cannot divide by {operand2}");
        }
        break;
    }
    default:
    {
        Console.WriteLine("You entered an incorrect arithmetic operation");
        break;
    }
}

//Console.WriteLine($"Your answer {result}");

static int Add(int operand1, int operand2)
{
    return operand1 + operand2;
}

static int Sub(int operand1, int operand2)
{
    return operand1 - operand2;
}

static int Nul(int operand1, int operand2)
{
    return operand1 * operand2;
}

static int Div(int operand1, int operand2)
{
    return operand1 / operand2;
}

