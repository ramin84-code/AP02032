namespace split_byte;

class Program
{
    static void Main(string[] args)
    {

        SPlitStr  st = new SPlitStr("ali  zari  vali dali",3);
        IEnumerator <string> std = st.GetEnumerator();
        while(std.MoveNext())
        {
            Console.WriteLine(std.Current);
        }
        //string x = "ali  zari  vali dali";
        //string a = null;
        //int asn = x.Length/3;
        //int count = 0;
        //for (int i= 0;i<x.Length;i++){
        //    a += x[i];
        //    if(i%3 ==0){
        //        if (i!=0){
        //            Console.WriteLine(a);
        //            a = null;
        //            count ++;
        //        }
        //    }
        //}
        //Console.WriteLine(a);
        
        Console.WriteLine("Hello, World!");
    }
}
