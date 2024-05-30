using System.Collections;
using System.Security.Cryptography.X509Certificates;

namespace E1;

public partial class Basics
{
    
    #region TODO
    public static int[] Q0_Reverse(int [] sum){
        int [] x = new int[sum.Length];
        if(sum.Length!=0)
        {int y =sum[0];
        sum[0]=sum[sum.Length-1];
        sum[sum.Length-1]=y;
        x = sum;
        Array.Reverse(x);}
        
        if(sum.Length == 0) return x;
        
        return x;
        }
    public static int[] Q1_Reverse(int[] ints){
        int []y = new int[ints.Length];
        if(ints.Length!=0&& ints.Length!=2){
            y[0]= ints[0];
            y[ints.Length-1] = ints[ints.Length-1];
            Array.Reverse(ints);
            for(int i = 1;i<ints.Length-1;i++) y[i] = ints[i];
            Array.Reverse(ints);
            }
        else if(ints.Length==2) y = ints;
        else{return y;}

        return y;
    }
    public static T[] Q2_Reverse <T>(T[] sum) where T: IComparable<T>{
        T[]xx = new T[sum.Length] ;
        if(sum.Length !=0 && sum.Length!=2){
            T x = sum[0];
            sum[0]= sum[sum.Length-1];
            sum[sum.Length-1] = x;
            xx = sum;
            Array.Reverse(xx);
            return xx;}
        else if(sum.Length ==2){
            xx = sum;
            return xx;
        }
        else{
            return sum;
        }
    }
    public static int Q5_CalculateSum(string s){
        string []xx = s.Split('+');
        int sum = 0;
        try{
            foreach(var ss in xx) sum += int.Parse(ss);
        }
        catch(FormatException fx){
            throw fx;
        }
        return sum;}
        
    //

    // Q0_Reverse
    // Q1_Reverse
    // Q2_Reverse
    // Q5_CalculateSum
    // Q6_TryCalculateSum
    #endregion
}

#region TODO
public class Human:IHasAge{
    public string Name{get;set;}
    public int Age{get;set;}
    public Human(string name, int age){
        this.Name = name;
        this.Age = age;
    }

    public int GetAge()=> this.Age;
    
}

public interface IHasAge{
    public int GetAge();

}
// IHasAge
// Human
#endregion
