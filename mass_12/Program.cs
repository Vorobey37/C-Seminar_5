/*
//Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. 
//Найдите сумму отрицательных и положительных элементов массива.
*/
Console.Clear();

int [] GetMass(int size, int minvalue, int maxvalue)
{
    int []mass = new int [size];
    for (int i=0; i<size; i++)
    {
        mass[i] = new Random().Next(minvalue, maxvalue+1);
    }
    return mass;
}
//int [] mass = GetMass(12, -9, 9);

void PrintMass (int []mass)
{
    for (int i=0; i < mass.Length; i++)
    {
        Console.Write($"{mass[i]} ");
    }
}
int []mass = GetMass(12, -9, 9);
PrintMass(mass);
Console.WriteLine();

int [] SumMass (int []array)
{
    int []mass = new int [2];

    foreach (int i in array)
    {
        mass[0] += i > 0 ? 0:i;
        mass[1] += i<0 ? 0:i;
    }
    return mass;
}

PrintMass(SumMass(mass));