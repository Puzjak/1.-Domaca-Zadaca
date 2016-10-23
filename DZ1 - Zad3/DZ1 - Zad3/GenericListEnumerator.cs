using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ1___Zad3
{
    class GenericListEnumerator<X> : IEnumerator<X> 
    {

        private X[] _collection;
        private int curIndex;

        
        

        public GenericListEnumerator(X[] collection)
        {
            _collection = collection;
            curIndex = -1;
            
        }
        
        public bool MoveNext()
        {
            curIndex++;
            return (curIndex >= _collection.Length) ? false : true;
                         
        }

        public X Current
        {
            get
            {
                return _collection[curIndex];
            }
        }


        object IEnumerator.Current
        {
            get
            {
                return Current;
            }
        }


        public void Reset() { curIndex = -1; }

        void IDisposable.Dispose() { }

        
    }
}
