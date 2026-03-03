namespace Practice;

public class Person//プロパティを通してフィールドにアクセス
{
    protected string name = "";
    protected int age = 0;
    protected string sex = "回答なし";
 
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
    
     public void Introduce()
    {
        Console.WriteLine($"名前：{name} 年齢：{age}歳 性別：{sex}");
    }   

}

public class Person2 : Person//Personクラスを継承し、新たにメソッドを追加することでPersonクラスの呼び出し機能を拡張
{
    public void SetInfo(string name, int age, string sex)
    {
        this.name = name;
        this.age = age;
        this.sex = sex;
    }
    public void SetInfo(string name, int age)
    {
        this.name = name;
        this.age = age;
    }
       
}