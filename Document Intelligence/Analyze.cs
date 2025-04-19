string endpoint = "<endpoint>";

string apiKey = "<apiKey>";

AzureKeyCredential credential = new AzureKeyCredential(apiKey);

DocumentAnalysisClient client = new DocumentAnalysisClient(new Uri(endpoint), credential);

 

string modelId = "<modelId>";

Uri fileUri = new Uri("<fileUri>");

 

AnalyzeDocumentOperation operation = await client.AnalyzeDocumentFromUriAsync(WaitUntil.Completed, modelId, fileUri);

AnalyzeResult result = operation.Value;
