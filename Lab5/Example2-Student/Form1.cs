using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Example2_Student
{
    public partial class FormStudent : Form
    {
        Student student = new Student();

        public FormStudent()
        {
            InitializeComponent();
        }

        private void textBoxFIO_TextChanged(object sender, EventArgs e)
        {
            student.FIO = textBoxFIO.Text; //��������� ���
            textBoxStudentInfo.Text = student.ToString(); //������� �� �����
        }

        private void textBoxNstud_TextChanged(object sender, EventArgs e)
        {
            student.Nstud = textBoxNstud.Text; //��������� � ����������
            textBoxStudentInfo.Text = student.ToString(); //������� �� �����
        }

        private void textBoxGruppa_TextChanged(object sender, EventArgs e)
        {
            student.gruppa = textBoxGruppa.Text; //��������� ������
            textBoxStudentInfo.Text = student.ToString(); //������� �� �����
        }

        private void numericUpDownKurs_ValueChanged(object sender, EventArgs e)
        {
            student.kurs = (int)numericUpDownKurs.Value; //��������� ����

        }

        private void radioButtonBudget_CheckedChanged(object sender, EventArgs e)
        {
            student.budget = radioButtonBudget.Checked; //��������� ������/������������
            textBoxStudentInfo.Text = student.ToString(); //������� �� �����
        }

       
    }
}