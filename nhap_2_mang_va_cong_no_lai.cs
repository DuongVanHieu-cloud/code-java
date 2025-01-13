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
        int n = int.Parse(Console.ReadLine());
        

        int[] a = new int[n];// tao mang voi kich thuoc n
        for (int i = 0; i < n; i++)
        {
            a[i] = int.Parse(Console.ReadLine());
        }
        int[] b = new int[n];
        for (int i = 0; i < n; i++)
        {
            b[i] = int.Parse(Console.ReadLine());
        }
        int[] mergedArray = a.Concat(b).ToArray();
        Console.Write(string.Join(", ", mergedArray));

    }
}
