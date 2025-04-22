using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_7
{
    // Абстрактный класс, который предоставляет статические методы для управления данными.
    public class Controller
    {
        // Приватное статическое поле для работы с логикой обработки данных.
        private  Service _service = new Service();

        // Возвращает коллекцию данных (список интернет операторов) из сервиса.
        public  InternerOperatorList getDataBase()
        {
            return _service._dataBase;
        }

        // Добавляет новую запись в коллекцию данных после проверки её корректности.
        public  void add(String inputData)
        {
            _service.checkData(inputData);
            _service.add(inputData);
        }

        // Обновляет существующую запись в коллекции данных. 
        public  void update(String inputData)
        {
            InternetOperator localOperator = _service.convert(inputData);
            _service.checkPrice(localOperator.PriceOfMonth.ToString());
            _service.checkUsers(localOperator.CntUsers.ToString());
            _service.update(inputData);
        }

        // Удаляет запись из коллекции данных по имени. 
        public  void remove(String name)
        {
            _service.checkSelection(name);
            _service.remove(name);
        }

        // Возвращает объект из коллекции данных по имени. 
        public  InternetOperator get(String name)
        {
            _service.checkName(name);
            return _service.get(name);
        }
    }
}