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
////////////////////////////////////////////////////////////
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
        int[] c = new int[a.Length + b.Length];
        for(int i = 0;i< a.Length; i++)
        {
            c[i] = a[i] ;
        }
        for (int i = 0;i< b.Length; i++)
        {
            c[i + a.Length] = b[i];
        }
        Console.WriteLine(string.Join(", ",c));

    }
}
