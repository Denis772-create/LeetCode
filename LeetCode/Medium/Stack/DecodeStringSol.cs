using System.Text;

namespace LeetCode.Medium.Stack;

/// <summary>
/// 394. Decode String
/// Условие: раскодировать строку вида "k[encoded_string]", где k — число повторений.
/// Могут быть вложенные структуры.
///
/// Подход (стек, обработка справа налево):
/// 1. Проходим строку справа налево.
/// 2. При встрече '[':
///    - Извлекаем сегмент до ближайшей ']'.
///    - Читаем число слева от '['.
///    - Повторяем сегмент указанное число раз и кладём обратно в стек.
/// 3. Остальные символы просто добавляем в стек.
///
/// Сложность:
/// - Время: O(n * m), где n — длина строки, m — максимальное число повторений
/// - Память: O(n) — для стека
///
/// Пример 1:
/// Input: s = "3[a]2[bc]"
/// Output: "aaabcbc"
/// Объяснение: "a" повторяется 3 раза, "bc" повторяется 2 раза
///
/// Пример 2:
/// Input: s = "3[a2[c]]"
/// Output: "accaccacc"
/// Объяснение: сначала раскрываем "2[c]" → "cc", затем "3[acc]" → "accaccacc"
///
/// Пример 3:
/// Input: s = "2[abc]3[cd]ef"
/// Output: "abcabccdcdcdef"
/// </summary>
public class DecodeStringSol
{
    public string DecodeString(string s)
    {
        var st = new Stack<char>();

        for (var i = s.Length - 1; i >= 0; i--)
        {
            var ch = s[i];

            if (ch == '[')
            {
                // 1) снять сегмент до ближайшей ']'
                var seg = new StringBuilder();
                while (st.Count > 0 && st.Peek() != ']')
                {
                    seg.Append(st.Pop());
                }

                if (st.Count > 0)
                {
                    st.Pop(); // убрать ']'
                }

                // 2) считать число слева от '[' (идём левее)
                int num = 0, place = 1;
                var j = i - 1;
                while (j >= 0 && char.IsDigit(s[j]))
                {
                    num += (s[j] - '0') * place; // справа-налево
                    place *= 10;
                    j--;
                }

                // пропустить прочитанные цифры
                i = j + 1;

                // 3) положить сегмент num раз в СТЕК В ОБРАТНОМ порядке
                var chunk = seg.ToString();
                for (var r = 0; r < num; r++)
                {
                    for (var k = chunk.Length - 1; k >= 0; k--)
                    {
                        st.Push(chunk[k]);
                    }
                }
            }
            else if (char.IsDigit(ch))
            {
                // цифры пропускаем — они обрабатываются только вместе с '['
                continue;
            }
            else
            {
                // буква или ']'
                st.Push(ch);
            }
        }

        // 4) собираем результат слева направо: просто снимаем со стека
        var res = new StringBuilder(st.Count);
        while (st.Count > 0)
        {
            res.Append(st.Pop());
        }

        return res.ToString();
    }
}