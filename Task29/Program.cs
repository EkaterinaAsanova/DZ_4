// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

Random Array = new Random(); 
int[] mas = new int [8];
    for (int i = 0; i < mas.Length; i++)
    {
    mas [i] = new Random().Next(-100, 101);
    }  
Console.WriteLine ("Сгенерировано 8 случайных чисел от -100 до 100:");
Console.WriteLine (string.Join(",", mas));