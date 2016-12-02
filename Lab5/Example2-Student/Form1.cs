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
            student.FIO = textBoxFIO.Text; //сохранить ФИО
            textBoxStudentInfo.Text = student.ToString(); //вывести на экран
        }

        private void textBoxNstud_TextChanged(object sender, EventArgs e)
        {
            student.Nstud = textBoxNstud.Text; //сохранить № студбилета
            textBoxStudentInfo.Text = student.ToString(); //вывести на экран
        }

        private void textBoxGruppa_TextChanged(object sender, EventArgs e)
        {
            student.gruppa = textBoxGruppa.Text; //сохранить группу
            textBoxStudentInfo.Text = student.ToString(); //вывести на экран
        }

        private void numericUpDownKurs_ValueChanged(object sender, EventArgs e)
        {
            student.kurs = (int)numericUpDownKurs.Value; //сохранить курс
            //вывод списка семестров
            comboBoxSemestr.Items.Clear(); //очистка списка
            //перебираем курсы с 1 до того, на котором учится студент
            for (int k = 1; k <= student.kurs; k++)
            {
                int s1 = 2 * k - 1; //номер осеннего семестра на курсе k
                int s2 = 2 * k; //номер весеннего семестра на курсе k
                //добавляем в список
                comboBoxSemestr.Items.Add(s1 + " семестр");
                comboBoxSemestr.Items.Add(s2 + " семестр");
            };
            //выбираем выделенный семестр - первый (отчет с 0)
            comboBoxSemestr.SelectedIndex = 0;
            textBoxStudentInfo.Text = student.ToString(); //вывести на экран
        }

        private void radioButtonBudget_CheckedChanged(object sender, EventArgs e)
        {
            student.budget = radioButtonBudget.Checked; //сохранить бюджет/коммерческое
            textBoxStudentInfo.Text = student.ToString(); //вывести на экран
        }

        private void numericUpDownEkz1_ValueChanged(object sender, EventArgs e)
        {
            //записать оценку в массив, приведя к типу byte
            student.ozenki[comboBoxSemestr.SelectedIndex, 0] = (byte)numericUpDownEkz1.Value;
            textBoxStudentInfo.Text = student.ToString(); //вывести на экран
        }

        private void numericUpDownEkz2_ValueChanged(object sender, EventArgs e)
        {
            //записать оценку в массив, приведя к типу byte
            student.ozenki[comboBoxSemestr.SelectedIndex, 1] = (byte)numericUpDownEkz2.Value;
            textBoxStudentInfo.Text = student.ToString(); //вывести на экран
        }

        private void numericUpDownEkz3_ValueChanged(object sender, EventArgs e)
        {
            //записать оценку в массив, приведя к типу byte
            student.ozenki[comboBoxSemestr.SelectedIndex, 2] = (byte)numericUpDownEkz3.Value;
            textBoxStudentInfo.Text = student.ToString(); //вывести на экран
        }

        private void numericUpDownEkz4_ValueChanged(object sender, EventArgs e)
        {
            //записать оценку в массив, приведя к типу byte
            student.ozenki[comboBoxSemestr.SelectedIndex, 3] = (byte)numericUpDownEkz4.Value;
            textBoxStudentInfo.Text = student.ToString(); //вывести на экран
        }

        private void numericUpDownEkz5_ValueChanged(object sender, EventArgs e)
        {
            //записать оценку в массив, приведя к типу byte
            student.ozenki[comboBoxSemestr.SelectedIndex, 4] = (byte)numericUpDownEkz5.Value;
            textBoxStudentInfo.Text = student.ToString(); //вывести на экран
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