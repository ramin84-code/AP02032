using System.IO;

namespace Project{
class Project{
    static void Make_file(){
        string s = @"C:\git\AP02032\S6\file.exe";
        string str = "Hi I'm Ramin .Iam 18 years old. I have 80 classmates in the Engineering Computer school.I have 0 brtothers and sisters. The ranking of my university among Iranian Universiteis is 4. ";
        File.AppendAllText(s,str);
    }

    public static void Add_number(int x){
        string y =  @"C:\git\AP02032\S6\file.exe";
        string s = File.ReadAllText(y);
        string a = s+ x.ToString()   ;
        File.Delete("file.exe");
        File.AppendAllText(y,a);

    }
    public static void Add_number_first(int nums){
        string u = @"C:\git\AP02032\S6\file.exe";
        string x = File.ReadAllText(u);
        string a = nums.ToString()+ x;
        File.Delete("file.exe");
        File.AppendAllText(u,a);
    }
    //public static void Remove_members(){
    //    string g = @"C:\git\AP02032\S6\file.exe";
    //    string s = File.ReadAllText("file.exe");
    //    for (int i =0;i<s.Length;i++){
    //        s.Remove(s[i]);
    //    }
    //    
    //}

    public static void Remove_number(){
        string g = "0123456789";
        string read = @"C:\git\AP02032\S6\file.exe";
        string s = File.ReadAllText(read);
        //List <int> arr = new List<int>();
        //for (int nums = 0;nums<s.Length;nums++){
        //    arr.Add(s[nums]);
        //}
        string str = "";
        for (int i =0;i<s.Length;i++){
            for(int j =0;j<g.Length;j++){
                {
                    char a = (char)s[i];
                    char b = (char)g[j];
                    if (a == b){
                        ;
                    }
                    else{
                        str+= s[i];
                    }
                }
                
            }
        }
        
        File.Delete("file.exe");
        File.AppendAllText("file.exe",str);
    }
    public static int Main(string[] args){
        Make_file();
        Add_number(24);
        Add_number_first(1001);
        //Remove_number();

        return 0;
    }



}
}
