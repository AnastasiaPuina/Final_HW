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
