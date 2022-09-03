// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

Console.WriteLine("Введите 5-изначное число: ");
string number = Console.ReadLine();

void CheckNum(string number)
{
    if (number[0]==number[4] && number[1]==number[3])
    {
        Console.WriteLine("Число - палиндром");
    }
    else 
    Console.WriteLine("Число - не палиндром");
}

if (number!.Length == 5)
{
    CheckNum(number);
}
else Console.WriteLine("это не 5-тизначное число!");