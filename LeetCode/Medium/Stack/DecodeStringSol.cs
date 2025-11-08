using System.Text;

namespace LeetCode.Medium.Stack;

public class DecodeStringSol
{
    public string DecodeString(string s)
    {
        var st = new Stack<char>();

        for (int i = s.Length - 1; i >= 0; i--)
        {
            char ch = s[i];

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
                int j = i - 1;
                while (j >= 0 && char.IsDigit(s[j]))
                {
                    num += (s[j] - '0') * place; // справа-налево
                    place *= 10;
                    j--;
                }

                // пропустить прочитанные цифры
                i = j + 1;

                // 3) положить сегмент num раз в СТЕК В ОБРАТНОМ порядке
                string chunk = seg.ToString();
                for (int r = 0; r < num; r++)
                {
                    for (int k = chunk.Length - 1; k >= 0; k--)
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