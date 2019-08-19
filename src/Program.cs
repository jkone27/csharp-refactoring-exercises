using System;
using MissingAbstraction.PublicBoolProperty.Before;

namespace Refactoring
{

    class Program
    {
        static void Main(string[] args)
        {

            var x = new Aeroplane();
            var flyService = new FlyService();
            flyService.Fly(x);

            Console.WriteLine("Hello World!");
        }
    }
}
