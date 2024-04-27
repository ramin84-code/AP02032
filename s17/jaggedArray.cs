using System.Runtime.InteropServices;

namespace s17;
public class Array{
    public int n{get;}
    public Array(int N){
        this.n =N;
    }
    public bool Is_prime(int a ){
        if (a<2){
            return false;
        }
        for (int i =2;i<a;i++){
            if (a%i ==0){
                return false;
            }
        }
        return true;
    }
    public void jagged_arr(){
        int [][] arr = new int[this.n][];
        int ad = 1;
        int nums =2;

        arr[0] = new int[2];
        arr[0].Append(1);
        arr[0].Append(2);
        for(int i =1;i<this.n;i++){
            
            while(!Is_prime(ad)&& (nums!= ad)){
                
                ad ++;
            }
            if (Is_prime(ad)){
                
                    
                arr[i] = new int [ad];
                for(int k = 0;k<ad+1;k++){
                arr[i].Append(k);
                
                
                nums =ad;
                ad = 1;}
                }
        }
        for(int i=0;i<arr.Length;i++){
            for(int k =0;k<arr[i].Length;i++){
                Console.Write(arr[i][k]);
            }
            Console.WriteLine   ();
        }

    }
}