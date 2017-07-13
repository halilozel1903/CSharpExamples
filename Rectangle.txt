using System.IO;
using System;

class Rectangle{
    
    double length;
    double width;
    
    public void AcceptDetails(){
        length=5.1;
        width=4.2;
    }
    
    public double GetArea(){
        return length*width;
    }
    
    public void Display(){
        Console.WriteLine("Length:{0}",length);
        Console.WriteLine("Width:{0}",width);
        Console.WriteLine("Area:{0}",GetArea());
    }
}

class Program
{
    static void Main(string[] args)
    {
        Rectangle rectangle=new Rectangle();
        rectangle.AcceptDetails();
        rectangle.Display();
        Console.ReadLine();
    }
}
