using System;
using System.Collections.Generic;
using System.Text;

namespace Student2005
{
    class Student
    {
        public string fio = "";          //���
        //string familiya = "";
        //string imya ="";
        //string otchestco = "";
        public string Nstud = "000000";  //� ����������
        int kurs = 1;             //����
        public string gruppa = "";       //������
        //public bool budget = true;       //������
        //public byte[,] Ozenki = new byte[8, 5]; //������

        Ozenki ozenki = new Ozenki();

        public Ozenki Ozenki { get { return ozenki; } }

        const decimal stipSum = 1500m;
        const decimal stipPovyshSum = 1800m; //����� ���������� ���������

        public Student() { }

        public Student(Student copyFrom)
        { 
            FIO = copyFrom.FIO;
            Nstud = copyFrom.Nstud;
            kurs = copyFrom.kurs;
            gruppa = copyFrom.gruppa;
            ozenki = copyFrom.ozenki;
        }

        public string FIO
        {
            get { return fio; }
            set { fio = value; }
        }

        public int Kurs
        {
            get 
            { 
                return kurs;
            }
            set
            {
                if (value >= 1 && value <= 4)
                { kurs = value; };
            }
        
        }

        

        //��������� �� ��������� ����
        public void perevestiNaSledKurs()
        {
                Kurs += 1;
        }

        //��������� ������� ����
        public double sredniyBall()
        {
            double sum = 0; //����� ������
            int n = 0;//���������� ��������� � ��������
            //��������� � ������������� ������ � �����
            for (int i = 0; i < KolvoSemestrov(); i++)
                for (int j = 0; j < 5; j++)
                {
                    if (Ozenki[i, j] > 1)
                    {
                        sum += Ozenki[i, j];
                        n++;
                    };
                };
            //���� ���� ��������
            if (n > 0)
                return sum / n; //������� ���� = ����� / ����������
            else
                return 0; //������� ���� = 0
        }

        public override string ToString()
        {
            string strOzenki = "";

            for (int i = 0; i < KolvoSemestrov(); i++) 
            {
                //������� ����� �������� � ������ ������
                strOzenki += (i + 1) + " �������: ";
                //������� ���������
                for (int j = 0; j < 5; j++)
                {
                    if (Ozenki[i, j] == 1)  //������
                        strOzenki += "������, "; //��������� ������ � ������
                    else if (Ozenki[i, j] > 1) //���� ������
                        strOzenki += Ozenki[i, j] + ", "; //��������� ������ � ������
                };
                //����� ������
                strOzenki += "\r\n";
            };

                return "���: " + FIO + "\r\n" +
                          "� ����������: " + Nstud + "\r\n" +
                          "����: " + kurs + "\r\n" +
                          "������: " + gruppa + "\r\n" +
                          strOzenki + "\r\n"+
                          "������� ����:"+ sredniyBall();
        }

        //���������� ���������
        protected int KolvoSemestrov()
        { return 2*kurs;}

        // ����������� ��������� ��������� �� ��������� �������
        protected int KolNesdach(int semestr)
        {
            int k = 0;
            //���������� ��� �������� �� ��������� �������
            for (int i = 0; i < 5; i++)
            {
                //���� ������ ��� ����
                if ((Ozenki[semestr, i] == 1) || (Ozenki[semestr, i] == 2))
                {
                    k += 1;
                }
            }
            return k;
        }
    }

    class StudentBudg: Student
    {
        public StudentBudg(Student copyFrom) : base(copyFrom) { }
        //�����������
        
        //���������� ��������� �� ��������� �������
        const decimal stipSum = 1500m; // ����� ������� ���������
        const decimal stipPovyshSum = 1800m; //����� ���������� ���������
        public decimal Stipendia(int semestr)
        {
            //���� ������� �� ������� �� ���������� �������
            if ((semestr >= 0) && (semestr <= KolvoSemestrov()))
            {
                bool stip = true; //���� ���������
                bool stipPovysh = true; //���� ���������� ���������
                int n = 0;  //���������� ���������
                for (int i = 0; i < 5; i++)
                {
                    if (Ozenki[semestr, i] > 0) //���� ������� ���
                    {
                        n++;    //��������� ���������� ���������
                        stip &= (Ozenki[semestr, i] > 3); //������� ��������� - ������ ���� 3
                        stipPovysh &= (Ozenki[semestr, i] == 5); //���������� - ������ 5
                    };
                };
                if (n == 0) //�� ���� ���������
                    return 0; //��� ��� ���������
                if (stipPovysh) //���� ���������� ���������
                    return stipPovyshSum;
                else if (stip) //���� ������� ���������
                    return stipSum;
                else
                    return 0;
            };
            return 0; //������������ ������� - ��� ���������
        }

        public override string ToString() 
        {
            //��������� ������ � ��������� �� ������ �������
            string stipendia = "���������:\r\n";
            for (int i = 0; i < KolvoSemestrov(); i++)
                stipendia += (i+1) + "�������: " + Stipendia(i) + "���. \r\n";
            //�������� ��������� �� 
            return base.ToString() + "\r\n" //������ ������-������ (Student)
            + "�������� �� ��������� ������ \r\n" //������ � ��������� ���������
            + stipendia;           
        }
    }

    class StudentPlat:Student 
    {
        public decimal stoimostObucheniya; //��������� �������� �� �������
        public decimal oplacheno; //������� ������� ������� � �����

        public StudentPlat(Student copyFrom): base(copyFrom) 
        {
        // ���� ������� copyFrom �������� ���������
            if (copyFrom is StudentPlat) 
            {
                // �� ����������� ��������� ��������� � ����� �����,
                // ������������ copyFrom ��� ��������
                stoimostObucheniya = (copyFrom as StudentPlat).stoimostObucheniya;
                oplacheno = (copyFrom as StudentPlat).oplacheno;
            };
         }

        // �������� ��������
        public void OplatitObuchenie(decimal sum)
        {
            //���� ��������� �� ��������� �����
            oplacheno += sum;
        }
        // ������������� �� ��������� (��� ���������, ���� �������������)
        public decimal Dolg()
        {
            //���� = ��������� �������� �� ������� * ���-�� ��������� - ��������
            return stoimostObucheniya * KolvoSemestrov() - oplacheno;
        }

        public override string ToString()
        {
            return base.ToString()+ "\r\n"
                +"�������� �� ������� ������ \r\n"
                +"��������� ��������: "+stoimostObucheniya+"���.\r\n"
                +"�����������: "+Dolg()+ "���.";
        
        }
    }

    class Ozenki 
    { 
        byte[,] ozenki = new byte[8, 5];

        public byte this[int semestr, int ekzamen]
        {
            get
            {
                //���� ����� �������� � �������� ����������
                if ((semestr+1 >= 1 && semestr+1 <= 8) && (ekzamen+1 >= 1 && ekzamen+1 <= 5))
                {
                    //�� ������� ������
                    return ozenki[semestr, ekzamen ];
                };
                //����� - �������, ��� ������ �������� ���, ������� 0
                return 0;
            }

            set
            {
                //���� ����� �������� � �������� ����������
                if ((value >= 0 && value <= 5)
                     && (semestr+1 >= 1 && semestr+1 <= 8) && (ekzamen+1 >= 1 && ekzamen+1 <= 5))
                {
                    //�� ������� ������
                    ozenki[semestr, ekzamen ] = value;
                };
                //����� - ������ �� ���������
            }
        }
    }
}
