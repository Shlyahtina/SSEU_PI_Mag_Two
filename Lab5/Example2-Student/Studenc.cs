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
            return "���: " + FIO + "\r\n" +
                      "� ����������: " + Nstud + "\r\n" +
                      "����: " + kurs + "\r\n" +
                      "������: " + gruppa + "\r\n" +
                      (budget ? "�� ��������� ������" : "�� ������������ ������");
        }
    }
}
