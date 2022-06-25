ValueTypeAssigning();
ReferenceTypeAssigning();
ValueTypeContainingRefType();
#region 
Console.WriteLine("***** Passing Person object by value *****");
Person fred = new Person("Fred", 22);

Console.WriteLine("\nBefore by value call, Person is:");
fred.Display();
//Console.WriteLine("\nSendAPersonByValue()");
//SendAPersonByValue(fred);
Console.WriteLine("\nSendAPersonByReference()");
SendAPersonByReference(ref fred);
Console.WriteLine("\nAfter by value call, Person is:");
fred.Display();
Console.ReadLine();


#endregion

static void SendAPersonByReference(ref Person p)
{
    //Изменить значение возраста в p
    p.personAge = 555;
    //Увидит ли вызывающий код это выражение?
    p = new Person("Nikki", 99);
}

static void SendAPersonByValue(Person p)
{
    //Изменить значение возраста в p
    p.personAge = 99;
    //Увидит ли вызывающий код это выражение?
    p = new Person("Andrei", 99);
}

static void ValueTypeContainingRefType()
{
    //Создать первую переменную Rectangle
    Console.WriteLine("=> Creating r1");
    Rectangle r1 = new Rectangle("First Rect", 10, 10, 60, 56);
    r1.Display();
    //присвоить новой перменной Rectangle перменную r1
    Console.WriteLine("=> Assigning r2 to r1");
    Rectangle r2 = r1;
    //Изменить некоторые значения в r2
    Console.WriteLine("=. Changing values of r2");
    r2.RectInfo.InfoString = "This is new info!";
    r2.RectLeft = 55555;
    r1.Display();
    r2.Display();

}

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
class ShapeInfo
{
    public string InfoString;
    public ShapeInfo(string info)
    {
        InfoString = info;
    }
}

class Person
{
    public string personName;
    public int personAge;
    //Конструкторы
    public Person(
        string name,
        int age)
    {
        personAge = age;
        personName = name;
    }
    public void Display() => Console.WriteLine($"Name:{personName}, Age:{personAge}");

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
struct Rectangle
{
    //структура Rectangle содержит член ссылочного типа
    public ShapeInfo RectInfo;
    public int RectTop, RectLeft, RectBottom, RectRight;
    public Rectangle(string info, int top, int left, int bottom, int right)
    {
        RectInfo = new ShapeInfo(info);
        RectTop = top; RectLeft = left;
        RectBottom = bottom; RectRight = right;
    }
    public void Display()
    {
        Console.WriteLine($"String = {RectInfo.InfoString}, Top = {RectTop}," +
            $" Bottom={RectBottom}, Left = {RectLeft}, Right = {RectRight}");
    }
}


