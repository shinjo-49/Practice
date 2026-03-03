namespace Practice;

public class Person
{
    public string name = "";
    public int age = 0;
    public void Introduce()
    {
        Console.WriteLine($"名前：{name} 年齢：{age}歳");
    }   

    public void SetAgeAndName(string name, int age)
    {
        this.name = name;
        this.age = age;
    }
}
