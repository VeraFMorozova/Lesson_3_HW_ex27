// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int getUserData(string message)
{
    Console.ForegroundColor = ConsoleColor.DarkCyan; 
    Console.WriteLine(message);
    Console.ResetColor();
    int UserData = int.Parse(Console.ReadLine()!);
    return UserData;
}

int getNumberSum(int number)
{
    int NumberSum = 0;
    while (number > 0)
    {
        NumberSum = NumberSum + number % 10;
        number =  number / 10;
    }
    return NumberSum;
}
void showData(string messageStart, int data)
{
    Console.Write(messageStart);
    Console.ForegroundColor = ConsoleColor.DarkGreen;
    Console.Write(data);
    Console.ResetColor();
}
int number = getUserData ("Введите число");
int NumberSum = getNumberSum(number);
showData($"Сумма цифр в числе {number} = ", NumberSum);

