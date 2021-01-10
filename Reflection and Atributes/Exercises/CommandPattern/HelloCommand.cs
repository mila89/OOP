using CommandPattern.Core.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace CommandPattern
{
    public class HelloCommand : ICommand
    {

        public HelloCommand()
        {

        }
        public string Execute(string[] args)
        {
            return $"Hello, {args[0]}";
        }
    }
}
