string[] ArrayFilter(string[] array)
{
    // Определяем длину конечного массива
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            count++;
        }
    }
// Записываем информацию в новый массив
    string[] result = new string[count]; 
    int j = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            result[j] = array[i];
            j++;
        }
    }
    return result;
}

void PrintArray(string[] array) // вывод массива
{
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write("'" + array[i] + "', ");
    }
    System.Console.WriteLine("");
}

string[] array = { "1234", "1567", "-2", "computer science" };
PrintArray(ArrayFilter(array));