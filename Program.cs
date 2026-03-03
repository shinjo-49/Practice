using System;
using System.Security.Cryptography;
using Practice;

class Program
{
    static void Main()
    {
        String[] a = new String[10000];

        for (int i = 0; i < a.Length; i++)
        {
            a[i] = new String('M', 10000);
        }

        Console.WriteLine("文字列生成後：{0}", GC.GetTotalMemory(false)); 

        a = null;

        Console.WriteLine("aへの参照解除後：{0}", GC.GetTotalMemory(false));

        GC.Collect();

        Console.WriteLine("GC.Collect()実行後：{0}", GC.GetTotalMemory(false));
    }
}