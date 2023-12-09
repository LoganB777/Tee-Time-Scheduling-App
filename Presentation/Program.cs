using LogicLayer;
using System;

namespace Presentation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Tee Time Scheduler!");
            Helper helper = new Helper();
            helper.MainMenu();
        }
    }
}
