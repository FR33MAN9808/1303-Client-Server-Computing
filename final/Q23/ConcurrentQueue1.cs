using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q23
{
    public class ConcurrentQueue<T>
    {
        private T[] queue;
        private int head;
        private int tail;
        private int count;
        private int maxLength;

        public ConcurrentQueue(int maxLength)
        {
            this.maxLength = maxLength;
            queue = new T[maxLength];
            head = 0;
            tail = 0;
            count = 0;
        }

        public void Enqueue(T item)
        {
            lock (queue)
            {
                while (count == maxLength)
                {
                    // Queue is full, wait for dequeue operation
                    Monitor.Wait(queue);
                }

                queue[tail] = item;
                tail = (tail + 1) % maxLength;
                count++;

                Monitor.PulseAll(queue);
            }
        }

        public T Dequeue()
        {
            lock (queue)
            {
                while (count == 0)
                {
                    // Queue is empty, wait for enqueue operation
                    Monitor.Wait(queue);
                }

                T item = queue[head];
                queue[head] = default(T);
                head = (head + 1) % maxLength;
                count--;

                Monitor.PulseAll(queue);
                return item;
            }
        }

        public int GetCurrentLength()
        {
            lock (queue)
            {
                return count;
            }
        }

        public T Peek()
        {
            lock (queue)
            {
                if (count == 0)
                    throw new InvalidOperationException("Queue is empty");

                return queue[head];
            }
        }
    }
}
