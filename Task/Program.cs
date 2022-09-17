/* Написать программу, которая из имеющегося массива cтрок формирует массив строк, длина которых
меньше либо равна 3 символа */

string[] GetArray(int length)
{
    string[] array = new string[length];
    Console.WriteLine($"Введите {length} строки");
    for(int i = 0; i < length; i++)
    {
        array[i] = Console.ReadLine();
    } 
    return array;
}

string[] SortArray(string[] array)
{
    int count = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i].Length <= 3) count++; 
    }

    string[] result = new string[count];
    count = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i].Length <= 3) 
        {
            result[count] = array[i];
            count++;
        } 
    }
    return result;
}

void PrintArray(string[] arr)
{
    for(int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write(arr[i] + ", ");
    }
    Console.WriteLine($"{arr[arr.Length - 1]}.");
}

Console.Write("Длина массива = ");
int size = int.Parse(Console.ReadLine());
string[] myArray = GetArray(size);
string[] newArray = SortArray(myArray);
Console.WriteLine();
Console.WriteLine("Итоговый маасив:");
PrintArray(newArray);


