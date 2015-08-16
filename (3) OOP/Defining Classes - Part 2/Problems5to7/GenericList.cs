using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems5to7
{
    class GenericList<T>
        where T : IComparable
    {
        private T[] genericList;
        private int occupiedPositions;

        public GenericList(int capacity)
        {
            try
            {
                if (capacity > 0)
                {
                    this.occupiedPositions = 0;
                    this.genericList = new T[capacity];
                }
                else
                {
                    Console.WriteLine("The capacity of the list should be integer grater than 0!");
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("The capacity should be positive integer number!");
            } 
                
        }

        // adding element
        public void AddElement(T element)
        {
            try
            {

                if (this.occupiedPositions == this.genericList.Length)
                {
                    T[] newGenericList = new T[this.genericList.Length];
                    for (int i = 0; i < newGenericList.Length; i++)
                    {
                        newGenericList[i] = this.genericList[i];
                    }
                    this.genericList = new T[newGenericList.Length * 2];
                    for (int i = 0; i < newGenericList.Length; i++)
                    {
                        this.genericList[i] = newGenericList[i];
                    }
                }
                this.genericList[occupiedPositions] = element;
                this.occupiedPositions++;
            }
            catch (FormatException)
            {
                throw new FormatException("The type of the input element should be the same as the items in the list!");
            } 
        }
        
        
        // accessing element by index
        public T AccessElement(int index)
        {
            try
            {
                T result = this.genericList[index];
                return result;
            }
            catch (FormatException)
            {
                throw new FormatException("The index should be a positive integer or 0!");
            } 
            catch (IndexOutOfRangeException)
            {
                throw new IndexOutOfRangeException("The list does not have such an index!");
            }
        }
        
        
        // removing element by index
        public void AddElement(int index)
        {
            try
            {
                if (index < this.occupiedPositions)
                {
                    for (int i = index; i < this.occupiedPositions - 1; i++)
                    {
                        this.genericList[index] = this.genericList[index + 1];
                    }
                    this.genericList[occupiedPositions - 1] = default(T);
                    occupiedPositions--;
                }
                else
                {
                    throw new IndexOutOfRangeException("The list does not have such an index!");
                }
            }
            catch (FormatException)
            {
                throw new FormatException("The index should be a positive integer or 0!");
            }
            catch (IndexOutOfRangeException)
            {
                throw new IndexOutOfRangeException("The list does not have such an index!");
            }
        }
        
        // inserting element at given position

        public void InsertElement(T element, int index)
        {
            try
            {
                if (index >= this.occupiedPositions)
                {
                    throw new IndexOutOfRangeException("The list does not have such an index!");
                }
                else
                {
                    if (this.occupiedPositions == this.genericList.Length)
                    {
                        T[] newGenericList = new T[this.genericList.Length];
                        for (int i = 0; i < newGenericList.Length; i++)
                        {
                            newGenericList[i] = this.genericList[i];
                        }
                        this.genericList = new T[newGenericList.Length * 2];
                        for (int i = 0; i < newGenericList.Length; i++)
                        {
                            this.genericList[i] = newGenericList[i];
                        }
                    }
                    for (int i = this.occupiedPositions; i > index; i--)
                    {
                        this.genericList[i] = this.genericList[i - 1];
                    }
                    this.genericList[index] = element;
                    this.occupiedPositions++;
                }
            }
            catch (FormatException)
            {
                throw new FormatException("The type of the input element should be the same as the items in the list and the type of the index should be positive integer or 0!");
            }
            catch (IndexOutOfRangeException)
            {
                throw new IndexOutOfRangeException("The list does not have such an index!");
            }
        }
        
        
        // clearing the list

        public void Clear()
        {
            for (int i = 0; i < this.occupiedPositions; i++)
            {
                this.genericList[i] = default(T);
            }
            occupiedPositions = 0;
        }
        
           
        // finding element by its value
        public List<int> FindByValue(T value)
        {
            try
            {
                var result = new List<int>();
                for (int i = 0; i < this.occupiedPositions; i++)
                {
                    if (this.genericList[i].Equals(value))
                    {
                        result.Add(i);
                    }
                }
                return result;
            }
            catch (FormatException)
            {

                throw new FormatException("The type of the input element should be the same as the items in the list!");
            }
        }
            
        
        
        // ToString()
        public override string ToString()
        {
            StringBuilder temp = new StringBuilder();
            foreach (T item in this.genericList)
            {
                temp.Append(item);
            }
            return temp.ToString();
        }

        public T Max()
        {
            T result = default(T);
            if (this.occupiedPositions > 0)
            {
                result = this.genericList[0];

                for (int i = 1; i < this.occupiedPositions; i++)
                {
                    if (result.CompareTo(this.genericList[i]) < 0)
                    {
                        result = this.genericList[i];
                    }
                }
            }
            return result;
        }


        public T Min()
        {
            T result = default(T);
            if (this.occupiedPositions > 0)
            {
                result = this.genericList[0];

                for (int i = 1; i < this.occupiedPositions; i++)
                {
                    if (result.CompareTo(this.genericList[i]) < 0)
                    {
                        result = this.genericList[i];
                    }
                }
            }
            return result;
        }
    }
}