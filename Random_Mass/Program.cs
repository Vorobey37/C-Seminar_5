/*
Задайте одномерный массив из 123 случайных чисел. 
Найдите количество элементов массива, значения которых лежат в отрезке [10,99].

*Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123*

[5, 18, 123, 6, 2] -> 1

[1, 2, 3, 6, 2]-> 0

[10, 11, 12, 13, 14]-> 5

*/
Console.Clear();
int [] GetMass(int n)
{
    int []mass = new int[n];
    for (int i=0; i<mass.Length; i++)
    {
        mass[i] = new Random().Next(0, 1001);
    }
    return mass;
}
int [] mass = GetMass(123);

int QElement(int []mass)
{
    int count = 0;
    foreach (int element in mass)
    {
        if (element>9 && element<100)
        {
            count++;
        }

    }
    return count;
}

Console.WriteLine($"[{String.Join(", ", mass)}] -> {QElement(mass)}");
