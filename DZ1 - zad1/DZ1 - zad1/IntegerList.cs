using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DZ1___zad1
{
    public class IntegerList : IIntegerList
    {
        private int[] _internalStorage;

        private const int _defaultInitSize = 4;

        private int _numberOfElements;

        public void initList()
        {
            _internalStorage = new int[_defaultInitSize];
            _numberOfElements = 0;
        }

        public void initList(int initialSize)
        {
            if (initialSize <= 0)
            {
                Console.WriteLine("Initial size must be greather then zero!");
            }
            else
            {
                _internalStorage = new int[initialSize];
                _numberOfElements = 0;
            }
        }

        public void Add(int item)
        {

            if (_internalStorage == null) initList();
            int i = Array.IndexOf(_internalStorage, 0);
            if (i == -1)
            {
                i = _internalStorage.Length;
                Array.Resize(ref _internalStorage, (_internalStorage.Length * 2));
            }
            _internalStorage[i] = item;
            _numberOfElements++;
        }

        public bool  RemoveAt(int index)
        {
            if ((index >= _internalStorage.Length) || index == -1)
                return false;
            if ((int)_internalStorage.GetValue(index) ==  0)
                return false;
            for (; index < _numberOfElements - 1; index++)
                _internalStorage[index] = _internalStorage[index + 1];
            _internalStorage[index] = 0;
            _numberOfElements--;
            return true;
        }

        public bool Remove(int item)
        {
            int index = IndexOf(item);
            return RemoveAt(index);
        }

        

        public int GetElement(int index)
        {
            if (index < _internalStorage.Length)
                return (int)_internalStorage.GetValue(index);
            else
                throw new IndexOutOfRangeException("Index is out of range");
        }

        public int IndexOf(int item)
        {
            return Array.IndexOf(_internalStorage, item);
        }

        public int Count
        {
            get
            {
                return _numberOfElements;
            }
        }
        
        public void Clear()
        {
            _internalStorage = null;
            _numberOfElements = 0;
        }

        public bool Contains(int item)
        {
            return IndexOf(item) == -1 ? false : true;
        }

        static public void ListExample(IIntegerList listOfIntegers)
        {
            listOfIntegers.Add(1); // [1]
            listOfIntegers.Add(2); // [1 ,2]
            listOfIntegers.Add(3); // [1 ,2 ,3]
            listOfIntegers.Add(4); // [1 ,2 ,3 ,4]
            listOfIntegers.Add(5); // [1 ,2 ,3 ,4 ,5]
            listOfIntegers.RemoveAt(0); // [2 ,3 ,4 ,5]
            listOfIntegers.Remove(5); // [2 ,3 ,4]
            Console.WriteLine(listOfIntegers.Count); // 3
            Console.WriteLine(listOfIntegers.Remove(100)); // false
            Console.WriteLine(listOfIntegers.RemoveAt(5)); // false
            listOfIntegers.Clear(); // []
            Console.WriteLine(listOfIntegers.Count); // 0
        }

    }
}
