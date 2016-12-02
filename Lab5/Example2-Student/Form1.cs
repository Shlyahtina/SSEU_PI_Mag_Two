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
            //����� ������ ���������
            comboBoxSemestr.Items.Clear(); //������� ������
            //���������� ����� � 1 �� ����, �� ������� ������ �������
            for (int k = 1; k <= student.kurs; k++)
            {
                int s1 = 2 * k - 1; //����� �������� �������� �� ����� k
                int s2 = 2 * k; //����� ��������� �������� �� ����� k
                //��������� � ������
                comboBoxSemestr.Items.Add(s1 + " �������");
                comboBoxSemestr.Items.Add(s2 + " �������");
            };
            //�������� ���������� ������� - ������ (����� � 0)
            comboBoxSemestr.SelectedIndex = 0;
            textBoxStudentInfo.Text = student.ToString(); //������� �� �����
        }

        private void radioButtonBudget_CheckedChanged(object sender, EventArgs e)
        {
            student.budget = radioButtonBudget.Checked; //��������� ������/������������
            textBoxStudentInfo.Text = student.ToString(); //������� �� �����
        }

        private void numericUpDownEkz1_ValueChanged(object sender, EventArgs e)
        {
            //�������� ������ � ������, ������� � ���� byte
            student.ozenki[comboBoxSemestr.SelectedIndex, 0] = (byte)numericUpDownEkz1.Value;
            textBoxStudentInfo.Text = student.ToString(); //������� �� �����
        }

        private void numericUpDownEkz2_ValueChanged(object sender, EventArgs e)
        {
            //�������� ������ � ������, ������� � ���� byte
            student.ozenki[comboBoxSemestr.SelectedIndex, 1] = (byte)numericUpDownEkz2.Value;
            textBoxStudentInfo.Text = student.ToString(); //������� �� �����
        }

        private void numericUpDownEkz3_ValueChanged(object sender, EventArgs e)
        {
            //�������� ������ � ������, ������� � ���� byte
            student.ozenki[comboBoxSemestr.SelectedIndex, 2] = (byte)numericUpDownEkz3.Value;
            textBoxStudentInfo.Text = student.ToString(); //������� �� �����
        }

        private void numericUpDownEkz4_ValueChanged(object sender, EventArgs e)
        {
            //�������� ������ � ������, ������� � ���� byte
            student.ozenki[comboBoxSemestr.SelectedIndex, 3] = (byte)numericUpDownEkz4.Value;
            textBoxStudentInfo.Text = student.ToString(); //������� �� �����
        }

        private void numericUpDownEkz5_ValueChanged(object sender, EventArgs e)
        {
            //�������� ������ � ������, ������� � ���� byte
            student.ozenki[comboBoxSemestr.SelectedIndex, 4] = (byte)numericUpDownEkz5.Value;
            textBoxStudentInfo.Text = student.ToString(); //������� �� �����
        }

        private void comboBoxSemestr_SelectedIndexChanged(object sender, EventArgs e)
        {
            numericUpDownEkz1.Value = student.ozenki[comboBoxSemestr.SelectedIndex, 0];
            numericUpDownEkz2.Value = student.ozenki[comboBoxSemestr.SelectedIndex, 1];
            numericUpDownEkz3.Value = student.ozenki[comboBoxSemestr.SelectedIndex, 2];
            numericUpDownEkz4.Value = student.ozenki[comboBoxSemestr.SelectedIndex, 3];
            numericUpDownEkz5.Value = student.ozenki[comboBoxSemestr.SelectedIndex, 4];
        }

       
    }
}