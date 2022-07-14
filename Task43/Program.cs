void InPo()
{
    Console.WriteLine("Input k1: ");
    double k1 = Convert.ToDouble(Console.ReadLine());

    Console.WriteLine("Input b1: ");
    double b1 = Convert.ToDouble(Console.ReadLine());

    Console.WriteLine("Input k2: ");
    double k2 = Convert.ToDouble(Console.ReadLine());

    Console.WriteLine("Input b2: ");
    double b2 = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine();

    string text = "No solitions";
    double x = 0;
    double y = 0;
    double[] array = new double[2];
    if(k1 != k2)
    {
        x = (b2 - b1) / (k1 - k2);
        y = k1 * x + b1;
        array[0] = x;
        array[1] = y;
        Console.WriteLine($"Intersection point is: ({array[0]}; {array[1]})");
    }
    else Console.WriteLine(text);
}

InPo();