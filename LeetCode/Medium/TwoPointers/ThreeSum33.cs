namespace LeetCode.Medium.TwoPointers;

public class ThreeSum33
{
    public IList<IList<int>> ThreeSum(int[] nums)
    {
        // Результат: список троек
        var result = new List<IList<int>>();
        
        // 1. Сортируем массив, чтобы удобно двигать два указателя
        Array.Sort(nums);
        
        // 2. Фиксируем первый элемент тройки по индексу i
        for (int i = 0; i < nums.Length - 2; i++)
        {
            // Если текущий элемент такой же, как предыдущий,
            // то такую тройку мы уже рассматривали — пропускаем, чтобы не было дублей
            if (i > 0 && nums[i] == nums[i - 1])
                continue;
            
            int left = i + 1;              // левый указатель
            int right = nums.Length - 1;   // правый указатель

            // 3. Двигаем два указателя, пока они не пересекутся
            while (left < right)
            {
                int sum = nums[i] + nums[left] + nums[right];

                if (sum == 0)
                {
                    // Нашли подходящую тройку
                    result.Add(new List<int> { nums[i], nums[left], nums[right] });

                    // Запоминаем значения на left и right,
                    // чтобы потом пропустить все дубликаты этих чисел
                    int leftVal = nums[left];
                    int rightVal = nums[right];

                    // Пропускаем все одинаковые значения слева
                    while (left < right && nums[left] == leftVal)
                        left++;

                    // Пропускаем все одинаковые значения справа
                    while (left < right && nums[right] == rightVal)
                        right--;
                }
                else if (sum < 0)
                {
                    // Сумма слишком маленькая → нужно увеличить
                    // двигаем левый указатель вправо
                    left++;
                }
                else
                {
                    // Сумма слишком большая → нужно уменьшить
                    // двигаем правый указатель влево
                    right--;
                }
            }
        }
        
        return result;
    }
}