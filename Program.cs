using System;
using System.Security.Cryptography;
using Practice;

class Program
{
    static void Main()
    {
        Person p1;
        p1 = new Person();
        
        

        p1.Name = "山田太郎";
        p1.Age = 20;
        p1.PassWord = 1234;//パスワードは外部から変更できるが、プロパティにgetアクセサーがないため読み取ることはできない
        //p1.HowToMove = "日本語";←プロパティにsetアクセサーがないためエラー

        

    

        Console.WriteLine($"名前：{p1.Name} 年齢：{p1.Age}歳 説明：{p1.HowToMove}");//パスワードは  外部から読み取ることができないため、表示されない
    }
}