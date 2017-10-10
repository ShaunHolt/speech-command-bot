using Bot.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.Bot.Connector;

namespace Bot.Commands
{
    public class DefaultCommand : ICommand
    {
        public void Run(IActivity activity) { }
    }
}