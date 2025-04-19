endpoint = "YOUR_DOC_INTELLIGENCE_ENDPOINT"

key = "YOUR_DOC_INTELLIGENCE_KEY"

 

model_id = "YOUR_CUSTOM_BUILT_MODEL_ID"

formUrl = "YOUR_DOCUMENT"

 

document_analysis_client = DocumentAnalysisClient(

    endpoint=endpoint, credential=AzureKeyCredential(key)

)

 

# Make sure your document's type is included in the list of document types the custom model can analyze

task = document_analysis_client.begin_analyze_document_from_url(model_id, formUrl)

result = task.result()
