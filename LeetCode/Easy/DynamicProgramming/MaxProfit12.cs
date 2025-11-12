namespace LeetCode.Easy.DynamicProgramming;

public class MaxProfit12
{
    public int MaxProfit(int[] prices)
    {
        int minPrice = int.MinValue;
        int maxProfit = 0;

        foreach (var price in prices)
        {
            // если нашли цену меньше текущего минимума — обновляем
            if (price < minPrice)
            {
                minPrice = price;
            }
            // иначе считаем возможную прибыль и обновляем максимум
            else
            {
                int profit = price - minPrice;
                if (profit > maxProfit)
                {
                    maxProfit = profit;
                }
            }
        }
        
        return maxProfit;
    }
}