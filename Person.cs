namespace Practice;


   class BaseballPlayer
    {   protected string position;
        public BaseballPlayer(string position)
        {
            this.position = position;
            Console.WriteLine($"{position}について知りたいですね！");
        }
        public virtual void BestPlayer()
        {
            Console.WriteLine($"このポジションにおける最高の選手を参照します。");
        }
        public virtual void ShowTeam()
        {
            Console.WriteLine($"この選手がプレーしている球団を参照します。");
        }

    }

    class Pitcher : BaseballPlayer
    {
        public Pitcher() : base("投手")
        {

        }

        public override void BestPlayer()
        {
            base.BestPlayer();
            Console.WriteLine("このポジションにおける最高の選手は山本由伸です。");
        }

        public override void ShowTeam()
        {
            base.ShowTeam();
            Console.WriteLine("この選手はロサンゼルス・ドジャースに所属しています。");
        }

    }
    class Catcher : BaseballPlayer
    {
        public Catcher() : base("キャッチャー")
        {

        }

        public override void BestPlayer()
        {
            base.BestPlayer();
            Console.WriteLine("このポジションにおける最高の選手は坂本誠志郎です。");
        }

         public override void ShowTeam()
        {
            base.ShowTeam();
            Console.WriteLine("この選手は阪神タイガースに所属しています。");
        }
    }