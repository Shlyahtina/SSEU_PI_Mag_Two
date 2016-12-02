using System;
using System.Collections.Generic;
using System.Text;

namespace Example2_Student
{
    class Student
    {
        public string FIO = "";          //���
        public string Nstud = "000000";  //� ����������
        public int kurs = 1;             //����
        public string gruppa = "";       //������
        public bool budget = true;       //������
        public byte[,] ozenki = new byte[8, 5]; //������

        const decimal stipSum = 1500m;
        const decimal stipPovyshSum = 1800m; //����� ���������� ���������

        public void perevestiNaSledKurs()
        {
            if (kurs < 4)
                kurs += 1;
        }

        //��������� ������� ����
        public double sredniyBall()
        {
            double sum = 0; //����� ������
            int n = 0;//���������� ��������� � ��������
            //��������� � ������������� ������ � �����
            for (int i = 0; i < 2 * kurs; i++)
                for (int j = 0; j < 5; j++)
                {
                    if (ozenki[i, j] > 1)
                    {
                        sum += ozenki[i, j];
                        n++;
                    };
                };
            //���� ���� ��������
            if (n > 0)
                return sum / n; //������� ���� = ����� / ����������
            else
                return 0; //������� ���� = 0
        }
       
        public decimal stipendia(int semestr)
        {
            //���� ������� �� ������� �� ���������� �������
            if ((semestr >= 0) && (semestr <= 2 * kurs))
            {
                if (budget) //������� ���������
                {
                    bool stip = true; //���� ���������
                    bool stipPovysh = true; //���� ���������� ���������
                    int n = 0;  //���������� ���������
                    for (int i = 0; i < 5; i++)
                    {
                        if (ozenki[semestr, i] > 0) //���� ������� ���
                        {
                            n++;    //��������� ���������� ���������
                            stip &= (ozenki[semestr, i] > 3); //������� ��������� - ������ ���� 3
                            stipPovysh &= (ozenki[semestr, i] == 5); //���������� - ������ 5
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
                return 0; //�� ��������� - ��� ���������
            };
            return 0; //������������ ������� - ��� ���������
        }

        public string ToString()
        {
            string strOzenki = "";

            for (int i = 0; i < 2 * kurs; i++) 
            {
                //������� ����� �������� � ������ ������
                strOzenki += (i + 1) + " �������: ";
                //������� ���������
                for (int j = 0; j < 5; j++)
                {
                    if (ozenki[i, j] == 1)  //������
                        strOzenki += "������, "; //��������� ������ � ������
                    else if (ozenki[i, j] > 1) //���� ������
                        strOzenki += ozenki[i, j] + ", "; //��������� ������ � ������
                };
                //����� ������
                strOzenki += "\r\n" +
                 "���������: " + stipendia(i) + "���. \r\n";
            };

                return "���: " + FIO + "\r\n" +
                          "� ����������: " + Nstud + "\r\n" +
                          "����: " + kurs + "\r\n" +
                          "������: " + gruppa + "\r\n" +
                          (budget ? "�� ��������� ������" : "�� ������������ ������")+ "\r\n"+
                strOzenki + "\r\n"+
                "������� ����:"+ sredniyBall();
        }
    }
}
