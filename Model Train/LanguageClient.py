language_client = TextAnalyticsClient(

            endpoint=endpoint,

            credential=credentials)

response = language_client.extract_key_phrases(documents = documents)[0]
