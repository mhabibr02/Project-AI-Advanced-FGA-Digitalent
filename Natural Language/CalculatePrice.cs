static Dictionary<string, double> itemPrices = new Dictionary<string, double>() 

{ 

    {"apple", 0.5}, 

    {"banana", 0.75}, 

    {"orange", 0.6} 

}; 

 

static double CalculateTotalPrice(string item, int quantity) 

{ 

    double price; 

    if (!itemPrices.TryGetValue(item, out price)) 

    { 

        price = 0; 

    } 

    return quantity * price; 

}

