// Задача № 41.
// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// Пример: 0, 7, 8, -2, -2 -> 2
//     -1, -7, 567, 89, 223-> 3

int[] FillArrayKey()
{
    Console.Write("Введите количество чисел, которое вы планируете ввести: ");
    int M = Convert.ToInt32(Console.ReadLine());
    int[] Arr = new int[M];
    for (int i = 0; i < Arr.Length; i++)
        {
            Console.Write("Введите число {0}: ", i + 1);
            Arr[i] = Convert.ToInt32(Console.ReadLine());
        }
    return Arr;
}

// Для вывода массива через функцию
// void PrintArray(int[] array)
// {
//     Console.WriteLine(string.Join(", ", array));
// }

int CountNumberUpZero(int[] array)
{
    int countUpZero = 0;
    for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > 0)
            countUpZero = countUpZero + 1; 
        }
    return countUpZero;
}

int[] myArray = FillArrayKey();

// PrintArray(myArray); 
// Console.WriteLine($"Количество введенных пользователем чисел больше 0: {CountNumberUpZero(myArray)}."); 

Console.WriteLine($"{String.Join(", ",myArray)} -> {CountNumberUpZero(myArray)}.");  