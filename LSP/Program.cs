// See https://aka.ms/new-console-template for more information
using System.Collections;

Console.WriteLine("Hello, World!");

Student x = new Student();
x.Add(1);



public class Student
{
    public virtual  void ReadBook()
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

