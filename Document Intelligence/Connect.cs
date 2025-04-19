using Azure;

using Azure.AI.DocumentIntelligence;

 

string endpoint = "<endpoint>";

string key = "<access-key>";

AzureKeyCredential cred = new AzureKeyCredential(key);

DocumentIntelligenceClient client = new DocumentIntelligenceClient (new Uri(endpoint), cred);

 

Uri fileUri = new Uri ("<url-of-document-to-analyze>");

 

var content = new AnalyzeDocumentContent()

{

    UrlSource = fileUri

};
