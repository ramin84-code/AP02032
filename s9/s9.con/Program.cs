
using System.IO.Enumeration;
using System.Security.Cryptography.X509Certificates;

namespace s9.con;

class Program{
    static List<Student> student_s = new List<Student>();

    public static void AddStudent(){
        Console.WriteLine("Please enter Your Name:");
        string st_name = Console.ReadLine();
        Console.WriteLine("Please enter your Id : ");
        string s = Console.ReadLine();

        Console.WriteLine("Please enter your age: ");
        int st_age = int.Parse(Console.ReadLine());

        student_s.Add(new Student(st_name,s,st_age));


    }

    public static void EnrollStudentInCourse(){
        Console.WriteLine("Please enter your id_number: ");
        string x = Console.ReadLine();
        int a =0;
        foreach(Student s in student_s){
            if (s.student_id == x){
                a++;
        }
        if (a==1){
            Console.WriteLine(s.Name);
            Console.WriteLine(s.student_id);
            Console.WriteLine(s.age);
        }
        else{
            Console.WriteLine("The Student was not found with the given id .");
        }
    }
    }
    public static void SaveStudentToFile(string filename){
        
    }

    static void Main(string[] args){

    }

}