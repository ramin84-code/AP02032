using System.Security;

namespace s8.con;

class Program
{
   
    
    static void Main(string[] args)
    {
       
        //if (people.Contains(p1)){
        //    System.Console.WriteLine("Yes");
        //}
        //for (int i =0;i<people.Count;i++){
        //    System.Console.WriteLine(people[i]);
        //}
        string ss = "123456";
        string [] tokens = ss.Split(',');
        int sum = 0;
        for (int i =0;i<tokens.Length;i++){
            sum += int.Parse(tokens[i]);
        }
        Console.WriteLine(sum);

        Console.WriteLine("Hello, World!");
        // to show a new dictionary in cs the example is below.
        Dictionary<int, string> pb = new Dictionary<int, string>();

        pb.Add(12344333,"alid");
        
        string a = pb[12344333];
        // to change the phone number into a string.

    }
}
