public double CalculateTotalPrice(string item, int quantity)

{

if (item == “apple”)

{

        return quantity * 0.5;

}

else if (item == “banana”)

{

        return quantity * 0.75;

}

else if (item == “orange”)

{

        return quantity * 0.6;

}

else

{

        return 0;

}

}
