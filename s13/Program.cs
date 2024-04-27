using System.Diagnostics;

namespace s13;

class Program
{
    

    public void Measure(){
        StreamReader st = new StreamReader("project.assets.json");
        string su = null;
        int count = 100;
        Stopwatch sw = new Stopwatch();
        sw.Start();
        while(null!=(su = st.ReadLine())&& count -- >0){
            System.Console.WriteLine(su);
        }
        sw.Stop();
        st.Dispose();
        System.Console.WriteLine("-------------------->>>>>>>>>");
        System.Console.WriteLine(sw.Elapsed.Milliseconds);

    }
    public void Calc(){
        using StreamReader reader = new StreamReader("s13.deps.json");
        string nu = null;
        int len = 50;
        Stopwatch st = new Stopwatch();
        st.Start();
        try{
            while(null!=(nu = reader.ReadLine()) && len>0)
            {
                System.Console.WriteLine(nu);
                len--;

            }
            st.Stop();}
        catch( Exception ex){
            System.Console.Write(ex.Message);
        }
        
        System.Console.WriteLine(st.Elapsed.Milliseconds);

    }

    static void Main(string[] args)
    {
        var Pro = new Program();
        System.Console.WriteLine("The File Reader System: ");
        Pro.Measure();
        Pro.Calc();
        
    }
}
