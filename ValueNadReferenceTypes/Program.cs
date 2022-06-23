ValueTypeAssigning();
ReferenceTypeAssigning();

static void ValueTypeAssigning()
{
    Console.WriteLine("\nValueTypeAssigning\n");
    Point p1 = new(10, 10);
    //Создаем в стеке 2 разные структуры, копируя значения из p1 в p2
    Point p2 = p1;
    p1.Display();
    p2.Display();
    p1.X = 234;
    Console.WriteLine("\n=> Cnanged p1.X\n");
    p1.Display();
    p2.Display();
    Console.WriteLine("__________________________________________");
}

static void ReferenceTypeAssigning()
{
    Console.WriteLine("\nReferenceTypeAssigning\n");
    PointRef p1 = new(10, 10);
    //Создаем в стеке 2 разные структуры, копируя значения из p1 в p2
    PointRef p2 = p1;
    p1.Display();
    p2.Display();
    p1.X = 234;
    Console.WriteLine("\n=> Cnanged p1.X\n");
    p1.Display();
    p2.Display();
    Console.WriteLine("__________________________________________");
}
struct Point
{
    //Поля структуры
    public int X;
    public int Y;

    public Point(int XPos, int YPos)
    {
        X = XPos;
        Y = YPos;
    }

    public void Increment()
    {
        X++; Y++;
    }

    public void Decrement()
    {
        X--; Y--;
    }

    public void Display()
    {
        Console.WriteLine($"X={X}, Y={Y}");
    }
}

class PointRef
{
    //Поля структуры
    public int X;
    public int Y;

    public PointRef(int XPos, int YPos)
    {
        X = XPos;
        Y = YPos;
    }

    public void Increment()
    {
        X++; Y++;
    }

    public void Decrement()
    {
        X--; Y--;
    }

    public void Display() => Console.WriteLine($"X={X}, Y={Y}");

}