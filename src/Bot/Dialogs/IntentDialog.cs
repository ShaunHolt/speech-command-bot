using Microsoft.Bot.Builder.Dialogs;
using Microsoft.Bot.Builder.Luis;
using Microsoft.Bot.Builder.Luis.Models;
using Microsoft.Bot.Connector;
using Bot.Utils;
using System;
using System.Threading.Tasks;

namespace Bot.Dialogs
{
    [Serializable]
    public class IntentDialog : LuisDialog<object>
    {
        public IntentDialog(string modelId, string subscriptionKey) : base(new LuisService(new LuisModelAttribute(modelId, subscriptionKey, domain: "eastus2.api.cognitive.microsoft.com"))) { }

        [LuisIntent("")]
        [LuisIntent("None")]
        public async Task None(IDialogContext context, IAwaitable<IMessageActivity> activity, LuisResult result)
        {
            await context.PostAsync("Sorry, I couldn't identify what you've said!");
        }

        [LuisIntent("Hey")]
        public async Task HandleGreetings(IDialogContext context, IAwaitable<IMessageActivity> activity, LuisResult result)
        {
            await context.PostAsync("Hey!");
        }

        [LuisIntent("Bye")]
        public async Task HandleDespedidas(IDialogContext context, IAwaitable<IMessageActivity> activity, LuisResult result)
        {
            await context.PostAsync("Bye!");
        }

        private Task ResumerAfterExecution(IDialogContext context, IAwaitable<object> result)
        {
            context.Wait(base.MessageReceived);
            return Task.CompletedTask;
        }
    }
}