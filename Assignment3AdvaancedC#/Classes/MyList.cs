using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3AdvaancedC_.Classes
{
    internal class MyList<T>
    {
        private  List<T> _items = new List<T>();

        public void Add(T item)
        {
            _items.Add(item);
        }

        public bool Exists(Predicate<T> predicate)
        {
            foreach (var item in _items)
            {
                if (predicate(item))
                    return true;
            }
            return false;
        }

        public T Find(Predicate<T> predicate)
        {
            foreach (var item in _items)
            {
                if (predicate(item))
                    return item;
            }
            return default;
        }

        public List<T> FindAll(Predicate<T> predicate)
        {
            List<T> result = new List<T>();
            foreach (T item in _items) 
            {
                if (predicate(item))
                    result.Add(item);
            }
            return result;
        }

        public int FindIndex(Predicate<T> predicate)
        {
            for (int i = 0; i < _items.Count; i++)
            {
                if (predicate(_items[i]))
                {
                    return i;
                }
            }
            return -1;
        }

        public T FindLast(Predicate<T> predicate)
        {
            for (int i = _items.Count - 1; i >= 0; i--)
            {
                if (predicate(_items[i]))
                    return _items[i];
            }
            return default(T);
        }

        public int FindLastIndex(Predicate<T> predicate)
        {
            for (int i = _items.Count - 1; i >= 0; i--)
            {
                if (predicate(_items[i]))
                    return i;
            }
            return -1;
        }

        public void ForEach(Action<T> action)
        {
            foreach (T item in _items)
            {
                action(item);
            }
        }

        public bool TrueForAll(Predicate<T> predicate)
        {
            foreach (T item in _items)
            {
                if (!predicate(item))
                    return false;
            }
            return true;
        }

        public int Count
        {
            get { return _items.Count; }
        }

        // Indexer to access items by index
        public T this[int index]
        {
            get { return _items[index]; }
            set { _items[index] = value; }
        }

        public override string ToString()
        {
            return string.Join(", ", _items);
        }
    }
}
