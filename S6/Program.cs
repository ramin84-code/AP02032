using System.IO;
using System.Text.RegularExpressions;
namespace Project{
class Project{
//    static void Make_file(){
//        string s = @"C:\git\AP02032\S6\file.txt";
//        string str = "Hi Iam Ramin .Iam 18 years old. I have 80 classmates in the Engineering Computer school.I have 0 brtothers and sisters. The ranking of my university among Iranian Universiteis is 4. ";
//        File.AppendAllText(s,str);
//    }
//
//    public static void Add_number(int x){
//        
//        string s = File.ReadAllText("file.txt");
//        string a = s+ x.ToString()   ;
//        File.Delete("file.txt");
//        string y =  @"C:\git\AP02032\S6\file.txt";
//        File.AppendAllText(y,a);
//
//    }
//
//    public static void Remove_number(int nums){
//
//    }
//    public static int Main(){
//        Make_file();
//        string x = File.ReadAllText("file.txt");
//        Console.WriteLine(x);
//        Add_number(24);
//
//        return 0;
//
//    }
    public static int Main(){
        Regex  r = new Regex(@"\d+");
        Match m = r.Match("We have 730 days in 2 years");
        if (m.Success) Console.WriteLine(m.Value);
        return 0;
        
    }
}
}
