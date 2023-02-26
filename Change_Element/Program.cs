/*
Напишите программу замена элементов массива: 
положительные элементы замените на соответствующие отрицательные, и наоборот.

[-4, -8, 8, 2] -> [4, 8, -8, -2]
*/

Console.Clear();

int n = new Random().Next(-10, 11);
int [] GetMass (int n)
{
int [] mass = new int [n];
for (int i=0; i<n; i++)
{
    mass[i] = new Random().Next(-10, 11);
}
    return mass;
}
int []mass = GetMass (n);

int[] Change (int [] mass)
{
    int []change = new int [mass.Length];

    for (int i=0; i<mass.Length; i++)
    {
        change [i] = mass[i] * -1;
    }
    return change;
}
Console.WriteLine($"[{String.Join(", ", mass)}] -> [{String.Join(", ", Change(mass))}]");