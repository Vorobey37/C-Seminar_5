/*
Задайте массив.Напишите программу, 
которая определяет, присутствует ли заданное число в массиве.

4; массив[6, 7, 19, 345, 3]->нет

*/
Console.Clear();
Console.WriteLine ("Введите элементы массива:");
string text  = Console.ReadLine();

int [] GetArrayFromString(string text)
{
    string []elements = text.Split(" ");
    int []mass = new int [elements.Length];
    for (int i=0; i<mass.Length; i++)
    mass[i] = int.Parse(elements[i]);
    return mass;
}

Console.WriteLine ("Введите число:");
int n = int.Parse(Console.ReadLine());

bool IsIt (int []mass, int n)
{
    foreach(var i in mass) //var подстраивает тип данных i по типу данных mass
    {
        if (mass[i] == n)
        return true;
    }
    return false;
}

Console.Write($"{n}, массив [{String.Join(", ", GetArrayFromString(text))}] -> ");

if (IsIt(GetArrayFromString(text), n))
Console.WriteLine("да");
else Console.WriteLine("нет");



