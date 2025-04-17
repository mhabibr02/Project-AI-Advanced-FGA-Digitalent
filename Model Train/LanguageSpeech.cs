var data = new

{

    analysisInput = new

    {

        conversationItem = new

        {

            text = userText,

            id = "1",

            participantId = "1",

        }

    },

    parameters = new

    {

        projectName,

        deploymentName,

        // Use Utf16CodeUnit for strings in .NET.

        stringIndexType = "Utf16CodeUnit",

    },

    kind = "Conversation",

};

Response response = await client.AnalyzeConversationAsync(RequestContent.Create(data));
