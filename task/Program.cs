// Формирование новых массивов (входного и выходного)
string[] array1 = new string[5] {"12", "123", "helloWorld", "1234", "end"};
string[] array2 = new string[array1.Length];

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
void NewArray(string[] array1, string[] array2)
{
    int count = 0;
    for (int i = 0; i < array1.Length; i++)
    {
    if(array1[i].Length <= 3)
        {
        array2[count] = array1[i];
        count++;
        }
    }
}