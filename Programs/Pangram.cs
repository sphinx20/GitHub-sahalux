using System;
using System.Collections.Generic;
using System.IO;
class Pangram {
    static void Main(String[] args) {
        /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
        var s = Console.ReadLine();
        bool[] arr = new bool[26];
        
        foreach(char c in s.ToLower()){
            int n = c - '0';
            if(n >= 0 && n<=74){
            arr[n-49] = true;
           // Console.WriteLine(n-49);
            
            }
           
        }
        var flag = true;
        // Console.WriteLine(arr.Length);
        for(int i=0; i<arr.Length; i++){
           // Console.WriteLine(i+ ". "+ arr[i]);
            if(!arr[i]){
                flag = false;
                
               break;
            }
        }
        
        if(flag){
            Console.WriteLine("pangram");
        }
        else{
            Console.WriteLine("not pangram");
        }
    }
}