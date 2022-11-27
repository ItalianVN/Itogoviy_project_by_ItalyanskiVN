// Ввод исходного массива с клавиатуры
string[] GetArray(int m)
{
    string[] array = new string[m];
    for (int i = 0; i < array.Length; i++)
    {

        Console.Write($"Введите {i + 1} строку:  ");
        array[i] = Console.ReadLine();
    }
    return array;
}

// Метод вывода массива на экран
void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

// Метод выделения из массива строк, строки с размерностью менее 3х
string[] NewArray(string[] array1)
{
    string[] array2 = new string[array1.Length];
    int count = 0;
    for (int i = 0; i < array1.Length; i++)
    {
        if (array1[i].Length <= 3)
        {
            array2[count] = array1[i];
            count++;
        }
    }
    return array2;
}

string[] array1 = GetArray(5);
string[] array2 = NewArray(array1);
Console.Write($"Готовый массив, где длина строки менее или равна трем:");
Console.WriteLine();
PrintArray(array2);