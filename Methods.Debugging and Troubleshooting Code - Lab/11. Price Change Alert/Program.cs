using System;

class PriceChangeAlert
{
    static void Main()
    {
        int numberPrice = int.Parse(Console.ReadLine());
        double significanceThreshold = double.Parse(Console.ReadLine());
        double currentPrice = double.Parse(Console.ReadLine());

        for (int i = 0; i < numberPrice - 1; i++)
        {
            double nextPrice = double.Parse(Console.ReadLine());
            double difference = Procent(currentPrice, nextPrice);
            bool isSignificantDifference = IsSignificantDifference(difference, significanceThreshold);



            string message = Get(nextPrice, currentPrice, difference, isSignificantDifference);
            Console.WriteLine(message);

            currentPrice = nextPrice;
        }
    }

    private static string Get(double nextPrice, double currentPrice, double difference, bool isSignificantDifference)
    {
        string message = "";
        if (difference == 0)
        {
            message = string.Format("NO CHANGE: {0}", nextPrice);
        }
        else if (!isSignificantDifference)
        {
            message = string.Format("MINOR CHANGE: {0} to {1} ({2:F2}%)", currentPrice, nextPrice, difference * 100);
        }
        else if (isSignificantDifference && (difference > 0))
        {
            message = string.Format("PRICE UP: {0} to {1} ({2:F2}%)", currentPrice, nextPrice, difference * 100);
        }
        else if (isSignificantDifference && (difference < 0))
        {
            message = string.Format("PRICE DOWN: {0} to {1} ({2:F2}%)", currentPrice, nextPrice, difference * 100);

        }
        return message;

    }
    private static bool IsSignificantDifference(double difference, double isSignificantDifference)
    {
        if (Math.Abs(difference) >= isSignificantDifference)
        {
            return true;
        }
        return false;
    }

    private static double Procent(double currentPrice, double nextPrice)
    {
        double procent = (nextPrice - currentPrice) / currentPrice;
        return procent;
    }
}
