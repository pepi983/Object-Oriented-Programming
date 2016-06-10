namespace DefiningClassesPart2
{
    using System;

    public class GenericList<T> 
        where T : IComparable
    {
        private const int StartingDefaultCapacity = 8;
        private T[] array;
        private int capacity;
        private int count;

        public GenericList()
        {
            this.Capacity = StartingDefaultCapacity;
            this.Count = 0;
            array = new T[Capacity];
        }

        public GenericList(int capacity)
        {
            this.Capacity = capacity;
            this.Count = 0;
            array = new T[Capacity];
        }

        public int Capacity
        {
            get
            {
                return this.capacity;
            }
            private set
            {
                if (value >= 0)
                {
                    this.capacity = value;
                }
                else
                {
                    throw new ArgumentException("The capacity cannot be less than 0!");
                }
            }
        }

        public int Count
        {
            get
            {
                return this.count;
            }
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentException("The length of the list cannot be less than 0!");
                }
                else
                {
                    this.count = value;
                }
            }
        }

        public T this[int index]
        {
            get
            {
                if (index < this.Count && index >= 0)
                {
                    return this.array[index];
                }
                else
                {
                    throw new ArgumentException("Index out of range");
                }
            }
            set
            {
                if (index < this.Count && index >= 0)
                {
                    this.array[index] = value;
                }
                else
                {
                    throw new ArgumentException("Index out of range");
                }
            }
        }

        public void Add(T item)
        {
            this.Count++;

            if (this.Count >= this.Capacity)
            {
                DoubleSize();
            }

            this.array[this.Count - 1] = item;
        }

        public void RemoveByIndex(int index)
        {
            if (index >= this.Count || index < 0)
            {
                throw new ArgumentException("Index is out of Range!");
            }

            var oldElements = this.array;
            this.array = new T[Capacity];
            int arrIndex = 0;
            for (int i = 0; i < this.Count; i++)
            {
                if (i != index)
                {
                    array[arrIndex] = oldElements[i];
                    arrIndex++;
                }
            }
            this.Count--;
        }

        public void Insert(int position, T item)
        {
            if (position > this.Count || position < 0)
            {
                throw new ArgumentException("Index is out of Range!");
            }

            this.Count++;
            if (Count >= this.Capacity)
            {
                DoubleSize();
            }

            var oldElements = this.array;
            this.array = new T[Capacity];
            int arrIndex = 0;
            int copyIndex = 0;
            for (int i = 0; i < this.Count; i++)
            {
                if (i != position)
                {
                    array[arrIndex] = oldElements[copyIndex];
                    arrIndex++;
                    copyIndex++;
                }
                else
                {
                    array[arrIndex] = item;
                    arrIndex++;
                }
            }
        }

        public void Clear()
        {
            this.Capacity = StartingDefaultCapacity;
            this.array = new T[this.Capacity];
            this.Count = 0;
        }

        /// <summary>
        /// Searches the list for the value and returns its index or if the list doesnt contains the item returns -1
        /// </summary>
        /// <param name=""></param>
        /// <returns></returns>
        public int Find(T itemToFind)
        {
            for (int i = 0; i < this.Count; i++)
            {
                if (array[i].CompareTo(itemToFind) == 0)
                {
                    return i;
                }
            }
            return -1;
        }

        private void DoubleSize()
        {
            var oldElements = this.array;
            this.Capacity *= 2;
            this.array = new T[Capacity];
            Array.Copy(oldElements, this.array, this.Count);
        }

        public T Min()
        {
            T minEl = array[0];
            for (int i = 0; i < this.Count; i++)
            {
                if (minEl.CompareTo(array[i]) > 0)
                {
                    minEl = array[i];
                }
            }
            return minEl;
        }

        public T Max()
        {
            T maxEl = array[0];
            for (int i = 0; i < this.Count; i++)
            {
                if (maxEl.CompareTo(array[i]) < 0)
                {
                    maxEl = array[i];
                }
            }
            return maxEl;
        }

        public override string ToString()
        {
            string res = "";
            for (int i = 0; i < this.Count; i++)
            {
                res += array[i];
                if (i < this.Count-1)
                {
                    res += " ";
                }
            }
            return res;
        }
    }
}
