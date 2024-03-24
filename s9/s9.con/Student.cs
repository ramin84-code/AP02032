

using System.ComponentModel;

namespace s9.con;
class Student{
    public string student_id;
    public string Name;
    public int age;
    public static List<string>courses{get;} = new List<string>();

    public Student(string Student_id , string name, int Age){
        student_id = Student_id;
        Name = name;        
        age = Age;
        //List<string>Courses = new List<string>();
        //courses = Courses;
    }
    public void Enroll(string course_name){
        courses.Add(course_name);
        
    }
    static void Main(string[] args){
        var st = new Student("0", "Ramin",18);
        st.Enroll("computer");

    }

}

//class Program : Student{
//    public static string  student_id;
//    public static string name;
//    public int age;
//    public static List<string>cours = new List<string>();
//    public static List<string> students = new List<string> ();
//
//    public Program(string id, string Name, int Age){
//        student_id = id;
//        name = Name;
//        age = Age;
//        List<string> student = new List<string>();
//        List<string> course = new List<string>();
//        students = student;
//        cours = course;
//    }
//
//    public static void Add_student(){
//        Console.WriteLine("student_id :");
//        Console.ReadLine ();
//    }
//
//    static void Main(string[] args)
//    {
//        Program program = new Program("0", "ali", 18,"math","ali, ramin");
//        Add_student();
//    }
//}

