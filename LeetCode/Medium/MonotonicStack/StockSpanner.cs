namespace LeetCode.Medium.MonotonicStack;

// [28],[14],[28],[35],[46],[53],[66],[80],[87],[88]
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

/**
 * Your StockSpanner object will be instantiated and called as such:
 * StockSpanner obj = new StockSpanner();
 * int param_1 = obj.Next(price);
 */