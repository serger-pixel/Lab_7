using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_7
{
    // Класс содержит регулярные выражения для проверки вводимых данных.
    public static class Regs
    {
        // Регулярное выражение для проверки имени. 
        // Имя должно начинаться с заглавной буквы латинского алфавита и содержать до 20 символов.
        public const String _nameReg = "^[A-Z][A-Za-z]{0,19}$";

        // Регулярное выражение для проверки цены.
        // Цена должна быть числом от 100 до 100000, допускаются дробные значения через запятую.
        public const String _priceReg = "^(100(,0+)?|[1-9]\\d{2,4}(,\\d+)?|100000(,0+)?)$";

        // Регулярное выражение для проверки количества пользователей.
        // Значение должно быть натуральным числом, не превышающим 100.
        public const String _cntUsersReg = "^(100|[1-9]?[0-9])$";
    }

    // Класс содержит текстовые сообщения об ошибках.
    public static class ExceptionMessages
    {
        // Сообщение об ошибке при некорректном имени.
        public const String NAMEEXCEP = "Имя опрератора должно" +
          " начинаться с заглавной буквы на латинице и должно содержать " +
          "не более 20 символов";

        // Сообщение об ошибке при некорректной цене.
        public const String PRICEEXCEP = "Минимальная цена - 100 денежных ед., " +
            "максимальный - 100000 денежных ед.";

        // Сообщение об ошибке при некорректном количестве пользователей.
        public const String CNTUSERSEXCEP = "Не более 100 пользователей, " +
            "значение должно быть натуральным числом";

        // Сообщение об ошибке при попытке добавить объект с уже существующим именем.
        public const String OBJECTEXISTS = "Объект с таким именем уже существует";

        // Сообщение об ошибке при незаполненном поле.
        public const String FILEDNOTCHOSEN = "Поле не выбрано";
    }

    // Исключение для обработки ошибок, связанных с некорректным именем.
    public class NameException : Exception
    {
        
        public NameException() : base(ExceptionMessages.NAMEEXCEP) { }
    }

    // Исключение для обработки ошибок, связанных с некорректной ценой.
    public class PriceException : Exception
    {
        
        public PriceException() : base(ExceptionMessages.PRICEEXCEP) { }
    }

    // Исключение для обработки ошибок, связанных с некорректным количеством пользователей.
    public class CntUsersException : Exception
    {
        
        public CntUsersException() : base(ExceptionMessages.CNTUSERSEXCEP) { }
    }

    // Исключение для обработки ошибок, связанных с попыткой добавить объект с уже существующим именем.
    public class ObjectExists : Exception
    {
        
        public ObjectExists() : base(ExceptionMessages.OBJECTEXISTS) { }
    }

    // Исключение для обработки ошибок, связанных с незаполненным полем.
    public class ObjectNotChosenException : Exception
    {
        
        public ObjectNotChosenException() : base(ExceptionMessages.FILEDNOTCHOSEN) { }
    }
}