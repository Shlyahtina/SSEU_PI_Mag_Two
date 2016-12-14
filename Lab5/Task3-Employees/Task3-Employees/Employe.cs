using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3_Employees
{
    class Employe
    {
        public string FIO = "";                     // ФИО
        public string birthday = "";  // День рождения
        public string position = "";                // Должность
        public decimal salary = 0;                  // Оклад
        public bool moonlight = true;               // Работать по совместительству

       // public decimal getSalary(){}                // Получить зарплату

       // public decimal getPremium(){}               // Получить премию

      //  public decimal getInsurance() { }           // Получить страховую премию
        
        public string ToString() {
            return "ФИО: " + FIO + "\r\n" +
                             "День рождение: " + birthday + "\r\n" +
                             "Должность: " + position + "\r\n" +
                             "Оклад: " + salary + "\r\n" +
                             (moonlight ? "Основное место работы" : "Работает по совместительству") + "\r\n";
        }
    }
}
