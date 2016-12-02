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
               strOzenki += "\r\n";
            };

                return "���: " + FIO + "\r\n" +
                          "� ����������: " + Nstud + "\r\n" +
                          "����: " + kurs + "\r\n" +
                          "������: " + gruppa + "\r\n" +
                          (budget ? "�� ��������� ������" : "�� ������������ ������")+ "\r\n"+
                strOzenki;
        }
    }
}
