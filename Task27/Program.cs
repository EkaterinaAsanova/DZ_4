//Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
//452 -> 11
//82 -> 10
//9012 -> 12

Console.WriteLine("Введите число ");
string text = Console.ReadLine();
int number = 0;
int sum = 0;
bool successA = int.TryParse(text, out number);
if (successA == true)
{
    number = int.Parse(text);
    while (number > 0)
        {
           sum = sum + number % 10;
           number = (number - number % 10) / 10;          
        }
        Console.WriteLine("Сумма цифр равна: " + sum);
}
else
  Console.WriteLine("Ошибка. Требуется ввод числа");
