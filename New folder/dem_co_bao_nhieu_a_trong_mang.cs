using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Xml.Schema;
using System.Linq;
class mang {
    public static void Main(string[] args)
    {
        int a = 2;
        
        int[] ints = { 2, 2, 3 };
        int sum = Array.FindAll(ints,x => x == a).Length;
        Console.WriteLine(sum);
    }
    
    

}
