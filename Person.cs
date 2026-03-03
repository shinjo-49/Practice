namespace Practice;

public class Person//プロパティを通してフィールドにアクセス
{
    protected string name = "";
    protected int age = 0;
    protected string howToMove = "こんな風に動かします";

    protected int password = 0000;
 
    public string Name 
    {
        set{name = value;}
        get{return name;}
    }

    public int Age
    {
        set{age = value;}
        get{return age;}
    }

    public int PassWord
    {
        set{password = value;}
    }

    public string HowToMove
    {
        get{return howToMove;}
    }
    
     /*
     public void Introduce()
    {
        Console.WriteLine($"名前：{name} 年齢：{age}歳 説明：{HowToMove}");
    }   
    */

}