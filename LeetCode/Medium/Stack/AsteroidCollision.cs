namespace LeetCode.Medium.Stack;

public class SolutionAsteroidCollision
{
    public int[] AsteroidCollision(int[] asteroids)
    {
        var st = new Stack<int>();

        foreach (var a in asteroids)
        {
            var curr = a;
            var alive = true;

            // Столкновения только при "вправо" (в стеке сверху) и "влево" (текущий)
            while (alive && st.Count > 0 && st.Peek() > 0 && curr < 0)
            {
                var top = st.Peek();
                var at = Math.Abs(top);
                var ac = Math.Abs(curr);

                if (at < ac)
                {
                    // верх стека меньше — он взрывается, продолжаем биться дальше
                    st.Pop();
                    continue;
                }
                else if (at == ac)
                {
                    // одинаковые — оба взрываются
                    st.Pop();
                    alive = false; // текущий тоже исчез
                }
                else
                {
                    // верх стека больше — текущий исчезает
                    alive = false;
                }
            }

            if (alive) st.Push(curr);
        }

        return st.Reverse().ToArray();
    }
}