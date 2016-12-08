namespace Student2005
{
    partial class FormStudent
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelFIO = new System.Windows.Forms.Label();
            this.labelNstud = new System.Windows.Forms.Label();
            this.textBoxFIO = new System.Windows.Forms.TextBox();
            this.textBoxNstud = new System.Windows.Forms.TextBox();
            this.labelKurs = new System.Windows.Forms.Label();
            this.numericUpDownKurs = new System.Windows.Forms.NumericUpDown();
            this.labelGruppa = new System.Windows.Forms.Label();
            this.textBoxGruppa = new System.Windows.Forms.TextBox();
            this.radioButtonBudget = new System.Windows.Forms.RadioButton();
            this.radioButtonCommerce = new System.Windows.Forms.RadioButton();
            this.labelBudget = new System.Windows.Forms.Label();
            this.textBoxStudentInfo = new System.Windows.Forms.TextBox();
            this.comboBoxSemestr = new System.Windows.Forms.ComboBox();
            this.numericUpDownEkz1 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownEkz2 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownEkz3 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownEkz4 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownEkz5 = new System.Windows.Forms.NumericUpDown();
            this.groupBoxOzenki = new System.Windows.Forms.GroupBox();
            this.checkBoxEkz5neyavka = new System.Windows.Forms.CheckBox();
            this.checkBoxEkz4neyavka = new System.Windows.Forms.CheckBox();
            this.checkBoxEkz3neyavka = new System.Windows.Forms.CheckBox();
            this.checkBoxEkz2neyavka = new System.Windows.Forms.CheckBox();
            this.checkBoxEkz1neyavka = new System.Windows.Forms.CheckBox();
            this.checkBoxEkz5 = new System.Windows.Forms.CheckBox();
            this.checkBoxEkz4 = new System.Windows.Forms.CheckBox();
            this.checkBoxEkz3 = new System.Windows.Forms.CheckBox();
            this.checkBoxEkz2 = new System.Windows.Forms.CheckBox();
            this.checkBoxEkz1 = new System.Windows.Forms.CheckBox();
            this.buttonNaSledKurs = new System.Windows.Forms.Button();
            this.labelStoimost = new System.Windows.Forms.Label();
            this.numericUpDownStoimost = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownSum = new System.Windows.Forms.NumericUpDown();
            this.buttonOplatit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownKurs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownEkz1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownEkz2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownEkz3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownEkz4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownEkz5)).BeginInit();
            this.groupBoxOzenki.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownStoimost)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSum)).BeginInit();
            this.SuspendLayout();
            // 
            // labelFIO
            // 
            this.labelFIO.AutoSize = true;
            this.labelFIO.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.labelFIO.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelFIO.Location = new System.Drawing.Point(12, 23);
            this.labelFIO.Name = "labelFIO";
            this.labelFIO.Size = new System.Drawing.Size(49, 20);
            this.labelFIO.TabIndex = 1;
            this.labelFIO.Text = "ФИО";
            // 
            // labelNstud
            // 
            this.labelNstud.AutoSize = true;
            this.labelNstud.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.labelNstud.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelNstud.Location = new System.Drawing.Point(12, 73);
            this.labelNstud.Name = "labelNstud";
            this.labelNstud.Size = new System.Drawing.Size(220, 20);
            this.labelNstud.TabIndex = 3;
            this.labelNstud.Text = "№ студенческого билета";
            // 
            // textBoxFIO
            // 
            this.textBoxFIO.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxFIO.Location = new System.Drawing.Point(67, 23);
            this.textBoxFIO.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxFIO.Name = "textBoxFIO";
            this.textBoxFIO.Size = new System.Drawing.Size(620, 27);
            this.textBoxFIO.TabIndex = 5;
            this.textBoxFIO.TextChanged += new System.EventHandler(this.textBoxFIO_TextChanged);
            // 
            // textBoxNstud
            // 
            this.textBoxNstud.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxNstud.Location = new System.Drawing.Point(264, 75);
            this.textBoxNstud.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxNstud.Name = "textBoxNstud";
            this.textBoxNstud.Size = new System.Drawing.Size(93, 27);
            this.textBoxNstud.TabIndex = 6;
            this.textBoxNstud.Text = "000000";
            this.textBoxNstud.TextChanged += new System.EventHandler(this.textBoxNstud_TextChanged);
            // 
            // labelKurs
            // 
            this.labelKurs.AutoSize = true;
            this.labelKurs.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelKurs.Location = new System.Drawing.Point(385, 75);
            this.labelKurs.Name = "labelKurs";
            this.labelKurs.Size = new System.Drawing.Size(47, 20);
            this.labelKurs.TabIndex = 7;
            this.labelKurs.Text = "Курс";
            // 
            // numericUpDownKurs
            // 
            this.numericUpDownKurs.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numericUpDownKurs.Location = new System.Drawing.Point(456, 71);
            this.numericUpDownKurs.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numericUpDownKurs.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.numericUpDownKurs.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownKurs.Name = "numericUpDownKurs";
            this.numericUpDownKurs.Size = new System.Drawing.Size(51, 27);
            this.numericUpDownKurs.TabIndex = 8;
            this.numericUpDownKurs.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownKurs.ValueChanged += new System.EventHandler(this.numericUpDownKurs_ValueChanged);
            // 
            // labelGruppa
            // 
            this.labelGruppa.AutoSize = true;
            this.labelGruppa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelGruppa.Location = new System.Drawing.Point(515, 71);
            this.labelGruppa.Name = "labelGruppa";
            this.labelGruppa.Size = new System.Drawing.Size(67, 20);
            this.labelGruppa.TabIndex = 9;
            this.labelGruppa.Text = "Группа";
            // 
            // textBoxGruppa
            // 
            this.textBoxGruppa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxGruppa.Location = new System.Drawing.Point(587, 73);
            this.textBoxGruppa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxGruppa.Name = "textBoxGruppa";
            this.textBoxGruppa.Size = new System.Drawing.Size(100, 27);
            this.textBoxGruppa.TabIndex = 10;
            this.textBoxGruppa.TextChanged += new System.EventHandler(this.textBoxGruppa_TextChanged);
            // 
            // radioButtonBudget
            // 
            this.radioButtonBudget.AutoSize = true;
            this.radioButtonBudget.Checked = true;
            this.radioButtonBudget.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButtonBudget.Location = new System.Drawing.Point(153, 124);
            this.radioButtonBudget.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioButtonBudget.Name = "radioButtonBudget";
            this.radioButtonBudget.Size = new System.Drawing.Size(203, 28);
            this.radioButtonBudget.TabIndex = 11;
            this.radioButtonBudget.TabStop = true;
            this.radioButtonBudget.Text = "бюджетной основе";
            this.radioButtonBudget.UseVisualStyleBackColor = true;
            this.radioButtonBudget.CheckedChanged += new System.EventHandler(this.radioButtonBudget_CheckedChanged);
            // 
            // radioButtonCommerce
            // 
            this.radioButtonCommerce.AutoSize = true;
            this.radioButtonCommerce.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButtonCommerce.Location = new System.Drawing.Point(153, 156);
            this.radioButtonCommerce.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioButtonCommerce.Name = "radioButtonCommerce";
            this.radioButtonCommerce.Size = new System.Drawing.Size(228, 28);
            this.radioButtonCommerce.TabIndex = 12;
            this.radioButtonCommerce.Text = "коммерческой основе";
            this.radioButtonCommerce.UseVisualStyleBackColor = true;
            // 
            // labelBudget
            // 
            this.labelBudget.AutoSize = true;
            this.labelBudget.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelBudget.Location = new System.Drawing.Point(19, 124);
            this.labelBudget.Name = "labelBudget";
            this.labelBudget.Size = new System.Drawing.Size(124, 20);
            this.labelBudget.TabIndex = 13;
            this.labelBudget.Text = "Обучается на";
            // 
            // textBoxStudentInfo
            // 
            this.textBoxStudentInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxStudentInfo.Location = new System.Drawing.Point(16, 338);
            this.textBoxStudentInfo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxStudentInfo.Multiline = true;
            this.textBoxStudentInfo.Name = "textBoxStudentInfo";
            this.textBoxStudentInfo.ReadOnly = true;
            this.textBoxStudentInfo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxStudentInfo.Size = new System.Drawing.Size(824, 292);
            this.textBoxStudentInfo.TabIndex = 14;
            // 
            // comboBoxSemestr
            // 
            this.comboBoxSemestr.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSemestr.FormattingEnabled = true;
            this.comboBoxSemestr.Items.AddRange(new object[] {
            "1 семестр",
            "2 семестр"});
            this.comboBoxSemestr.Location = new System.Drawing.Point(620, 52);
            this.comboBoxSemestr.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxSemestr.Name = "comboBoxSemestr";
            this.comboBoxSemestr.Size = new System.Drawing.Size(199, 28);
            this.comboBoxSemestr.TabIndex = 15;
            this.comboBoxSemestr.SelectedIndexChanged += new System.EventHandler(this.comboBoxSemestr_SelectedIndexChanged);
            // 
            // numericUpDownEkz1
            // 
            this.numericUpDownEkz1.Location = new System.Drawing.Point(13, 58);
            this.numericUpDownEkz1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numericUpDownEkz1.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDownEkz1.Name = "numericUpDownEkz1";
            this.numericUpDownEkz1.Size = new System.Drawing.Size(64, 26);
            this.numericUpDownEkz1.TabIndex = 16;
            this.numericUpDownEkz1.ValueChanged += new System.EventHandler(this.numericUpDownEkz1_ValueChanged);
            // 
            // numericUpDownEkz2
            // 
            this.numericUpDownEkz2.Location = new System.Drawing.Point(137, 58);
            this.numericUpDownEkz2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numericUpDownEkz2.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDownEkz2.Name = "numericUpDownEkz2";
            this.numericUpDownEkz2.Size = new System.Drawing.Size(64, 26);
            this.numericUpDownEkz2.TabIndex = 17;
            this.numericUpDownEkz2.ValueChanged += new System.EventHandler(this.numericUpDownEkz2_ValueChanged);
            // 
            // numericUpDownEkz3
            // 
            this.numericUpDownEkz3.Location = new System.Drawing.Point(267, 58);
            this.numericUpDownEkz3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numericUpDownEkz3.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDownEkz3.Name = "numericUpDownEkz3";
            this.numericUpDownEkz3.Size = new System.Drawing.Size(64, 26);
            this.numericUpDownEkz3.TabIndex = 18;
            this.numericUpDownEkz3.ValueChanged += new System.EventHandler(this.numericUpDownEkz3_ValueChanged);
            // 
            // numericUpDownEkz4
            // 
            this.numericUpDownEkz4.Location = new System.Drawing.Point(395, 58);
            this.numericUpDownEkz4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numericUpDownEkz4.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDownEkz4.Name = "numericUpDownEkz4";
            this.numericUpDownEkz4.Size = new System.Drawing.Size(64, 26);
            this.numericUpDownEkz4.TabIndex = 19;
            this.numericUpDownEkz4.ValueChanged += new System.EventHandler(this.numericUpDownEkz4_ValueChanged);
            // 
            // numericUpDownEkz5
            // 
            this.numericUpDownEkz5.Location = new System.Drawing.Point(529, 54);
            this.numericUpDownEkz5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numericUpDownEkz5.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDownEkz5.Name = "numericUpDownEkz5";
            this.numericUpDownEkz5.Size = new System.Drawing.Size(64, 26);
            this.numericUpDownEkz5.TabIndex = 20;
            this.numericUpDownEkz5.ValueChanged += new System.EventHandler(this.numericUpDownEkz5_ValueChanged);
            // 
            // groupBoxOzenki
            // 
            this.groupBoxOzenki.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.groupBoxOzenki.Controls.Add(this.checkBoxEkz5neyavka);
            this.groupBoxOzenki.Controls.Add(this.checkBoxEkz4neyavka);
            this.groupBoxOzenki.Controls.Add(this.checkBoxEkz3neyavka);
            this.groupBoxOzenki.Controls.Add(this.checkBoxEkz2neyavka);
            this.groupBoxOzenki.Controls.Add(this.checkBoxEkz1neyavka);
            this.groupBoxOzenki.Controls.Add(this.checkBoxEkz5);
            this.groupBoxOzenki.Controls.Add(this.checkBoxEkz4);
            this.groupBoxOzenki.Controls.Add(this.checkBoxEkz3);
            this.groupBoxOzenki.Controls.Add(this.checkBoxEkz2);
            this.groupBoxOzenki.Controls.Add(this.checkBoxEkz1);
            this.groupBoxOzenki.Controls.Add(this.comboBoxSemestr);
            this.groupBoxOzenki.Controls.Add(this.numericUpDownEkz1);
            this.groupBoxOzenki.Controls.Add(this.numericUpDownEkz5);
            this.groupBoxOzenki.Controls.Add(this.numericUpDownEkz2);
            this.groupBoxOzenki.Controls.Add(this.numericUpDownEkz4);
            this.groupBoxOzenki.Controls.Add(this.numericUpDownEkz3);
            this.groupBoxOzenki.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxOzenki.Location = new System.Drawing.Point(16, 198);
            this.groupBoxOzenki.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxOzenki.Name = "groupBoxOzenki";
            this.groupBoxOzenki.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxOzenki.Size = new System.Drawing.Size(825, 127);
            this.groupBoxOzenki.TabIndex = 21;
            this.groupBoxOzenki.TabStop = false;
            this.groupBoxOzenki.Text = "Оценки за экземен";
            // 
            // checkBoxEkz5neyavka
            // 
            this.checkBoxEkz5neyavka.AutoSize = true;
            this.checkBoxEkz5neyavka.Location = new System.Drawing.Point(529, 94);
            this.checkBoxEkz5neyavka.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkBoxEkz5neyavka.Name = "checkBoxEkz5neyavka";
            this.checkBoxEkz5neyavka.Size = new System.Drawing.Size(87, 24);
            this.checkBoxEkz5neyavka.TabIndex = 30;
            this.checkBoxEkz5neyavka.Text = "неявка";
            this.checkBoxEkz5neyavka.UseVisualStyleBackColor = true;
            this.checkBoxEkz5neyavka.CheckedChanged += new System.EventHandler(this.checkBoxEkz5neyavka_CheckedChanged);
            // 
            // checkBoxEkz4neyavka
            // 
            this.checkBoxEkz4neyavka.AutoSize = true;
            this.checkBoxEkz4neyavka.Location = new System.Drawing.Point(395, 94);
            this.checkBoxEkz4neyavka.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkBoxEkz4neyavka.Name = "checkBoxEkz4neyavka";
            this.checkBoxEkz4neyavka.Size = new System.Drawing.Size(87, 24);
            this.checkBoxEkz4neyavka.TabIndex = 29;
            this.checkBoxEkz4neyavka.Text = "неявка";
            this.checkBoxEkz4neyavka.UseVisualStyleBackColor = true;
            this.checkBoxEkz4neyavka.CheckedChanged += new System.EventHandler(this.checkBoxEkz4neyavka_CheckedChanged);
            // 
            // checkBoxEkz3neyavka
            // 
            this.checkBoxEkz3neyavka.AutoSize = true;
            this.checkBoxEkz3neyavka.Location = new System.Drawing.Point(267, 94);
            this.checkBoxEkz3neyavka.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkBoxEkz3neyavka.Name = "checkBoxEkz3neyavka";
            this.checkBoxEkz3neyavka.Size = new System.Drawing.Size(87, 24);
            this.checkBoxEkz3neyavka.TabIndex = 28;
            this.checkBoxEkz3neyavka.Text = "неявка";
            this.checkBoxEkz3neyavka.UseVisualStyleBackColor = true;
            this.checkBoxEkz3neyavka.CheckedChanged += new System.EventHandler(this.checkBoxEkz3neyavka_CheckedChanged);
            // 
            // checkBoxEkz2neyavka
            // 
            this.checkBoxEkz2neyavka.AutoSize = true;
            this.checkBoxEkz2neyavka.Location = new System.Drawing.Point(127, 94);
            this.checkBoxEkz2neyavka.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkBoxEkz2neyavka.Name = "checkBoxEkz2neyavka";
            this.checkBoxEkz2neyavka.Size = new System.Drawing.Size(87, 24);
            this.checkBoxEkz2neyavka.TabIndex = 27;
            this.checkBoxEkz2neyavka.Text = "неявка";
            this.checkBoxEkz2neyavka.UseVisualStyleBackColor = true;
            this.checkBoxEkz2neyavka.CheckedChanged += new System.EventHandler(this.checkBoxEkz2neyavka_CheckedChanged);
            // 
            // checkBoxEkz1neyavka
            // 
            this.checkBoxEkz1neyavka.AutoSize = true;
            this.checkBoxEkz1neyavka.Location = new System.Drawing.Point(13, 94);
            this.checkBoxEkz1neyavka.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkBoxEkz1neyavka.Name = "checkBoxEkz1neyavka";
            this.checkBoxEkz1neyavka.Size = new System.Drawing.Size(87, 24);
            this.checkBoxEkz1neyavka.TabIndex = 26;
            this.checkBoxEkz1neyavka.Text = "неявка";
            this.checkBoxEkz1neyavka.UseVisualStyleBackColor = true;
            this.checkBoxEkz1neyavka.CheckedChanged += new System.EventHandler(this.checkBoxEkz1neyavka_CheckedChanged);
            // 
            // checkBoxEkz5
            // 
            this.checkBoxEkz5.AutoSize = true;
            this.checkBoxEkz5.Checked = true;
            this.checkBoxEkz5.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxEkz5.Location = new System.Drawing.Point(529, 23);
            this.checkBoxEkz5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkBoxEkz5.Name = "checkBoxEkz5";
            this.checkBoxEkz5.Size = new System.Drawing.Size(110, 24);
            this.checkBoxEkz5.TabIndex = 25;
            this.checkBoxEkz5.Text = "Экзамен5";
            this.checkBoxEkz5.UseVisualStyleBackColor = true;
            this.checkBoxEkz5.CheckedChanged += new System.EventHandler(this.checkBoxEkz5_CheckedChanged);
            // 
            // checkBoxEkz4
            // 
            this.checkBoxEkz4.AutoSize = true;
            this.checkBoxEkz4.Checked = true;
            this.checkBoxEkz4.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxEkz4.Location = new System.Drawing.Point(395, 23);
            this.checkBoxEkz4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkBoxEkz4.Name = "checkBoxEkz4";
            this.checkBoxEkz4.Size = new System.Drawing.Size(115, 24);
            this.checkBoxEkz4.TabIndex = 24;
            this.checkBoxEkz4.Text = "Экзамен 4";
            this.checkBoxEkz4.UseVisualStyleBackColor = true;
            this.checkBoxEkz4.CheckedChanged += new System.EventHandler(this.checkBoxEkz4_CheckedChanged);
            // 
            // checkBoxEkz3
            // 
            this.checkBoxEkz3.AutoSize = true;
            this.checkBoxEkz3.Checked = true;
            this.checkBoxEkz3.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxEkz3.Location = new System.Drawing.Point(267, 23);
            this.checkBoxEkz3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkBoxEkz3.Name = "checkBoxEkz3";
            this.checkBoxEkz3.Size = new System.Drawing.Size(110, 24);
            this.checkBoxEkz3.TabIndex = 23;
            this.checkBoxEkz3.Text = "Экзамен3";
            this.checkBoxEkz3.UseVisualStyleBackColor = true;
            this.checkBoxEkz3.CheckedChanged += new System.EventHandler(this.checkBoxEkz3_CheckedChanged);
            // 
            // checkBoxEkz2
            // 
            this.checkBoxEkz2.AutoSize = true;
            this.checkBoxEkz2.Checked = true;
            this.checkBoxEkz2.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxEkz2.Location = new System.Drawing.Point(137, 23);
            this.checkBoxEkz2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkBoxEkz2.Name = "checkBoxEkz2";
            this.checkBoxEkz2.Size = new System.Drawing.Size(110, 24);
            this.checkBoxEkz2.TabIndex = 22;
            this.checkBoxEkz2.Text = "Экзамен2";
            this.checkBoxEkz2.UseVisualStyleBackColor = true;
            this.checkBoxEkz2.CheckedChanged += new System.EventHandler(this.checkBoxEkz2_CheckedChanged);
            // 
            // checkBoxEkz1
            // 
            this.checkBoxEkz1.AutoSize = true;
            this.checkBoxEkz1.Checked = true;
            this.checkBoxEkz1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxEkz1.Location = new System.Drawing.Point(13, 25);
            this.checkBoxEkz1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkBoxEkz1.Name = "checkBoxEkz1";
            this.checkBoxEkz1.Size = new System.Drawing.Size(110, 24);
            this.checkBoxEkz1.TabIndex = 21;
            this.checkBoxEkz1.Text = "Экзамен1";
            this.checkBoxEkz1.UseVisualStyleBackColor = true;
            this.checkBoxEkz1.CheckedChanged += new System.EventHandler(this.checkBoxEkz1_CheckedChanged);
            // 
            // buttonNaSledKurs
            // 
            this.buttonNaSledKurs.Location = new System.Drawing.Point(16, 642);
            this.buttonNaSledKurs.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonNaSledKurs.Name = "buttonNaSledKurs";
            this.buttonNaSledKurs.Size = new System.Drawing.Size(100, 28);
            this.buttonNaSledKurs.TabIndex = 22;
            this.buttonNaSledKurs.Text = "Перевести на следующий курс";
            this.buttonNaSledKurs.UseVisualStyleBackColor = true;
            this.buttonNaSledKurs.Click += new System.EventHandler(this.buttonNaSledKurs_Click);
            // 
            // labelStoimost
            // 
            this.labelStoimost.AutoSize = true;
            this.labelStoimost.Location = new System.Drawing.Point(408, 156);
            this.labelStoimost.Name = "labelStoimost";
            this.labelStoimost.Size = new System.Drawing.Size(145, 17);
            this.labelStoimost.TabIndex = 23;
            this.labelStoimost.Text = "Стоимость обучения";
            // 
            // numericUpDownStoimost
            // 
            this.numericUpDownStoimost.DecimalPlaces = 2;
            this.numericUpDownStoimost.Location = new System.Drawing.Point(411, 176);
            this.numericUpDownStoimost.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numericUpDownStoimost.Name = "numericUpDownStoimost";
            this.numericUpDownStoimost.Size = new System.Drawing.Size(120, 22);
            this.numericUpDownStoimost.TabIndex = 24;
            this.numericUpDownStoimost.Visible = false;
            this.numericUpDownStoimost.ValueChanged += new System.EventHandler(this.numericUpDownStoimost_ValueChanged);
            // 
            // numericUpDownSum
            // 
            this.numericUpDownSum.Location = new System.Drawing.Point(546, 176);
            this.numericUpDownSum.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numericUpDownSum.Name = "numericUpDownSum";
            this.numericUpDownSum.Size = new System.Drawing.Size(120, 22);
            this.numericUpDownSum.TabIndex = 25;
            this.numericUpDownSum.Visible = false;
            // 
            // buttonOplatit
            // 
            this.buttonOplatit.Location = new System.Drawing.Point(688, 176);
            this.buttonOplatit.Name = "buttonOplatit";
            this.buttonOplatit.Size = new System.Drawing.Size(95, 22);
            this.buttonOplatit.TabIndex = 26;
            this.buttonOplatit.Text = "Оплатить";
            this.buttonOplatit.UseVisualStyleBackColor = true;
            this.buttonOplatit.Visible = false;
            this.buttonOplatit.Click += new System.EventHandler(this.buttonOplatit_Click);
            // 
            // FormStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(856, 683);
            this.Controls.Add(this.buttonOplatit);
            this.Controls.Add(this.numericUpDownSum);
            this.Controls.Add(this.numericUpDownStoimost);
            this.Controls.Add(this.labelStoimost);
            this.Controls.Add(this.buttonNaSledKurs);
            this.Controls.Add(this.groupBoxOzenki);
            this.Controls.Add(this.textBoxStudentInfo);
            this.Controls.Add(this.labelBudget);
            this.Controls.Add(this.radioButtonCommerce);
            this.Controls.Add(this.radioButtonBudget);
            this.Controls.Add(this.textBoxGruppa);
            this.Controls.Add(this.labelGruppa);
            this.Controls.Add(this.numericUpDownKurs);
            this.Controls.Add(this.labelKurs);
            this.Controls.Add(this.textBoxNstud);
            this.Controls.Add(this.textBoxFIO);
            this.Controls.Add(this.labelNstud);
            this.Controls.Add(this.labelFIO);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormStudent";
            this.Text = "Студент";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownKurs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownEkz1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownEkz2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownEkz3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownEkz4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownEkz5)).EndInit();
            this.groupBoxOzenki.ResumeLayout(false);
            this.groupBoxOzenki.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownStoimost)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSum)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelFIO;
        private System.Windows.Forms.Label labelNstud;
        private System.Windows.Forms.TextBox textBoxFIO;
        private System.Windows.Forms.TextBox textBoxNstud;
        private System.Windows.Forms.Label labelKurs;
        private System.Windows.Forms.NumericUpDown numericUpDownKurs;
        private System.Windows.Forms.Label labelGruppa;
        private System.Windows.Forms.TextBox textBoxGruppa;
        private System.Windows.Forms.RadioButton radioButtonBudget;
        private System.Windows.Forms.RadioButton radioButtonCommerce;
        private System.Windows.Forms.Label labelBudget;
        private System.Windows.Forms.TextBox textBoxStudentInfo;
        private System.Windows.Forms.ComboBox comboBoxSemestr;
        private System.Windows.Forms.NumericUpDown numericUpDownEkz1;
        private System.Windows.Forms.NumericUpDown numericUpDownEkz2;
        private System.Windows.Forms.NumericUpDown numericUpDownEkz3;
        private System.Windows.Forms.NumericUpDown numericUpDownEkz4;
        private System.Windows.Forms.NumericUpDown numericUpDownEkz5;
        private System.Windows.Forms.GroupBox groupBoxOzenki;
        private System.Windows.Forms.CheckBox checkBoxEkz5neyavka;
        private System.Windows.Forms.CheckBox checkBoxEkz4neyavka;
        private System.Windows.Forms.CheckBox checkBoxEkz3neyavka;
        private System.Windows.Forms.CheckBox checkBoxEkz2neyavka;
        private System.Windows.Forms.CheckBox checkBoxEkz1neyavka;
        private System.Windows.Forms.CheckBox checkBoxEkz5;
        private System.Windows.Forms.CheckBox checkBoxEkz4;
        private System.Windows.Forms.CheckBox checkBoxEkz3;
        private System.Windows.Forms.CheckBox checkBoxEkz2;
        private System.Windows.Forms.CheckBox checkBoxEkz1;
        private System.Windows.Forms.Button buttonNaSledKurs;
        private System.Windows.Forms.Label labelStoimost;
        private System.Windows.Forms.NumericUpDown numericUpDownStoimost;
        private System.Windows.Forms.NumericUpDown numericUpDownSum;
        private System.Windows.Forms.Button buttonOplatit;
    }
}

