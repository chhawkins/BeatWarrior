using System;

namespace Gaming
{
    public static class Program
    {
        [STAThread]
        static void Main()
        {
            using (var game = new BeatWarrior())
                game.Run();
        }
    }
}
