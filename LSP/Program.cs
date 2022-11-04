// See https://aka.ms/new-console-template for more information
using System.Collections;

Console.WriteLine("Hello, World!");

//Student x = new Read();
//x.Add(1);
//IMyCollection myCollection = new MyReadOnlyCollection();
//myCollection.Add(2);
 
Shape s= new Circle();
s.Width = 3;
s.Height = 4;
s.Base = 8;
s.Radius = 5;

s.CircleCalculater(s);







#region first Example
public class Student
{
    public virtual void ReadBook()
    {
        Console.WriteLine("Waseem .....");
    }
    public virtual void Add(int x)
    {
        Console.WriteLine(x + 1);
    }
}
public class Read : Student
{
    public override void ReadBook()
    {
        Console.WriteLine("Child Class .....");
    }

    public override void Add(int x)
    {
        throw new NotImplementedException();
    }

}

#endregion




#region Second Example

public interface IMyCollection
{
    void Add(int item);
    void Remove(int item);
    int Get(int idex);
}

public class MyReadOnlyCollection : IMyCollection
{


    public MyReadOnlyCollection()
    {

    }

    public void Add(int item)
    {
        throw new NotImplementedException();
    }

    public int Get(int index)
    {
        return 1;
    }

    public void Remove(int item)
    {
        throw new NotImplementedException();
    }
}

#endregion



#region Thired Example


public  class Shape
{
    public int Height { get; set; }
    public int Width { get; set; }
    public int Base { get; set; }
    public int Radius { get; set; }
    public const double Pai = 3.14;
    public void AreaCalculater(Shape s) { Console.WriteLine("the area equal is "); }

}


public class Rectangle : Shape
{
    public  void AreaCalculater(Shape s)
    {
        Console.WriteLine($"Area is : {s.Width * s.Height}");
    }
}

public class Triangle : Shape
{
    public  void TriangleCalculater(Shape s)
    {
        Console.WriteLine($"Area is : { .5 * s.Base * s.Height}");
    }
}

public class Square : Shape
{
    public  void SquareCalculater(Shape s)
    {
        Console.WriteLine($"Area is : {s.Width * s.Width}");
    }

}

public class Circle : Shape
{

    public  void CircleCalculater(Shape s)
    {

        Console.WriteLine($"Area is : { .5 * s.Radius * s.Radius * Pai}");
    }
}
#endregion
