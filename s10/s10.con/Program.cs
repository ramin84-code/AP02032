using System;
namespace s10.con;
//class Customer{
//    public int Id;
//    public string Name;
//    public List<Order> Orders= new List<Order>();
//
//    public Customer(int id, string name){
//        this.Id = id;
//        this.Name = name;
//    }
//}
//public class Order{
//    
//}
//class Cubic{
//    public double length;
//    public double width;
//    public double height;
//    public double paint_cost;
//
//    public Cubic(double len, double wid, double h, double paint_cos){
//        this.length = len;
//        this.width= wid;
//        this.height = h;
//        this.paint_cost = paint_cos;
//    }
//
//    public double Volume(){
//        return length*width*height;
//    }
//    public double Total_cost(){
//        return this.paint_cost*2*((length*width)+(length*height)+(height*width));
//    }
//}

enum ErrorSource{
    UI = 0x100000,
    FE = 0x200000,
    BE = 0x400000
}
enum ErrorType{
    ID = 0x000100,
    FS = 0x000200,
    Net = 0x400400
}

enum ErrorSeverity{
    Debug = 0x000001, 
    Info = 0x000002,
    Warning = 0x000004, 
    Error = 0x000008,
    Abort = 0x000010
}
class Program
{
    static void Main(string[] args)
    {
        //int x;
        //bool success;
        //success = int.TryParse("54",out x);
        //if (success){
        //    x = int.Parse("54");
        //    Console.BackgroundColor = ConsoleColor.Green;
        //    Console.WriteLine(x);
        //}

        //var c = new Cubic(3.4,4.3,2.5,10);
        //double x = c.Volume();
        //Console.WriteLine(x);
        //Console.WriteLine(c.Total_cost());
        
        Console.WriteLine("Hello, World!");
    }
}
