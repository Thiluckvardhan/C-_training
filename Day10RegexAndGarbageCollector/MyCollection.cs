using System;
using System.Collections;
using System.Collections.Generic;

namespace Day10
{
    public class MyCollection : IList
    {
        private readonly List<object?> _items = new List<object?>();

        public object? this[int index]
        {
            get => _items[index];
            set => _items[index] = value;
        }

        public bool IsFixedSize => false;
        public bool IsReadOnly => false;
        public int Count => _items.Count;
        public bool IsSynchronized => false;
        public object SyncRoot => this;

        public int Add(object? value)
        {
            _items.Add(value);
            return _items.Count - 1;
        }

        public void Clear()
        {
            _items.Clear();
        }

        public bool Contains(object? value)
        {
            return _items.Contains(value);
        }

        public void CopyTo(Array array, int index)
        {
            ((ICollection)_items).CopyTo(array, index);
        }

        public IEnumerator GetEnumerator()
        {
            return _items.GetEnumerator();
        }

        public int IndexOf(object? value)
        {
            return _items.IndexOf(value);
        }

        public void Insert(int index, object? value)
        {
            _items.Insert(index, value);
        }

        public void Remove(object? value)
        {
            _items.Remove(value);
        }

        public void RemoveAt(int index)
        {
            _items.RemoveAt(index);
        }
    }
}
