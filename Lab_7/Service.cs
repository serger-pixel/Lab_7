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
        Regex _regexName = new Regex(Regs._nameReg);
        Regex _regexPrice = new Regex(Regs._priceReg);
        Regex _regexUsers = new Regex(Regs._cntUsersReg);
        //Список объектов
        public InternerOperatorList _dataBase = new InternerOperatorList();

        public void checkName(String name) 
        {
            if (!_regexName.Match(name).Success)
            {
                throw new NameException();
            }
        }

        public void checkExistance(String name) 
        {
            if (_dataBase.find(name))
            {
                throw new ObjectExists();
            }
        }

        public void checkPrice(String price) 
        {
            if (!_regexPrice.Match(price).Success)
            {
                throw new PriceException();
            }
        }

        public void checkUsers(String cntUsers) 
        {
            if (!_regexUsers.Match(cntUsers).Success)
            {
                throw new CntUsersException();
            }
        }

        public void checkData(String inputData) 
        {
            String[] splitData = inputData.Split(new char[] { ' ' });

            checkName(splitData[0]);
            checkExistance(splitData[0]);
            checkPrice(splitData[1]);
            checkUsers(splitData[2]);
        }
        
        //Конвертация строки в интернет оператор
        public InternetOperator convert(String inputData)
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
