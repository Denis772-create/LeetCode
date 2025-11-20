namespace LeetCode.Medium.MonotonicStack;

/// <summary>
/// 901. Online Stock Span
/// Условие: для каждой цены акции вернуть "span" — количество последовательных дней (включая текущий),
/// в течение которых цена была меньше или равна текущей цене.
///
/// Подход (монотонный стек):
/// 1. Используем стек для хранения пар (цена, span).
/// 2. При добавлении новой цены:
///    - Начинаем с span = 1 (текущий день).
///    - Пока в стеке есть цены <= текущей → добавляем их span к текущему и удаляем из стека.
///    - Кладём (цена, span) в стек.
///
/// Сложность:
/// - Время: O(1) амортизированно на вызов Next
/// - Память: O(n) — для стека
///
/// Пример:
/// StockSpanner spanner = new StockSpanner();
/// spanner.Next(100); // возвращает 1
/// spanner.Next(80);  // возвращает 1
/// spanner.Next(60);  // возвращает 1
/// spanner.Next(70);  // возвращает 2 (60, 70)
/// spanner.Next(60);  // возвращает 1
/// spanner.Next(75);  // возвращает 4 (60, 70, 60, 75)
/// spanner.Next(85);  // возвращает 6 (80, 60, 70, 60, 75, 85)
/// </summary>
public class StockSpanner
{
    // Храним пары (Price, Span) в монотонно невозрастающем по Price стеке.
    private readonly Stack<(int Price, int Span)> _stack = new();
    
    public int Next(int price)
    {
        var span = 1;
        
        (int Price, int Days) current = (price, 1);
        
        // Сливаем все предыдущие блоки, цены которых ≤ текущей,
        // суммируя их накопленный span.
        while (_stack.Count > 0 && _stack.Peek().Price <= price)
        {
            span += _stack.Pop().Span;
        }
        
        _stack.Push((price, span));
        return span;
    }
}