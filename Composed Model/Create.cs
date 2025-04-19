// Create an Azure AI Document Intelligence client

string endpoint = "<endpoint>";

string apiKey = "<apiKey>";

var credential = new AzureKeyCredential(apiKey);

var client = new DocumentAnalysisClient(new Uri(endpoint), credential);

 

// Specify the model to use

string modelId = "<modelId>";

 

// Specify the file to analyze

Uri fileUri = new Uri("<fileUri>");

 

// Call the model

AnalyzeDocumentOperation operation = await client.StartAnalyzeDocumentFromUriAsync(modelId, fileUri);
