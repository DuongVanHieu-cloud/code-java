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
////////////////////////////////////
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
        var counts = new Dictionary<int, int>();
        foreach (int value in ints)
        {
            if (counts.ContainsKey(value))
            {
                counts[value]++;
            }
            else
            {
                counts[value] = 0;
            }
        }
        Console.WriteLine("So lan xuat hien cua {0} trong mang la: {1}", a, counts.ContainsKey(a) ? counts[a] : 0);
    }
}
