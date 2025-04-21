using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Lab_7
{
    public class Service
    {
        //Список объектов
        public InternerOperatorList _dataBase = new InternerOperatorList();

        public void checkName(String name) 
        {
            
        }

        public void checkData(String inputData) 
        {
            String[] splitData = inputData.Split(new char[] { ' ' });

            Regex regex = new Regex(Regs._nameReg);

            if (!regex.Match(splitData[0]).Success)
            {
                throw new NameException();
            }

            if (_dataBase.find(splitData[0]))
            {
                throw new ObjectExists();
            }

            if (!regex.Match(splitData[1]).Success) 
            {
                throw new PriceException();
            }

            if (!regex.Match(splitData[2]).Success) 
            {
                throw new CntUsersException();
            }

        }
        
        //Конвертация строки в интернет оператор
        private InternetOperator convert(String inputData)
        {
            String []splitData = inputData.Split(new char[] { ' ' });
            return new InternetOperator(splitData[0], decimal.Parse(splitData[1]), int.Parse(splitData[2]));
        }

        //Добавление пользователя
        public void add(String inputData) {
            _dataBase.Add(convert(inputData));
        }

        //Удаление пользователя
        public void remove(String name) {
            InternetOperator localOperator = _dataBase.getByName(name);
            _dataBase.Remove(localOperator);
        }

        //Получение пользователя
        public InternetOperator get(String name) {
            return _dataBase.getByName(name);
        }

        //Обновление пользователя
        public void update(String inputData) {
            InternetOperator localOperator = convert(inputData);
            InternetOperator innerOper = _dataBase.getByName(localOperator.NameOperator);
            innerOper.PriceOfMonth = localOperator.PriceOfMonth;
            innerOper.CntUsers = localOperator.CntUsers;
        }
    }
}
