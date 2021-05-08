using System;

namespace CarRacing
{
    //delegate void Racing();
    

    class Program
    {
        static void Main(string[] args)
        {
            GameRacing gameRacing = new GameRacing();
            gameRacing.Competition();
            gameRacing.start_delegate();
            gameRacing.Gonka();
        }
    }
}
