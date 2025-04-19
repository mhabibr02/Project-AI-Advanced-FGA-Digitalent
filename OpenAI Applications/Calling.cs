// Get chat completion

ChatCompletion completion = chatClient.CompleteChat(

    [

        new SystemChatMessage(systemMessage),

        new UserChatMessage(userMessage),

    ]);

 

// Print the response

Console.WriteLine($"{completion.Role}: {completion.Content[0].Text}");
