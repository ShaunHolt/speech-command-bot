# Speech Command Bot Template

## Overview
Expanded vision of your project.

### Documentation
1. [Overview (this file)](./README.md)
2. [Adding Commands](./docs/AddingCommands.md)

## Prerequisites
List of prerequisites in order to build or run the project:

| Requirement                       	| Description |
|-----------------------------------	|-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------	|
|[Visual Studio](https://www.visualstudio.com/downloads/)                         | Used for developing and testing                                                        |
|[Azure Subscription](https://azure.microsoft.com/en-us/)                         | Deploy of services/apis                                                           |
|[LUIS Key](https://www.luis.ai/)                         | Natural Language Processing API                                                         |
|[Bing Speech API Key](https://azure.microsoft.com/en-us/services/cognitive-services/speech/)                         | STT and TTS API                                                           |

## Quick Start
### Configuring the bot

Add a file `Web.config.secrets` on directory */src/Bot/*, right after `Web.config`, with the following Bot Framework, LUIS and other services endpoint:

```xml
<appSettings>
    <add key="BotId" value="<bot_id>" />
    <add key="MicrosoftAppId" value="<bot_microsoft_app_id>" />
    <add key="MicrosoftAppPassword" value="<bot_microsoft_app_password>" />
    <add key="LuisModelId" value="<luis_model_id>"/>
    <add key="LuisSubscriptionKey" value="<luis_subscription_key>"/>
</appSettings>
```

### Enabling Web Chat

Add the file `chat.secrets.js` on directory */src/Bot/Chat* with the following schema and keys:

```js
var secrets = {
    direct_line_secret: '<directline>',
    cognitive_services_speech_secret: '<cognitive>'  
};
```
Once configured DirectLine channel, it's possible to access the page `http://<appurl>/Chat/index.html`.

### Chat with the bot

A typical conversation could be:
* Hi
* Bye
* /commands=simple