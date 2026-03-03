namespace Practice;

public class Person
{
    public string name = "";
    public int age = 0;
    public string sex = "回答なし";
    public void Introduce()
    {
        Console.WriteLine($"名前：{name} 年齢：{age}歳 性別：{sex}");
    }   

    public void SetInfo(string name, int age)
    {
        this.name = name;
        this.age = age;
    }

    public void SetInfo(string name, int age, string sex)
    {
        this.name = name;
        this.age = age;
        this.sex = sex;
    }
}
