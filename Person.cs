namespace Practice;

public class Person
{
        public Person(string name = "名無し", int age = 0, int password = 0000)//初期値ありのコンストラクタ
    {
        Name = name;
        Age = age;
        HowToMove = "歩く";
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
    
     /*
     public void Introduce()
    {
        Console.WriteLine($"名前：{name} 年齢：{age}歳 説明：{HowToMove}");
    }   
    */

}