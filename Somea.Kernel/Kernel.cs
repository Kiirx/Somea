using System;
using Sys = Cosmos.System;

namespace Somea.Kernel
{
    public class Kernel : Sys.Kernel
    {
        protected override void BeforeRun()
        {
            Console.WriteLine("Cosmos kernel.");
        }

        protected override void Run()
        {
            Console.Write("> ");
            var input = Console.ReadLine();
            Console.WriteLine(input);
        }
    }
}