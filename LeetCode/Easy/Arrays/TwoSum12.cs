namespace LeetCode.Easy.Arrays;

public class TwoSum1
{
    public int[] TwoSum(int[] nums, int target)
    {
        // Словарь: число -> индекс
        var map = new Dictionary<int, int>();

        for (int i = 0; i < nums.Length; i++)
        {
            int complement = target - nums[i]; // число, которое нужно найти
            
            // Если в словаре уже есть нужное число — возвращаем индексы
            if (map.ContainsKey(complement))
            {
                return [map[complement], i];
            }
            
            // Иначе добавляем текущее число в словарь
            map[nums[i]] = i;
        }

        // По условию задачи всегда есть одно решение
        return [];
    }
}