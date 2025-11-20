namespace LeetCode.Easy.Stack;

/// <summary>
/// 20. Valid Parentheses
/// Условие: проверить, правильно ли расставлены скобки в строке. Скобки: '()', '[]', '{}'.
///
/// Подход (стек):
/// 1. Используем стек для хранения открывающих скобок.
/// 2. Если встречаем открывающую скобку → добавляем в стек.
/// 3. Если встречаем закрывающую скобку:
///    - Если стек пуст → невалидно.
///    - Если верх стека не соответствует закрывающей скобке → невалидно.
///    - Иначе извлекаем из стека.
/// 4. В конце стек должен быть пуст.
///
/// Сложность:
/// - Время: O(n) — один проход по строке
/// - Память: O(n) — для стека в худшем случае
///
/// Пример 1:
/// Input: s = "()"
/// Output: true
///
/// Пример 2:
/// Input: s = "()[]{}"
/// Output: true
///
/// Пример 3:
/// Input: s = "(]"
/// Output: false
/// Объяснение: открывающая '(' не соответствует закрывающей ']'
/// </summary>
public class ValidParentheses
{
    public bool IsValid(string s)
    {
        var stack = new Stack<char>();

        foreach (var c in s)
        {
            if (c is '(' or '[' or '{')
            {
                stack.Push(c);
            }
            else
            {
                if (stack.Count == 0) 
                    return false;
                
                var top = stack.Pop();
                
                switch (c)
                {
                    case ')' when top != '(':
                    case ']' when top != '[':
                    case '}' when top != '{':
                        return false;
                }
            }
        }
        
        return stack.Count == 0;
    }
}