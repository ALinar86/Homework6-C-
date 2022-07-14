int[] CreateArray()
{
    int[] array = new int[5];

    for(int i = 0; i < 5; i++)
    {
        Console.WriteLine($"Input number {i+1}: ");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
    Console.WriteLine();
    return array;
}

void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");

    Console.WriteLine();
    Console.WriteLine();
}

int PosNum(int[] array)
{
    int count = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] > 0) count++;
    }
    return count;
}

int[] array = CreateArray();
ShowArray(array);
Console.WriteLine("Number of positive numbers is: " + PosNum(array));