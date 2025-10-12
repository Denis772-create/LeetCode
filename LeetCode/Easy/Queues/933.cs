using System.Collections;

namespace LeetCode.Easy.Queues;

public class RecentCounter
{
    private readonly Queue<int> _q = new();
    
    public RecentCounter() { }

    public int Ping(int t)
    {
        _q.Enqueue(t);
        int left = t - 3000;
        
        while (_q.Count > 0 && _q.Peek() < left)
            _q.Dequeue();
        
        return _q.Count;
    }
}


/*
 * 0. инициализируем пустую очередь
 * 1. поступает время
 * 2. считаем интервал для выборки
 * 3. по одному выкидываем все значеня не попадающие в текщий интервал
*/