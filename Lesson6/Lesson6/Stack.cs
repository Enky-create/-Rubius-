using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson6
{
    internal class Stack<T>
    {
        private List<T> objects = new List<T>();
        public void Push(T obj) 
        { 
            objects.Add(obj);
        }
        public T Pop()
        {
            if (objects.Count == 0)
            {
                throw new Exception();
            }
            var result = objects.Last();
            objects.RemoveAt(objects.Count-1);
            return result;
        }
        public T Peek()
        {
            if (objects.Count == 0)
            {
                throw new Exception();
            }
            return objects.Last();
        }
        public void Clear()
        {
            objects.Clear();
        }
        public bool IsEmpty()
        {
            return objects.Count == 0;
        }
    }
}
