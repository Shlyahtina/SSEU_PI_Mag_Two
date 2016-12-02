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

            //������� ������ �� ��������� �������
            //���� �� ���� ��������
            if (student.ozenki[comboBoxSemestr.SelectedIndex, 0] == 0)
            {
                checkBoxEkz1.Checked = false; //����� ������
            }
            else //����� - ������� ���
            {
                checkBoxEkz1.Checked = true; //���������� ������
                //���� ������
                if (student.ozenki[comboBoxSemestr.SelectedIndex, 0] == 1)
                {
                    checkBoxEkz1neyavka.Checked = true; //���������� ������
                }
                else
                {
                    checkBoxEkz1neyavka.Checked = false; //����� ������
                    //������� ������
                    numericUpDownEkz1.Value = student.ozenki[comboBoxSemestr.SelectedIndex, 0];
                };
            };
            //���� �� ���� ��������
            if (student.ozenki[comboBoxSemestr.SelectedIndex, 1] == 0)
            {
                checkBoxEkz2.Checked = false; //����� ������
            }
            else //����� - ������� ���
            {
                checkBoxEkz2.Checked = true; //���������� ������
                //���� ������
                if (student.ozenki[comboBoxSemestr.SelectedIndex, 1] == 1)
                {
                    checkBoxEkz2neyavka.Checked = true; //���������� ������
                }
                else
                {
                    checkBoxEkz2neyavka.Checked = false; //����� ������
                    //������� ������
                    numericUpDownEkz2.Value = student.ozenki[comboBoxSemestr.SelectedIndex, 1];
                };
            };
            //���� �� ���� ��������
            if (student.ozenki[comboBoxSemestr.SelectedIndex, 2] == 0)
            {
                checkBoxEkz3.Checked = false; //����� ������
            }
            else //����� - ������� ���
            {
                checkBoxEkz3.Checked = true; //���������� ������
                //���� ������
                if (student.ozenki[comboBoxSemestr.SelectedIndex, 2] == 1)
                {
                    checkBoxEkz3neyavka.Checked = true; //���������� ������
                }
                else
                {
                    checkBoxEkz3neyavka.Checked = false; //����� ������
                    //������� ������
                    numericUpDownEkz3.Value = student.ozenki[comboBoxSemestr.SelectedIndex, 2];
                };
            };
            //���� �� ���� ��������
            if (student.ozenki[comboBoxSemestr.SelectedIndex, 3] == 0)
            {
                checkBoxEkz4.Checked = false; //����� ������
            }
            else //����� - ������� ���
            {
                checkBoxEkz4.Checked = true; //���������� ������
                //���� ������
                if (student.ozenki[comboBoxSemestr.SelectedIndex, 3] == 1)
                {
                    checkBoxEkz4neyavka.Checked = true; //���������� ������
                }
                else
                {
                    checkBoxEkz4neyavka.Checked = false; //����� ������
                    //������� ������
                    numericUpDownEkz4.Value = student.ozenki[comboBoxSemestr.SelectedIndex, 3];
                };
            };
            //���� �� ���� ��������
            if (student.ozenki[comboBoxSemestr.SelectedIndex, 4] == 0)
            {
                checkBoxEkz5.Checked = false; //����� ������
            }
            else //����� - ������� ���
            {
                checkBoxEkz5.Checked = true; //���������� ������
                //���� ������
                if (student.ozenki[comboBoxSemestr.SelectedIndex, 4] == 1)
                {
                    checkBoxEkz5neyavka.Checked = true; //���������� ������
                }
                else
                {
                    checkBoxEkz5neyavka.Checked = false; //����� ������
                    //������� ������
                    numericUpDownEkz5.Value = student.ozenki[comboBoxSemestr.SelectedIndex, 4];
                };
            }
            
            
            
            //numericUpDownEkz1.Value = student.ozenki[comboBoxSemestr.SelectedIndex, 0];
            //numericUpDownEkz2.Value = student.ozenki[comboBoxSemestr.SelectedIndex, 1];
            //numericUpDownEkz3.Value = student.ozenki[comboBoxSemestr.SelectedIndex, 2];
            //numericUpDownEkz4.Value = student.ozenki[comboBoxSemestr.SelectedIndex, 3];
            //numericUpDownEkz5.Value = student.ozenki[comboBoxSemestr.SelectedIndex, 4];
        }

        private void checkBoxEkz1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxEkz1.Checked) //���� ������� ���
            {
                //������ �� 2 �� 5, �� ��������� 4
                numericUpDownEkz1.Minimum = 2;
                numericUpDownEkz1.Value = 4;
                //������ ����� �������
                numericUpDownEkz1.Enabled = true;
                //����� ��������� ������
                checkBoxEkz1neyavka.Enabled = true;
            }
            else //����� - �������� �� ����
            {
                //������ 0, ����� �������� ������ �������
                numericUpDownEkz1.Minimum = 0;
                numericUpDownEkz1.Value = 0;
                //������ ������ �������
                numericUpDownEkz1.Enabled = false;
                //������ ������ ���������
                checkBoxEkz1neyavka.Enabled = false;
            };
        }

        private void checkBoxEkz1neyavka_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxEkz1neyavka.Checked) //���� ������
            {
                //������ 1, ����� �������� ������ �������
                numericUpDownEkz1.Minimum = 1;
                numericUpDownEkz1.Value = 1;
                //������� ������ ������
                numericUpDownEkz1.Enabled = false;
            }
            else //����� - ������� ������
            {
                //������ �� 2 �� 5, �� ��������� 4
                numericUpDownEkz1.Minimum = 2;
                numericUpDownEkz1.Value = 4;
                //������ ������ �������
                numericUpDownEkz1.Enabled = true;
            };
        }

        private void checkBoxEkz2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxEkz2.Checked) //���� ������� ���
            {
                //������ �� 2 �� 5, �� ��������� 4
                numericUpDownEkz2.Minimum = 2;
                numericUpDownEkz2.Value = 4;
                //������ ����� �������
                numericUpDownEkz2.Enabled = true;
                //����� ��������� ������
                checkBoxEkz2neyavka.Enabled = true;
            }
            else //����� - �������� �� ����
            {
                //������ 0, ����� �������� ������ �������
                numericUpDownEkz2.Minimum = 0;
                numericUpDownEkz2.Value = 0;
                //������ ������ �������
                numericUpDownEkz2.Enabled = false;
                //������ ������ ���������
                checkBoxEkz2neyavka.Enabled = false;
            };
        }

        private void checkBoxEkz2neyavka_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxEkz2neyavka.Checked) //���� ������
            {
                //������ 1, ����� �������� ������ �������
                numericUpDownEkz2.Minimum = 1;
                numericUpDownEkz2.Value = 1;
                //������� ������ ������
                numericUpDownEkz2.Enabled = false;
            }
            else //����� - ������� ������
            {
                //������ �� 2 �� 5, �� ��������� 4
                numericUpDownEkz2.Minimum = 2;
                numericUpDownEkz2.Value = 4;
                //������ ������ �������
                numericUpDownEkz2.Enabled = true;
            };
        }

        private void checkBoxEkz3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxEkz3.Checked) //���� ������� ���
            {
                //������ �� 2 �� 5, �� ��������� 4
                numericUpDownEkz3.Minimum = 2;
                numericUpDownEkz3.Value = 4;
                //������ ����� �������
                numericUpDownEkz3.Enabled = true;
                //����� ��������� ������
                checkBoxEkz3neyavka.Enabled = true;
            }
            else //����� - �������� �� ����
            {
                //������ 0, ����� �������� ������ �������
                numericUpDownEkz3.Minimum = 0;
                numericUpDownEkz3.Value = 0;
                //������ ������ �������
                numericUpDownEkz3.Enabled = false;
                //������ ������ ���������
                checkBoxEkz3neyavka.Enabled = false;
            };
        }

        private void checkBoxEkz3neyavka_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxEkz3neyavka.Checked) //���� ������
            {
                //������ 1, ����� �������� ������ �������
                numericUpDownEkz3.Minimum = 1;
                numericUpDownEkz3.Value = 1;
                //������� ������ ������
                numericUpDownEkz3.Enabled = false;
            }
            else //����� - ������� ������
            {
                //������ �� 2 �� 5, �� ��������� 4
                numericUpDownEkz3.Minimum = 2;
                numericUpDownEkz3.Value = 4;
                //������ ������ �������
                numericUpDownEkz3.Enabled = true;
            };
        }

        private void checkBoxEkz4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxEkz4.Checked) //���� ������� ���
            {
                //������ �� 2 �� 5, �� ��������� 4
                numericUpDownEkz4.Minimum = 2;
                numericUpDownEkz4.Value = 4;
                //������ ����� �������
                numericUpDownEkz4.Enabled = true;
                //����� ��������� ������
                checkBoxEkz4neyavka.Enabled = true;
            }
            else //����� - �������� �� ����
            {
                //������ 0, ����� �������� ������ �������
                numericUpDownEkz4.Minimum = 0;
                numericUpDownEkz4.Value = 0;
                //������ ������ �������
                numericUpDownEkz4.Enabled = false;
                //������ ������ ���������
                checkBoxEkz4neyavka.Enabled = false;
            };
        }

        private void checkBoxEkz4neyavka_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxEkz4neyavka.Checked) //���� ������
            {
                //������ 1, ����� �������� ������ �������
                numericUpDownEkz4.Minimum = 1;
                numericUpDownEkz4.Value = 1;
                //������� ������ ������
                numericUpDownEkz4.Enabled = false;
            }
            else //����� - ������� ������
            {
                //������ �� 2 �� 5, �� ��������� 4
                numericUpDownEkz4.Minimum = 2;
                numericUpDownEkz4.Value = 4;
                //������ ������ �������
                numericUpDownEkz4.Enabled = true;
            };
        }

        private void checkBoxEkz5_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxEkz5.Checked) //���� ������� ���
            {
                //������ �� 2 �� 5, �� ��������� 4
                numericUpDownEkz5.Minimum = 2;
                numericUpDownEkz5.Value = 4;
                //������ ����� �������
                numericUpDownEkz5.Enabled = true;
                //����� ��������� ������
                checkBoxEkz5neyavka.Enabled = true;
            }
            else //����� - �������� �� ����
            {
                //������ 0, ����� �������� ������ �������
                numericUpDownEkz5.Minimum = 0;
                numericUpDownEkz5.Value = 0;
                //������ ������ �������
                numericUpDownEkz5.Enabled = false;
                //������ ������ ���������
                checkBoxEkz5neyavka.Enabled = false;
            };
        }

        private void checkBoxEkz5neyavka_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxEkz5neyavka.Checked) //���� ������
            {
                //������ 1, ����� �������� ������ �������
                numericUpDownEkz5.Minimum = 1;
                numericUpDownEkz5.Value = 1;
                //������� ������ ������
                numericUpDownEkz5.Enabled = false;
            }
            else //����� - ������� ������
            {
                //������ �� 2 �� 5, �� ��������� 4
                numericUpDownEkz5.Minimum = 2;
                numericUpDownEkz5.Value = 4;
                //������ ������ �������
                numericUpDownEkz5.Enabled = true;
            };
        }

       
    }
}