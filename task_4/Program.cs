/*
Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22

*/

Console.Clear();
int maxNumber = 0;

for (int i = 0; i < 3; i++)
{
    Console.WriteLine($"Введите число {i+1}:");
    int inputValue = Convert.ToInt32( Console.ReadLine() );
    
    if (i == 0)
    {
        maxNumber = inputValue;
    }
    else if (inputValue > maxNumber)
    {
        maxNumber = inputValue;
    }    
}

Console.WriteLine($"Максимальным из введенный чисел является число {maxNumber}");





