namespace Task3_Employees
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBoxFIO = new System.Windows.Forms.TextBox();
            this.labelFIO = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dateTimePickerBirthday = new System.Windows.Forms.DateTimePicker();
            this.labelBirthday = new System.Windows.Forms.Label();
            this.labelPosition = new System.Windows.Forms.Label();
            this.comboBoxPosition = new System.Windows.Forms.ComboBox();
            this.labelSalary = new System.Windows.Forms.Label();
            this.textBoxSalary = new System.Windows.Forms.TextBox();
            this.checkBoxMoonlight = new System.Windows.Forms.CheckBox();
            this.textBoxEmployeesInfo = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxFIO
            // 
            this.textBoxFIO.Location = new System.Drawing.Point(10, 39);
            this.textBoxFIO.Name = "textBoxFIO";
            this.textBoxFIO.Size = new System.Drawing.Size(489, 20);
            this.textBoxFIO.TabIndex = 0;
            this.textBoxFIO.UseWaitCursor = true;
            this.textBoxFIO.TextChanged += new System.EventHandler(this.textBoxFIO_TextChanged);
            // 
            // labelFIO
            // 
            this.labelFIO.AutoSize = true;
            this.labelFIO.Location = new System.Drawing.Point(7, 11);
            this.labelFIO.Name = "labelFIO";
            this.labelFIO.Size = new System.Drawing.Size(131, 13);
            this.labelFIO.TabIndex = 1;
            this.labelFIO.Text = "Фамилия Имя Отчество";
            this.labelFIO.UseWaitCursor = true;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.checkBoxMoonlight);
            this.panel1.Controls.Add(this.textBoxSalary);
            this.panel1.Controls.Add(this.labelSalary);
            this.panel1.Controls.Add(this.comboBoxPosition);
            this.panel1.Controls.Add(this.labelPosition);
            this.panel1.Controls.Add(this.labelBirthday);
            this.panel1.Controls.Add(this.dateTimePickerBirthday);
            this.panel1.Controls.Add(this.textBoxFIO);
            this.panel1.Controls.Add(this.labelFIO);
            this.panel1.Location = new System.Drawing.Point(8, 10);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(508, 170);
            this.panel1.TabIndex = 2;
            this.panel1.Tag = "";
            this.panel1.UseWaitCursor = true;
            // 
            // dateTimePickerBirthday
            // 
            this.dateTimePickerBirthday.Location = new System.Drawing.Point(110, 65);
            this.dateTimePickerBirthday.Name = "dateTimePickerBirthday";
            this.dateTimePickerBirthday.Size = new System.Drawing.Size(153, 20);
            this.dateTimePickerBirthday.TabIndex = 2;
            this.dateTimePickerBirthday.UseWaitCursor = true;
            this.dateTimePickerBirthday.ValueChanged += new System.EventHandler(this.dateTimePickerBirthday_ValueChanged);
            // 
            // labelBirthday
            // 
            this.labelBirthday.AutoSize = true;
            this.labelBirthday.Location = new System.Drawing.Point(7, 71);
            this.labelBirthday.Name = "labelBirthday";
            this.labelBirthday.Size = new System.Drawing.Size(87, 13);
            this.labelBirthday.TabIndex = 3;
            this.labelBirthday.Text = "День рождения";
            this.labelBirthday.UseWaitCursor = true;
            // 
            // labelPosition
            // 
            this.labelPosition.AutoSize = true;
            this.labelPosition.Location = new System.Drawing.Point(7, 108);
            this.labelPosition.Name = "labelPosition";
            this.labelPosition.Size = new System.Drawing.Size(65, 13);
            this.labelPosition.TabIndex = 4;
            this.labelPosition.Text = "Должность";
            this.labelPosition.UseWaitCursor = true;
            // 
            // comboBoxPosition
            // 
            this.comboBoxPosition.FormattingEnabled = true;
            this.comboBoxPosition.Location = new System.Drawing.Point(110, 102);
            this.comboBoxPosition.Name = "comboBoxPosition";
            this.comboBoxPosition.Size = new System.Drawing.Size(153, 21);
            this.comboBoxPosition.TabIndex = 5;
            this.comboBoxPosition.UseWaitCursor = true;
            // 
            // labelSalary
            // 
            this.labelSalary.AutoSize = true;
            this.labelSalary.Location = new System.Drawing.Point(7, 143);
            this.labelSalary.Name = "labelSalary";
            this.labelSalary.Size = new System.Drawing.Size(39, 13);
            this.labelSalary.TabIndex = 6;
            this.labelSalary.Text = "Оклад";
            this.labelSalary.UseWaitCursor = true;
            // 
            // textBoxSalary
            // 
            this.textBoxSalary.Location = new System.Drawing.Point(110, 136);
            this.textBoxSalary.Name = "textBoxSalary";
            this.textBoxSalary.Size = new System.Drawing.Size(100, 20);
            this.textBoxSalary.TabIndex = 7;
            this.textBoxSalary.UseWaitCursor = true;
            // 
            // checkBoxMoonlight
            // 
            this.checkBoxMoonlight.Location = new System.Drawing.Point(293, 108);
            this.checkBoxMoonlight.Name = "checkBoxMoonlight";
            this.checkBoxMoonlight.Size = new System.Drawing.Size(206, 24);
            this.checkBoxMoonlight.TabIndex = 8;
            this.checkBoxMoonlight.Text = "Работает по совместительству";
            this.checkBoxMoonlight.UseVisualStyleBackColor = true;
            this.checkBoxMoonlight.UseWaitCursor = true;
            this.checkBoxMoonlight.CheckedChanged += new System.EventHandler(this.checkBoxMoonlight_CheckedChanged);
            // 
            // textBoxEmployeesInfo
            // 
            this.textBoxEmployeesInfo.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxEmployeesInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxEmployeesInfo.Location = new System.Drawing.Point(8, 186);
            this.textBoxEmployeesInfo.Multiline = true;
            this.textBoxEmployeesInfo.Name = "textBoxEmployeesInfo";
            this.textBoxEmployeesInfo.ReadOnly = true;
            this.textBoxEmployeesInfo.Size = new System.Drawing.Size(508, 240);
            this.textBoxEmployeesInfo.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(520, 430);
            this.Controls.Add(this.textBoxEmployeesInfo);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxFIO;
        private System.Windows.Forms.Label labelFIO;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DateTimePicker dateTimePickerBirthday;
        private System.Windows.Forms.CheckBox checkBoxMoonlight;
        private System.Windows.Forms.TextBox textBoxSalary;
        private System.Windows.Forms.Label labelSalary;
        private System.Windows.Forms.ComboBox comboBoxPosition;
        private System.Windows.Forms.Label labelPosition;
        private System.Windows.Forms.Label labelBirthday;
        private System.Windows.Forms.TextBox textBoxEmployeesInfo;
    }
}

