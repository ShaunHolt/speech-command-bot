using Bot.Interfaces;
using Microsoft.Bot.Connector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace Bot.Commands
{
    public class MathCommand : ICommand
    {
        public void Run(IActivity activity)
        {
            var connector = new ConnectorClient(new Uri(activity.ServiceUrl));
            Task task = new Task(async () =>
            {
                var reply = ((Activity)activity).CreateReply("Um momento, vou pesquisar!");
                await connector.Conversations.SendToConversationAsync(reply);

                var message = DoMath(3, 4).ToString();

                reply = ((Activity)activity).CreateReply(message);
                await connector.Conversations.SendToConversationAsync(reply);
            });
            task.Start();
        }

        public int DoMath(int x, int y) => x * y;
    }
}