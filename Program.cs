using System;
using System.Security.Cryptography;
using Practice;

class Program
{
    static void Main()
    {
        Person p1,p2,p3;
        p1 = new Person();
        p2 = new Person("鈴木一郎", 30);
        p3 = new Person("佐藤花子", 25, 5678);
        
        //パスワードは外部から変更できるが、プロパティにgetアクセサーがないため読み取ることはできない
        //p1.HowToMove = "このように操作します";←プロパティにsetアクセサーがないためエラー

        

    

        /*Console.WriteLine($"名前：{p1.Name} 年齢：{p1.Age}歳 説明：{p1.HowToMove}");*///パスワードは  外部から読み取ることができないため、表示されない
        p1.Introduce();
        p2.Introduce();
        p3.Introduce();
    }
}