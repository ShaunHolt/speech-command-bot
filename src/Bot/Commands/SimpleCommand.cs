using Bot.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.Bot.Connector;
using System.Threading.Tasks;

namespace Bot.Commands
{
    public class SimpleCommand : ICommand
    {
        public void Run(IActivity activity)
        {
            var connector = new ConnectorClient(new Uri(activity.ServiceUrl));
            Task task = new Task(async () =>
            {
                var reply = ((Activity)activity).CreateReply("Um momento, vou pesquisar!");
                await connector.Conversations.SendToConversationAsync(reply);

                var message = "The SimpleCommand was triggered!";

                reply = ((Activity)activity).CreateReply(message);
                await connector.Conversations.SendToConversationAsync(reply);
            });
            task.Start();
        }
    }
}