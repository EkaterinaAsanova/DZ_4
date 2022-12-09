//Задача 25: Напишите цикл, который принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

using System.Numerics;
Console.WriteLine("Введите число А");
string textA = Console.ReadLine();
Console.WriteLine("Введите число В");
string textB = Console.ReadLine();
BigInteger number1 = 0;
BigInteger number2 = 0;
bool successA = BigInteger.TryParse(textA, out number1);
bool successB = BigInteger.TryParse(textB, out number2);
if ((successA == true) && (successB == true))
{
number1 = BigInteger.Parse(textA);
number2 = BigInteger.Parse(textB);
    if (number2 >= 0)
    {
       BigInteger Degree(BigInteger number1, BigInteger number2) 
       {   
        BigInteger i = 0; BigInteger result = 1;
        while (i < number2) { result = result * number1; i++; } 
        return result;
       }  
       Console.WriteLine(Degree(number1, number2));
    }
    else
    Console.WriteLine("Ошибка. Введите натуральное число B");
}
else
Console.WriteLine("Ошибка. Требуется ввод числа");