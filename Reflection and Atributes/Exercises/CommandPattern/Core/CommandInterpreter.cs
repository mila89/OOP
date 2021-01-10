using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CommandPattern.Core.Contracts;
using System.Reflection;

namespace CommandPattern.Core

{
    class CommandInterpreter : ICommandInterpreter
    {
        public string Read(string args)
        {
            string[] input = args.Split(" ", StringSplitOptions.RemoveEmptyEntries);
            string typeCommand = input[0];
            string[] commandArgs = input.Skip(1).ToArray();
            string result = null;
            var type =Assembly.GetCallingAssembly().GetTypes().FirstOrDefault(c=>c.Name==$"{typeCommand}Command");
            ICommand instance = (ICommand)Activator.CreateInstance(type);
            result=instance?.Execute(commandArgs)?? "Invalid command";
            return result;
        }
    }
}
