using System;
using System.Threading.Tasks;

class Program
{
    
    static async Task Main(string[] args)
    {
        
        Task<string> washing = wash(2000, 3000);
        Task<string> cooking = cook(2000);

        // 終了を待つ間に 0 を出力するタスク
        Task spinner = Task.Run(async () =>
        {
            while (!washing.IsCompleted || !cooking.IsCompleted)
            {
                Console.Write("0");        // 空いたスレッドで 0 を表示
                await Task.Delay(100);     // 少し待つと CPU を食わない
            }
        });

        await Task.WhenAll(washing, cooking);

        Console.WriteLine(washing.Result);
        Console.WriteLine(cooking.Result);

         await spinner;
       
       
    }

    static async Task<string> wash(int a, int b)
    {
        Console.WriteLine("洗濯を始めます。");
         await Task.Delay(b);
        Console.WriteLine("洗濯が終わりました。");
        Console.WriteLine("洗濯物を干します。");
        await Task.Delay(a);
        Console.WriteLine("洗濯物を干し終わりました。");
        return "洗濯が完了しました。";
    }

    static async Task<string> cook(int a)
    {
        Console.WriteLine("料理を始めます。");
        await Task.Delay(a);
        Console.WriteLine("料理が終わりました。");
        return "料理が完了しました。";
        
    }
}