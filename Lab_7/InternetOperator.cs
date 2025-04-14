using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab_7;

namespace Lab_7
{
    // Константы Интернет оператора
    public static class IntOperConsts
    {
        public const String KeyNameOperator = "nameOperator";
        public const String KeyPriceOfMonth = "priceOfMonth";
        public const String KeycntUsers = "cntUsers";
        public const String KeyAll = "All";

        public const string DELETING = "Удаление элемента: ";
        public const string ADDING = "Добавление элемента: ";
        public const string EDITING = "Изменение элемента: ";
        public const string TITLE = "Изменение";

        public const String UPKEYS = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        public const String DOWNKEYS = "abcdefghijklmnopqrstuvwxyz";
        public const int MINLENGEN = 4;
    }

    // Класс Интернет оператора
    public class InternetOperator
    {
        // Значения имени, цены и кол-ва пользователей по умолчанию
        public const String NAME = "Default";
        public const decimal PRICE = 100;
        public const int CNTUSERS = 1;

        // Свойство имени оператора
        public String NameOperator { get; set; }

        // Свойство цены за месяц
        public decimal PriceOfMonth { get; set; }

        // Свойство кол-ва пользователей
        public int CntUsers { get; set; }

        // Конструктор с передачей всех параметров
        public InternetOperator(String nameOperator, decimal priceOfMonth,
            int cntUsers)
        {
            NameOperator = nameOperator;
            PriceOfMonth = priceOfMonth;
            CntUsers = cntUsers;
        }
    }
}
