using System;
using System.Security.Cryptography;
using Practice;

class Program
{
    static void Main()
    {
        Person2 p1,p2,p3,p4;
        p1 = new Person2();
        p2 = new Person2();
        p3 = new Person2();
        p4 = new Person2();
        

        p1.Name = "山田太郎";//フィールドに直接アクセスして値を代入ができないため（できないようにした）、プロパティを呼び出して値を代入
        p1.Age = 20;

        p2.SetInfo("田中花子", 25);//メソッドを呼び出して値を代入(オーバーロード、性別なし)

        p3.SetInfo("佐藤次郎", 30, "男性");//メソッドを呼び出して値を代入（オーバーロード、性別あり）

    

        p1.Introduce();
        p2.Introduce();
        p3.Introduce();
    }
}