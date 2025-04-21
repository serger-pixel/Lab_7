using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Lab_7
{
    public static class Regs
    {
        public const String _nameReg = "^[A-Z][A-Za-z]{0,19}$";
        public const String _priceReg = "^(100(,0+)?|[1-9]\\d{2,4}(,\\d+)?|100000(,0+)?)$";
        public const String _cntUsersReg = "^(100|[1-9]?[0-9])$";
    }


    public static class ExceptionMessages
    {
        public const String NAMEEXCEP = "Имя опрератора должно" +
          " начинаться с заглавной буквы на латинице и должно содержать " +
          "не более 20 символов";

        public const String PRICEEXCEP = "Минимальная цена - 100 денежных ед., " +
            "максимальный - 100000 денежных ед. с учетом доп. скидки";

        public const String CNTUSERSEXCEP = "Не более 100 пользователей, " +
            "значение должно быть натуральным числом";

        public const String OBJECTEXISTS = "Объект с таким именем уже существует";

        public const String FILEDNOTCHOSEN = "Поле не выбрано";

    }
    public class NameException : Exception
    {
        public NameException() : base(ExceptionMessages.NAMEEXCEP) { }
    }

    public class PriceException : Exception
    {
        public PriceException() : base(ExceptionMessages.PRICEEXCEP) { }
    }

    public class CntUsersException : Exception
    {
        public CntUsersException() : base(ExceptionMessages.CNTUSERSEXCEP) { }
    }

    //Исключение отсутствия выбора
    public class FieldNotChosenException : Exception
    {
        public FieldNotChosenException() : base(ExceptionMessages.FILEDNOTCHOSEN) { }
    }

    public class ObjectNotChosenException : Exception
    {
        public ObjectNotChosenException() : base(ExceptionMessages.FILEDNOTCHOSEN) { }
    }

    public class ObjectExists : Exception 
    {
        public ObjectExists() : base(ExceptionMessages.OBJECTEXISTS) { }
    }
}

