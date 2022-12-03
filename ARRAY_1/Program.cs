// Сортировка массива

int [] arr = {1, 5, 4, 3, 2, 6, 7, 1, 1};

void PrintArray(int[]array) // метод Voin, в качестве аргумента массив

{
    int count = arr.Length; // получение кол-во элементов будут давать разное наименование
    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
} 

void SelectionSort(int[] array)  // метод упорядочивание массива, в качестве аргумента массив
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        int minPosition = i; // определяем позицию на которую смотрим
        
        for(int j = i + 1; j <array.Length; j++)
        {
            if (array[j] < array[minPosition]) minPosition = j; // нужно сохранить
        }

        int temporary = array[i]; // поменять значение
        array[i] = array[minPosition];  //обмен переменных местами
        array [minPosition] = temporary;
    }
} 
PrintArray(arr);
SelectionSort(arr);  // упорядочить массив
PrintArray(arr);