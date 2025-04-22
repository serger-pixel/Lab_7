using System.Collections;

namespace Lab_7
{
    public class InternerOperatorList : IList<InternetOperator>
    {
        // Приватное поле для хранения списка интернет операторов.
        private List<InternetOperator> _localList;

        // Конструктор класса, инициализирующий внутренний список.
        public InternerOperatorList()
        {
            _localList = new List<InternetOperator>();
        }

        // Свойство Count возвращает количество интернет операторов в списке.
        public int Count => _localList.Count;

        public bool IsReadOnly => false;

        // Индексатор для доступа к интернет операторам по индексу.
        public InternetOperator this[int index]
        {
            get => _localList[index]; // Получение интернет оператора по индексу.
            set => _localList[index] = value; // Установка значения интернет оператора по индексу.
        }

        //добавляет нового интернет оператора в список.
        public void Add(InternetOperator item)
        {
            _localList.Add(item);
        }

        //очищает весь список интернет операторов.
        public void Clear()
        {
            _localList.Clear();
        }

        //проверяет, содержится ли интернет оператор в списке.
        public bool Contains(InternetOperator item)
        {
            return _localList.Contains(item);
        }

        //копирует интернет операторов из списка в массив, начиная с указанного индекса.
        public void CopyTo(InternetOperator[] array, int arrayIndex)
        {
            _localList.CopyTo(array, arrayIndex);
        }

        //удаляет указанного интернет оператора из списка.
        public bool Remove(InternetOperator item)
        {
            return _localList.Remove(item);
        }

        // Метод IndexOf возвращает индекс первого вхождения интернет оператора в списке.
        public int IndexOf(InternetOperator item)
        {
            return _localList.IndexOf(item);
        }

        //вставляет интернет оператора в список на указанную позицию.
        public void Insert(int index, InternetOperator item)
        {
            _localList.Insert(index, item);
        }

        //удаляет интернет оператора по указанному индексу.
        public void RemoveAt(int index)
        {
            _localList.RemoveAt(index);
        }

        //возвращает перечислитель для обхода коллекции интернет операторов.
        public IEnumerator<InternetOperator> GetEnumerator()
        {
            return _localList.GetEnumerator();
        }

        // Явная реализация интерфейса IEnumerable для необобщённого перечисления.
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        //удаляет интернет оператора по имени.
        public void del(String nameOperator)
        {
            // Находим интернет оператора по имени и удаляем его из списка.
            InternetOperator localInternetOperator = getByName(nameOperator);
            _localList.Remove(localInternetOperator);
        }

        //проверяет, существует ли интернет оператор с указанным именем в списке.
        public bool find(String nameOperator)
        {
            // Перебираем все интернет операторов и сравниваем их имена.
            foreach (var i in _localList)
            {
                if (i.NameOperator.Equals(nameOperator))
                {
                    return true;
                }
            }
            return false;
        }

        //возвращает интернет оператора по имени.
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