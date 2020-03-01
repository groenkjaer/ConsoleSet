using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace ConsoleSet
{
    class MySet<T> : ISet<T>
    {
        private List<T> list = new List<T>();

        public int Count
        {
            get { return list.Count; }
        }

        public void Add(T item)
        {
            list.Add(item);
        }

        public void Sort()
        {
            list.Sort();
        }

        public void AddRange(IEnumerable<T> collection)
        {
            list.AddRange(collection);
        }

        public void Remove(T item)
        {
            list.Remove(item);
        }

        public ISet<T> Intersect(ISet<T> S)
        {
            MySet<T> temp = new MySet<T>();

            foreach (var item in list)
            {
                foreach (var secondItem in list)
                {
                    if (item.Equals(secondItem))
                    {
                        temp.Add(item);
                    }
                }
            }
            return temp as MySet<T>;
        }

        public ISet<T> Difference(ISet<T> S)
        {
            list.AddRange(S);
            list.Sort();
            list = list.Distinct().ToList();
            return list as MySet<T>;
        }

        public ISet<T> Union(ISet<T> S)
        {
            AddRange(S);
            Sort();
            list = list.Distinct().ToList();
            return list as MySet<T>;
        }

        void ISet<T>.Remove(T elem)
        {
            Remove(elem);
        }

        public bool Contains(T elem)
        {
            throw new NotImplementedException();
        }

        public IEnumerator<T> GetEnumerator()
        {
            return list.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
