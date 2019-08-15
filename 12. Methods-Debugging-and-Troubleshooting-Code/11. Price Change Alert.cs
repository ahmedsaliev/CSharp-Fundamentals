using System;

class PriceChangeAlert
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        double significanceThreshold = double.Parse(Console.ReadLine());
        double firstPrice = double.Parse(Console.ReadLine());
        for (int i = 0; i < n - 1; i++)
        {
            double nextPrice = double.Parse(Console.ReadLine());
            double difference = CalculateDifference(firstPrice, nextPrice);
            bool isSignificantDifference = IsDifferenceSignificance(difference, significanceThreshold);
            string message = GetMessage(nextPrice, firstPrice, difference, isSignificantDifference);
            Console.WriteLine(message);
            firstPrice = nextPrice;
        }
    }
    private static string GetMessage(double newPrice, double oldPrice, double priceDifference, bool isSignificanceDifference)
    {
        string messageText = "";
        if (priceDifference == 0)
        {
            messageText = string.Format("NO CHANGE: {0}", newPrice);
        }
        else if (!isSignificanceDifference)
        {
            messageText = string.Format("MINOR CHANGE: {0} to {1} ({2:F2}%)", oldPrice, newPrice, priceDifference * 100);
        }
        else if (isSignificanceDifference && (priceDifference > 0))
        {
            messageText = string.Format("PRICE UP: {0} to {1} ({2:F2}%)", oldPrice, newPrice, priceDifference * 100);
        }
        else if (isSignificanceDifference && (priceDifference < 0))
            messageText = string.Format("PRICE DOWN: {0} to {1} ({2:F2}%)", oldPrice, newPrice, priceDifference * 100);
        return messageText;
    }
    private static bool IsDifferenceSignificance(double threshold, double difference)
    {
        if (Math.Abs(threshold) >= difference)
        {
            return true;
        }
        return false;
    }
    private static double CalculateDifference(double oldPrice, double newPrice)
    {
        double result = (newPrice - oldPrice) / oldPrice;
        return result;
    }
}