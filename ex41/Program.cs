// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3


Console.WriteLine("Программа считает, сколько чисел больше 0 ввёл пользователь!");
int M = int.Parse(Console.ReadLine()!);
Console.WriteLine($"Ваш размер массива {M}");
int[] array = new int [M];
GetArray(array);
Console.WriteLine("Результат:");
NumbersGreaterThanZero(array);
Console.WriteLine(NumbersGreaterThanZero(array));


int[] GetArray(int[] array)                // Функция заполнения массива в случайном порядке 
{
 for (int i = 0; i < array.Length; i++) 
 { 
 array[i] = int.Parse(Console.ReadLine()!);
 }

 return array;
}

int NumbersGreaterThanZero(int[] array)    // Функция считает количество чисел в массиве больше 0
{
    int count = 0;
 for (int i = 0; i < array.Length; i++) 

    if (array[i] > 0)
    {
        count++;
    }
    
 return count;
}