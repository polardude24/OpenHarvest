﻿using System.Collections;
using System.Collections.Generic;

class SlidingBuffer<T> : IEnumerable<T>
{
    private readonly Queue<T> _queue;
    private readonly int _maxCount;

    public SlidingBuffer(int maxCount)
    {
        _maxCount = maxCount;
        _queue = new Queue<T>(maxCount);
    }

    public void Add(T item)
    {
        if (_queue.Count == _maxCount)
            _queue.Dequeue();
        _queue.Enqueue(item);
    }

    public bool Contains(T item)
    {
        return _queue.Contains(item);
    }

    public int Count()
    {
        return _queue.Count;
    }

    public IEnumerator<T> GetEnumerator()
    {
        return _queue.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}