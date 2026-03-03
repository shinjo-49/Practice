namespace Practice;

public class Person
{
        public Person(string name = "名無し", int age = 0, int password = 0000)
    {
        Name = name;
        Age = age;
        HowToMove = "歩く";
        PassWord = password;
    }
 
    public string Name //自動実装プロパティは、フィールドを自動的に生成してくれるプロパティのことだが、フィールドと違って初期値がないため、nullになる可能性がある
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

    public string HowToMove
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