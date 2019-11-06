using System;

namespace workspace
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("There we go!");

            Player newPlayer = new Player("Bryan");
            
            newPlayer.Attack();
        }
    }
}
