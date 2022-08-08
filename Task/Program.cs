/* Написать программу,которая из имеющегося массива строк сформирует массив из строк, 
длина которых меньше либо равна 3 символов.Первоначальный массив можно ввести с клавиатуры,  
либо задать на старте выполнения алгоритма. При решении использовать  массивы*/

void ShowArray(string[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {

        Console.Write(array[i]);
        if (i < array.Length - 1)
        {
            Console.Write(", ");
        }
    }
    Console.Write("]");
}

string[] ThreeSymbolsArray(string[] array)
{
    string[] arrayOfThreeSymbols = new string[0];
    for (int i = 0; i < array.Length; i++)
    {
        int length = array[i].Length;
        if (length < 4)
        {
            arrayOfThreeSymbols = arrayOfThreeSymbols.Concat(new string[] { array[i] }).ToArray();
        }
    }
    return arrayOfThreeSymbols;
}

Console.WriteLine("Введите количество элементов массива: ");
int numberOfElements = Convert.ToInt32(Console.ReadLine());
string[] arrayGiven = new string[numberOfElements];
for (int i = 0; i < numberOfElements; i++)
{
    arrayGiven[i] = string.Empty;
    Console.WriteLine($"Введите элемент массива с номером {i} и нажмите Enter: ");
    arrayGiven[i] = Console.ReadLine();
}

Console.WriteLine("Первоначальный массив, введенный пользователем: ");
ShowArray(arrayGiven);
Console.WriteLine();
Console.WriteLine("Массив, полученный в результате решения задачи: ");
string[] arrayNew = ThreeSymbolsArray(arrayGiven);
ShowArray(arrayNew);
