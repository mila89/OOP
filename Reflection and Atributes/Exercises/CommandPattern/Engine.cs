using CommandPattern.Core.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace CommandPattern
{
    public class Engine : IEngine
    {
        private readonly ICommandInterpreter _command;
        public Engine(ICommandInterpreter command)
        {
            this._command = command;
        }

        public Engine()
        {

        }
        public void Run()
        {
            while (true)
            {
                string input = Console.ReadLine();
                var result = _command.Read(input);
                Console.WriteLine(result);
            }
        }
    }
}
