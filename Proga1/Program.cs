/*Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк,
 длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, 
 либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями,
 лучше обойтись исключительно массивами.
Примеры:
[“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
[“1234”, “1567”, “-2”, “computer science”] → [“-2”]
[“Russia”, “Denmark”, “Kazan”] → []*/

void ArraySecond(string[] array1, string[] array2)
{
    int y = 0;
    for (int i = 0; i < array1.Length; i++)
    {
        if (array1[i].Length <= 3)
        {
            array2[y] = array1[i];
            y++;
        }
    }
}
void PrintArray(string message, string[] array)
{
    Console.WriteLine(message);
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

string[] array1 = new string[7] { "Hello", "2", "1234", "world", ":-)", "03", "Russia" };
string[] array2 = new string[array1.Length];

ArraySecond(array1, array2);

PrintArray("Исходный массив : ", array1);
PrintArray("Получившийся массив :", array2);