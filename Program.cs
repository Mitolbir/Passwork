string[] WordsFromConsole()
{
    Console.Write("Input size of massive: ");
    int size = Convert.ToInt32(Console.ReadLine());

    string[] array = new string[size];

    for(int i = 0; i < size; i++)
    {
        Console.Write($"Input {i+1} word: ");
        array[i] = Convert.ToString(Console.ReadLine());
    }
    return array;
}

void ShowArray(string[] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write(array[i] + " ");
    }
}

void MassiveLesser4Symbols(string[] array)
{
    string[] massive = new string[array.Length];

    for(int i = 0; i < array.GetLength(0); i++)
    {
        if(array[i].Length < 4)
        {
            massive[i] = array[i];
            Console.Write(massive[i] + " ");
        }
    }
}

string[] myArray = WordsFromConsole();
Console.Write("Main massive: ");
ShowArray(myArray);
Console.WriteLine();
Console.Write("Massive lesser than 4 symbols: ");
MassiveLesser4Symbols(myArray);
