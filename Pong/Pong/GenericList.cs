using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Pong
{
    class GenericList<X> : IGenericList<X>
    {
        private X[] _internalStorage;

        private const int _defaultInitSize = 4;

        private int _numberOfElements;

        public void initList()
        {
            _internalStorage = new X[_defaultInitSize];
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
                _internalStorage = new X[initialSize];
                _numberOfElements = 0;
            }
        }

        public void Add(X item)
        {
            if (_internalStorage == null) initList();
            if (_numberOfElements == _internalStorage.Length)
                Array.Resize(ref _internalStorage, (_internalStorage.Length * 2));
            _internalStorage[_numberOfElements] = item;
            _numberOfElements++;
        }

        public bool RemoveAt(int index)
        {
            if ((index >= _numberOfElements) || index < 0)
                return false;
            if (!(_internalStorage.Contains(GetElement(index))))
                return false;
            for (; index < (_numberOfElements - 1); index++)
                _internalStorage[index] = _internalStorage[index + 1];
            _numberOfElements--;
            return true;
        }

        public bool Remove(X item)
        {
            return RemoveAt(IndexOf(item));
        }



        public X GetElement(int index)
        {
            if (index < _numberOfElements)
                return _internalStorage[index];
            else
                throw new IndexOutOfRangeException("Index is out of range");
        }

        public int IndexOf(X item)
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

        public bool Contains(X item)
        {
            return IndexOf(item) == -1 ? false : true;
        }
    }
}


