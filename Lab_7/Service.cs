using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_7
{
    public class Service
    {
        //Список объектов
        public InternerOperatorList dataBase = new InternerOperatorList();

        //Конвертация строки в интернет оператор
        private InternetOperator convert(String inputData)
        {
            String []splitData = inputData.Split(new char[] { ' ' });
            return new InternetOperator(splitData[0], decimal.Parse(splitData[1]), int.Parse(splitData[2]));
        }

        //Добавление пользователя
        public void add(String inputData) {
            dataBase.Add(convert(inputData));
        }

        //Удаление пользователя
        public void remove(String name) {
            InternetOperator localOperator = dataBase.getByName(name);
            dataBase.Remove(localOperator);
        }

        //Получение пользователя
        public InternetOperator get(String name) {
            return dataBase.getByName(name);
        }

        //Обновление пользователя
        public void update(String inputData) {
            InternetOperator localOperator = convert(inputData);
            InternetOperator innerOper = dataBase.getByName(localOperator.NameOperator);
            innerOper.PriceOfMonth = localOperator.PriceOfMonth;
            innerOper.CntUsers = localOperator.CntUsers;
        }
    }
}
