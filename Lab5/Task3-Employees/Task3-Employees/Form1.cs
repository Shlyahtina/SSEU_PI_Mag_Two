using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task3_Employees
{
    public partial class Form1 : Form
    {
        Employe employe = new Employe();
        
        public Form1()
        {
            InitializeComponent();
        }

        private void textBoxFIO_TextChanged(object sender, EventArgs e)
        {
            employe.FIO = textBoxFIO.Text; //сохранить ФИО
            textBoxEmployeesInfo.Text = employe.ToString(); //вывести на экран
        }

        private void dateTimePickerBirthday_ValueChanged(object sender, EventArgs e)
        {
            employe.birthday = dateTimePickerBirthday.Text;
            textBoxEmployeesInfo.Text = employe.ToString();

        }

        private void checkBoxMoonlight_CheckedChanged(object sender, EventArgs e)
        {
            employe.moonlight = checkBoxMoonlight.Checked;
            textBoxEmployeesInfo.Text = employe.ToString();
        }
    }
}
