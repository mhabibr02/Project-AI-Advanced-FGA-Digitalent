using Azure.AI.Vision.ImageAnalysis;

ImageAnalysisClient client = new ImageAnalysisClient(
    Environment.GetEnvironmentVariable("ENDPOINT"),
    new AzureKeyCredential(Environment.GetEnvironmentVariable("KEY")));

ImageAnalysisResult result = client.Analyze(
    new Uri("<url>"),
    VisualFeatures.Caption | VisualFeatures.Read,
    new ImageAnalysisOptions { GenderNeutralCaption = true });
