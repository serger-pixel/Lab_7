using System.Collections;

namespace Lab_7
{

    public class InternerOperatorList : IList<InternetOperator>
    {
        private List<InternetOperator> _localList;

        public InternerOperatorList()
        {
            _localList = new List<InternetOperator>();
        }

        public int Count => _localList.Count;

        public bool IsReadOnly => false;

        public InternetOperator this[int index]
        {
            get => _localList[index];
            set => _localList[index] = value;
        }


        public void Add(InternetOperator item)
        {
            _localList.Add(item);
        }

        public void Clear()
        {
            _localList.Clear();
        }

        public bool Contains(InternetOperator item)
        {
            return _localList.Contains(item);
        }

        public void CopyTo(InternetOperator[] array, int arrayIndex)
        {
            _localList.CopyTo(array, arrayIndex);
        }

        public bool Remove(InternetOperator item)
        {
            return _localList.Remove(item);
        }

        public int IndexOf(InternetOperator item)
        {
            return _localList.IndexOf(item);
        }


        public void Insert(int index, InternetOperator item)
        {
            _localList.Insert(index, item);
        }

        public void RemoveAt(int index)
        {
            _localList.RemoveAt(index);
        }

        public IEnumerator<InternetOperator> GetEnumerator()
        {
            return _localList.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public void del(String nameOperator)
        {
            InternetOperator localInternetOperator = getByName(nameOperator);
            _localList.Remove(localInternetOperator);
        }

        public bool find(String nameOperator)
        {
            foreach (var i in _localList)
            {
                if (i.NameOperator.Equals(nameOperator))
                {
                    return true;
                }
            }
            return false;
        }

        public InternetOperator getByName(String nameOperator)
        {
            InternetOperator localOperator = null;
            for (int i = 0; i < _localList.Count; i++)
            {
                if (_localList[i].NameOperator.Equals(nameOperator))
                {
                    localOperator = _localList[i];
                    break;
                }
            }
            return localOperator;

        }
    }
}
