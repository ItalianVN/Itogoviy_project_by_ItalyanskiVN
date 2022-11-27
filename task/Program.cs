// Формирование нового массива
string[] array1 = new string[5] {"12", "123", "helloWorld", "1234", "end"};


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
string [] NewArray(string[] array1)
{
    string[] array2 = new string[array1.Length];
    int count = 0;
    for (int i = 0; i < array1.Length; i++)
    {
    if(array1[i].Length <= 3)
        {
        array2[count] = array1[i];
        count++;
        }
    }
    return array2;
}

string[] array2 = NewArray(array1);
PrintArray(array2);