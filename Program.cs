using System;
using System.Security.Cryptography;
using Practice;

class Program
{
    private static int a = 10;
    private int b = 20;

    private static void StaticMethod()
    {
        Console.WriteLine($"StaticMethod: a = {a}");
        //Console.WriteLine($"StaticMethod: b = {b}"); // エラー: 静的メソッドからインスタンス変数にアクセスできない
    }

    private void InstanceMethod()
    {
        Console.WriteLine($"InstanceMethod: a = {a}");
        Console.WriteLine($"InstanceMethod: b = {b}");
    }

    static void Main()
    {
        Program p = new Program();
        StaticMethod(); // 静的メソッドの呼び出し
        p.InstanceMethod(); // インスタンスメソッドの呼び出し

        /*
        Person p1,p2,p3;
        p1 = new Person();
        p2 = new Person("鈴木一郎", 30);
        p3 = new Person("佐藤花子", 25, 5678);
        */
          

        /*Console.WriteLine($"名前：{p1.Name} 年齢：{p1.Age}歳 説明：{p1.HowToMove}");*///パスワードは  外部から読み取ることができないため、表示されない
        /*
        p1.Introduce();
        p2.Introduce();
        p3.Introduce();
        */
    }
}