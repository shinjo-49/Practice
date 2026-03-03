using System;
using Practice;

class Program
{
    static void Main()
    {
        Person p1,p2;
        p1 = new Person();
        p2 = new Person();

        p1.name = "山田太郎";//フィールドに直接アクセスして値を代入
        p1.age = 20;

        p2.SetAgeAndName("田中花子", 25);//メソッドを呼び出して値を代入

        p1.Introduce();
        p2.Introduce();
    }
}