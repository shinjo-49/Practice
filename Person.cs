namespace Practice;

public class Person
{
    public Person():this("名無し", 0, 0000)
    {
        Console.WriteLine("引数なしのコンストラクタが呼び出されました");
    }//引数なしのコンストラクタ

    public Person(string name, int age):this(name, age, 0000)
    {
        Console.WriteLine("引数2つのコンストラクタが呼び出されました");
    }
        //引数2つのコンストラクタ
    public Person(string name , int age, int password)//引数3つのコンストラクタ
    {
        Name = name;
        Age = age;
        HowToMove = "歩く";//説明は初期値で「歩く」としているため、外部から変更できない
        PassWord = password;
    }
 
    public string Name //
    {
        set;get;
    }

    public int Age
    {
        set;get;
    }

    public int PassWord
    {
        set;private get;
    }

    public string HowToMove//プロパティにsetアクセサーがないため、外部から変更できない。コンストラクタ内の初期値で設定したものを読み取るだけ
    {
        get;private set;
    }
    
     
     public void Introduce()
    {
        Console.WriteLine($"名前：{Name} 年齢：{Age}歳 説明：{HowToMove}");
    }   
    

}