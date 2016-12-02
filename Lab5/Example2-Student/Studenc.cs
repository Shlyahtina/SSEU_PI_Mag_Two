using System;
using System.Collections.Generic;
using System.Text;

namespace Example2_Student
{
    class Student
    {
        public string FIO = "";          //ФИО
        public string Nstud = "000000";  //№ студБилета
        public int kurs = 1;             //Курс
        public string gruppa = "";       //Группа
        public bool budget = true;       //Бюджет
        public byte[,] ozenki = new byte[8, 5]; //Оценки

        const decimal stipSum = 1500m;
        const decimal stipPovyshSum = 1800m; //сумма повышенной стипендии

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
       
        public decimal stipendia(int semestr)
        {
            //если семестр не выходит за допустимые границы
            if ((semestr >= 0) && (semestr <= 2 * kurs))
            {
                if (budget) //студент бюджетник
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
                return 0; //не бюджетник - нет стипендии
            };
            return 0; //недопустимый семестр - нет стипендии
        }

        public string ToString()
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
                strOzenki += "\r\n" +
                 "Стипендия: " + stipendia(i) + "руб. \r\n";
            };

                return "ФИО: " + FIO + "\r\n" +
                          "№ студбилета: " + Nstud + "\r\n" +
                          "Курс: " + kurs + "\r\n" +
                          "Группа: " + gruppa + "\r\n" +
                          (budget ? "На бюджетной основе" : "На коммерческой основе")+ "\r\n"+
                strOzenki + "\r\n"+
                "Средний балл:"+ sredniyBall();
        }
    }
}
