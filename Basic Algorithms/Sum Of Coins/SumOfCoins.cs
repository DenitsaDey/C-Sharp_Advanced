using System;
using System.Collections.Generic;
using System.Linq;

public class SumOfCoins
{
    public static void Main(string[] args)
    {
        var availableCoins = Console.ReadLine()
            .Split(new char[] { ' ', ':', ',' }, StringSplitOptions.RemoveEmptyEntries)
            .Skip(1)
            .Select(int.Parse)
            .ToArray();
        var targetSum = Console.ReadLine()
            .Split(new char[] { ' ', ':', ',' }, StringSplitOptions.RemoveEmptyEntries)
            .Skip(1)
            .Select(int.Parse)
            .ToArray();

        if (availableCoins.Where(x => x == 1 || x == 2 || x == 5 || x == 10 || x == 20 || x == 50).Count() == 0)
        {
            Console.WriteLine("Error");
            return;
        }

        var selectedCoins = ChooseCoins(availableCoins, targetSum[0]);

        Console.WriteLine($"Number of coins to take: {selectedCoins.Values.Sum()}");
        foreach (var selectedCoin in selectedCoins)
        {
            Console.WriteLine($"{selectedCoin.Value} coin(s) with value {selectedCoin.Key}");
        }
    }

    public static Dictionary<int, int> ChooseCoins(IList<int> coins, int targetSum)
    {
        List<int> sortedCoins = coins.OrderByDescending(x => x).ToList();

        Dictionary<int, int> ChooseCoins = new Dictionary<int, int>();
        int remainingSum = targetSum;

        for (int i = 0; i < sortedCoins.Count; i++)
        {
            int NumOfCurrCoins = 0;
            NumOfCurrCoins = remainingSum / sortedCoins[i];
            if(NumOfCurrCoins != 0)
            {
                ChooseCoins.Add(sortedCoins[i], NumOfCurrCoins);
            }
            remainingSum -= NumOfCurrCoins * sortedCoins[i];
            if(remainingSum == 0)
            {
                break;
            }
        }

        return ChooseCoins;
    }
}