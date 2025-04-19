string endpoint = "<endpoint>";

string apiKey = "<apiKey>";

var credential = new AzureKeyCredential(apiKey);

var client = new DocumentModelAdministrationClient(new Uri(endpoint), credential);

List<string> modelIds = new List<string>()

{

    firstCustomModel.ModelId,

    secondCustomModel.ModelId,

    thirdCustomModel.ModelId,

};

 

BuildModelOperation operation = await client.StartCreateComposedModelAsync(modelIds, modelDescription: "Composed model example");

Response<DocumentModel> operationResponse = await operation.WaitForCompletionAsync();
