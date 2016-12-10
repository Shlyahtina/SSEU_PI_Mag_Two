using System;
using System.Collections.Generic;
using System.Text;

namespace Student2005
{
    class Student
    {
        public string FIO = "";          //ФИО
        public string Nstud = "000000";  //№ студБилета
        public int kurs = 1;             //Курс
        public string gruppa = "";       //Группа
        //public bool budget = true;       //Бюджет
        public byte[,] ozenki = new byte[8, 5]; //Оценки

        const decimal stipSum = 1500m;
        const decimal stipPovyshSum = 1800m; //сумма повышенной стипендии

        public Student() { }

        public Student(Student copyFrom)
        { 
            FIO = copyFrom.FIO;
            Nstud = copyFrom.Nstud;
            kurs = copyFrom.kurs;
            gruppa = copyFrom.gruppa;
            ozenki = copyFrom.ozenki;
        }

        public void perevestiNaSledKurs()
        {
            if (kurs < 4)
                kurs += 1;
        }

        //вычислить средний балл
        public double sredniyBall()
        {
            double sum = 0; //сумма баллов
            int n = 0;//количество экзаменов с оценками
            //суммируем и пересчитываем оценки в цикле
            for (int i = 0; i < 2 * kurs; i++)
                for (int j = 0; j < 5; j++)
                {
                    if (ozenki[i, j] > 1)
                    {
                        sum += ozenki[i, j];
                        n++;
                    };
                };
            //если были экзамены
            if (n > 0)
                return sum / n; //средний балл = сумма / количество
            else
                return 0; //средний балл = 0
        }

        public override string ToString()
        {
            string strOzenki = "";

            for (int i = 0; i < 2 * kurs; i++) 
            {
                //выводим номер семестра в начале строки
                strOzenki += (i + 1) + " семестр: ";
                //перебор экзаменов
                for (int j = 0; j < 5; j++)
                {
                    if (ozenki[i, j] == 1)  //неявка
                        strOzenki += "неявка, "; //добавляем оценку к строке
                    else if (ozenki[i, j] > 1) //есть оценка
                        strOzenki += ozenki[i, j] + ", "; //добавляем оценку к строке
                };
                //конец строки
                strOzenki += "\r\n";
            };

                return "ФИО: " + FIO + "\r\n" +
                          "№ студбилета: " + Nstud + "\r\n" +
                          "Курс: " + kurs + "\r\n" +
                          "Группа: " + gruppa + "\r\n" +
                          strOzenki + "\r\n"+
                          "Средний балл:"+ sredniyBall();
        }
    }

    class StudentBudg: Student
    {
        public StudentBudg(Student copyFrom) : base(copyFrom) { }
        //скопировать
        
        //определить стипендию за указанный семестр
        const decimal stipSum = 1500m; // сумма обычной стипендии
        const decimal stipPovyshSum = 1800m; //сумма повышенной стипендии
        public decimal Stipendia(int semestr)
        {
            //если семестр не выходит за допустимые границы
            if ((semestr >= 0) && (semestr <= 2*kurs))
            {
                bool stip = true; //есть стипендия
                bool stipPovysh = true; //есть повышенная стипендия
                int n = 0;  //количество экзаменов
                for (int i = 0; i < 5; i++)
                {
                    if (ozenki[semestr, i] > 0) //если экзамен был
                    {
                        n++;    //увеличить количество экзаменов
                        stip &= (ozenki[semestr, i] > 3); //обычная стипендия - оценка выше 3
                        stipPovysh &= (ozenki[semestr, i] == 5); //повышенная - оценка 5
                    };
                };
                if (n == 0) //не было экзаменов
                    return 0; //еще нет стипендии
                if (stipPovysh) //есть повышенная стипендия
                    return stipPovyshSum;
                else if (stip) //есть обычная стипендия
                    return stipSum;
                else
                    return 0;
            };
            return 0; //недопустимый семестр - нет стипендии
        }

        public override string ToString() 
        {
            //формируем запись о стипендии за каждый семестр
            string stipendia = "Стипендия:\r\n";
            for (int i = 0; i < 2 * kurs; i++)
                stipendia += i+1 + "семестр: " + Stipendia(i) + "руб. \r\n";
            //собираем результат из 
            return base.ToString() + "\r\n" //метода класса-предка (Student)
            + "Обучение на бюджетной основе \r\n" //запись о бюджетном огбучении
            + stipendia;           
        }
    }

    class StudentPlat:Student 
    {
        public decimal stoimostObucheniya; //стоимость обучения за семестр
        public decimal oplacheno; //сколько оплатил студент в сумме

        public StudentPlat(Student copyFrom): base(copyFrom) 
        {
        // если студент copyFrom является платником
            if (copyFrom is StudentPlat) 
            {
                // то скопировать стоимость обучегния и сумму долго,
                // рассматривая copyFrom как платника
                stoimostObucheniya = (copyFrom as StudentPlat).stoimostObucheniya;
                oplacheno = (copyFrom as StudentPlat).oplacheno;
            };
         }

        // оплатить обучение
        public void OplatitObuchenie(decimal sum)
        {
            //долг снижается на указанную сумму
            oplacheno += sum;
        }
        // задолженность за обучсение (или переплата, если отрицательное)
        public decimal Dolg()
        {
            //долг = стоимость обучения за семестр * кол-во семестров - оплачено
            return stoimostObucheniya * kurs * 2 - oplacheno;
        }

        public override string ToString()
        {
            return base.ToString()+ "\r\n"
                +"Обучение на платной основе \r\n"
                +"Стоимость обучения: "+stoimostObucheniya+"руб.\r\n"
                +"Задолжность: "+Dolg()+ "руб.";
        
        }
    }

}
