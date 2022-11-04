// See https://aka.ms/new-console-template for more information
using System.Collections;

Console.WriteLine("Hello, World!");

//Student x = new Read();
//x.Add(1);
//IMyCollection myCollection = new MyReadOnlyCollection();
//myCollection.Add(2);





#region first Example
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