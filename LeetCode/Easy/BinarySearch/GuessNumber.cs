namespace LeetCode.Easy.BinarySearch;

/// <summary>
/// 374. Guess Number Higher or Lower
/// Условие: есть число pick в диапазоне [1, n].  
/// Необходимо угадать его, вызывая функцию guess(num):
///  - возвращает -1, если pick меньше num,
///  - возвращает 1, если pick больше num,
///  - возвращает 0, если угадали.
///
/// Подход (бинарный поиск):
/// 1. Устанавливаем границы [1, n].
/// 2. Проверяем середину mid.
/// 3. Если guess(mid) == 0 → нашли ответ.
///    Если 1 → искомое число справа (left = mid + 1).
///    Если -1 → искомое число слева (right = mid - 1).
///
/// Сложность:
/// - Время: O(log n)
/// - Память: O(1)
///
/// Пример:
/// pick = 6, n = 10
/// mid=5 → 5 < 6 → ищем справа
/// mid=8 → 8 > 6 → ищем слева
/// mid=6 → 🎯 нашли!
/// Output: 6
/// </summary>
public class GuessGame
{
    private readonly int pick;
    public GuessGame(int pick) => this.pick = pick;

    // Симулирует API из условия задачи
    protected int guess(int num)
    {
        if (num > pick) return -1; // загаданное число меньше
        if (num < pick) return 1;  // загаданное число больше
        return 0;                  // угадали
    }
}

public class Lc0374GuessNumberHigherOrLower : GuessGame
{
    public Lc0374GuessNumberHigherOrLower(int pick) : base(pick) { }

    public int GuessNumber(int n)
    {
        int left = 1;
        int right = n;

        while (left <= right)
        {
            // 1️⃣ Избегаем переполнения при вычислении середины
            int mid = left + (right - left) / 2;

            // 2️⃣ Проверяем результат
            int res = guess(mid);

            if (res == 0)
                return mid;           // 🎯 нашли загаданное число
            else if (res == 1)
                left = mid + 1;       // pick больше → идём вправо
            else
                right = mid - 1;      // pick меньше → идём влево
        }

        // 3️⃣ Теоретически сюда не дойдём, если pick ∈ [1, n]
        return -1;
    }
}