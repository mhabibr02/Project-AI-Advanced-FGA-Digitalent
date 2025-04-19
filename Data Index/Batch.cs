public static async Task TestBatchSizesAsync(SearchClient searchClient, int min = 100, int max = 1000, int step = 100, int numTries = 3)

{

    DataGenerator dg = new DataGenerator();

 

    Console.WriteLine("Batch Size \t Size in MB \t MB / Doc \t Time (ms) \t MB / Second");

    for (int numDocs = min; numDocs <= max; numDocs += step)

    {

        List<TimeSpan> durations = new List<TimeSpan>();

        double sizeInMb = 0.0;

        for (int x = 0; x < numTries; x++)

        {

            List<Hotel> hotels = dg.GetHotels(numDocs, "large");

 

            DateTime startTime = DateTime.Now;

            await UploadDocumentsAsync(searchClient, hotels).ConfigureAwait(false);

            DateTime endTime = DateTime.Now;

            durations.Add(endTime - startTime);

 

            sizeInMb = EstimateObjectSize(hotels);

        }

 

        var avgDuration = durations.Average(timeSpan => timeSpan.TotalMilliseconds);

        var avgDurationInSeconds = avgDuration / 1000;

        var mbPerSecond = sizeInMb / avgDurationInSeconds;

 

        Console.WriteLine("{0} \t\t {1} \t\t {2} \t\t {3} \t {4}", numDocs, Math.Round(sizeInMb, 3), Math.Round(sizeInMb / numDocs, 3), Math.Round(avgDuration, 3), Math.Round(mbPerSecond, 3));

 

        // Pausing 2 seconds to let the search service catch its breath

        Thread.Sleep(2000);

    }

 

    Console.WriteLine();

}
