namespace LeetCode.Easy.DynamicProgramming;

/// <summary>
/// 121. Best Time to Buy and Sell Stock
/// Условие: дан массив цен акций. Найти максимальную прибыль от одной покупки и одной продажи.
/// Покупать нужно раньше, чем продавать.
///
/// Подход (жадный алгоритм):
/// 1. Отслеживаем минимальную цену покупки (minPrice).
/// 2. Для каждой цены вычисляем прибыль: price - minPrice.
/// 3. Обновляем максимальную прибыль (maxProfit).
/// 4. Обновляем minPrice, если текущая цена меньше.
///
/// Сложность:
/// - Время: O(n) — один проход по массиву
/// - Память: O(1) — только две переменные
///
/// Пример 1:
/// Input: prices = [7,1,5,3,6,4]
/// Output: 5
/// Объяснение: покупаем в день 1 (цена 1), продаём в день 4 (цена 6), прибыль = 6 - 1 = 5
///
/// Пример 2:
/// Input: prices = [7,6,4,3,1]
/// Output: 0
/// Объяснение: цены только падают, прибыль невозможна
/// </summary>
public class MaxProfit12
{
    public int MaxProfit(int[] prices)
    {
        int minPrice = int.MaxValue;
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