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

        }

        private void radioButtonBudget_CheckedChanged(object sender, EventArgs e)
        {
            student.budget = radioButtonBudget.Checked; //сохранить бюджет/коммерческое
            textBoxStudentInfo.Text = student.ToString(); //вывести на экран
        }

       
    }
}