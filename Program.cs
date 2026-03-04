using System;
using System.Security.Cryptography;
using Practice;

class Program
{
    
    static void Main(string[] args)
    {
        Console.WriteLine("野球選手のポジションを入力してください（１、投手　２，キャッチャー）");//今は投手だけ
        switch (Console.ReadLine())
        {
            case "1":
                Pitcher pitcher = new Pitcher();
                pitcher.BestPlayer();
                pitcher.ShowTeam();
                break;
            case "2":
                Catcher catcher = new Catcher();
                catcher.BestPlayer();
                catcher.ShowTeam();
                break;
            default:
                Console.WriteLine("入力されたポジションは存在しません。");
                break;
        }

    }
}