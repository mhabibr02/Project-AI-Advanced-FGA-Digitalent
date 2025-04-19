// Add Azure OpenAI packages

using Azure.AI.OpenAI;

using OpenAI.Chat;

 

// Define parameters and initialize the client

string endpoint = "<YOUR_ENDPOINT_NAME>";

string key = "<YOUR_API_KEY>";

string deploymentName = "<YOUR_DEPLOYMENT_NAME>";

 

AzureOpenAIClient azureClient = new AzureOpenAIClient(new Uri(endpoint), new AzureKeyCredential(key));

ChatClient chatClient = azureClient.GetChatClient(deploymentName);
