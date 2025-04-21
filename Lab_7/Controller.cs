using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_7
{
    public abstract class Controller
    {
        private static Service _service = new Service();

        public static InternerOperatorList getDataBase() 
        {
            return _service._dataBase;
        }
        public static void add(String inputData) 
        {
            _service.checkData(inputData);
            _service.add(inputData);
        }

        public static void update(String inputData) 
        {
            InternetOperator localOperator = _service.convert(inputData);
            _service.checkPrice(localOperator.PriceOfMonth.ToString());
            _service.checkUsers(localOperator.CntUsers.ToString());
            _service.update(inputData);
        }

        public static void remove(String name) 
        {
            _service.checkName(name);
            _service.remove(name);
        }

        public static InternetOperator get(String name) 
        {
            _service.checkName(name);
            return _service.get(name);
        }
    }
}
