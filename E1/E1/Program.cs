namespace E1;

public class Program
{
    
    static void Main(string[] args)
    {
        //int[]nums = new int[] { 1, 2, 3, 4, 5 };
        //int[]result = Basics.Q1_Reverse(nums);
        Person p = new Teacher("محمد رضا شجریان", false);
        System.Console.WriteLine(p.Name);
    }
}

