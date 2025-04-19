var chatCompletionsOptions = new ChatCompletionsOptions()

{

    Messages =

    {

        new ChatRequestSystemMessage("You are a casual, helpful assistant. You will talk like an American old western film character."),

        new ChatRequestUserMessage("Can you direct me to the library?")

    }

};
