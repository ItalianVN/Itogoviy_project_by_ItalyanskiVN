// Формирование новых массивов (входного и выходного)
string[] array1 = new string[5] {"444", "23", "helloWorld", "dsa", "332"};
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

