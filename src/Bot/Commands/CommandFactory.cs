using Bot.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Bot.Commands
{
    public class CommandFactory
    {
        public static ICommand GetCommand(string command)
        {
            switch (command.ToLower())
            {
                case "simple":
                    return new SimpleCommand();
                case "math":
                    return new MathCommand();
                default:
                    return new DefaultCommand();
            }
        }
    }
}