using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите массив строк, разделяя элементы запятыми:");
        string input = Console.ReadLine();
        string[] inputArray = input.Split(',');

        string[] filteredArray = FilterStrings(inputArray);

        Console.WriteLine("Результат:");
        foreach (string str in filteredArray)
        {
            Console.Write(str + " ");
        }

    }

    static string[] FilterStrings(string[] array)
    {
        int count = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i].Length <= 3)
            {
                count++;
            }
        }

        string[] result = new string[count];
        int index = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i].Length <= 3)
            {
                result[index] = array[i];
                index++;
            }
        }

        return result;
    }
}
