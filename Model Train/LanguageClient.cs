var languageClient = new TextAnalyticsClient(endpoint, credentials);

var response = languageClient.ExtractKeyPhrases(document);
