namespace HotelGestSystem.Presentation.Desktop.Forms
{
    partial class NewReservationForm
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
            monthCalendar1 = new MonthCalendar();
            groupBox1 = new GroupBox();
            button1 = new Button();
            label3 = new Label();
            label1 = new Label();
            dateTimePicker2 = new DateTimePicker();
            dateTimePicker1 = new DateTimePicker();
            groupBox2 = new GroupBox();
            button2 = new Button();
            textBox4 = new TextBox();
            label9 = new Label();
            label2 = new Label();
            textBox3 = new TextBox();
            label4 = new Label();
            label8 = new Label();
            textBox2 = new TextBox();
            label7 = new Label();
            numericUpDown2 = new NumericUpDown();
            numericUpDown1 = new NumericUpDown();
            textBox1 = new TextBox();
            label6 = new Label();
            groupBox3 = new GroupBox();
            label11 = new Label();
            comboBox2 = new ComboBox();
            textBox5 = new TextBox();
            label5 = new Label();
            textBox6 = new TextBox();
            label10 = new Label();
            comboBox1 = new ComboBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // monthCalendar1
            // 
            monthCalendar1.FirstDayOfWeek = Day.Sunday;
            monthCalendar1.ForeColor = Color.OrangeRed;
            monthCalendar1.Location = new Point(16, 282);
            monthCalendar1.MaxSelectionCount = 30;
            monthCalendar1.Name = "monthCalendar1";
            monthCalendar1.ShowToday = false;
            monthCalendar1.TabIndex = 1;
            monthCalendar1.TitleForeColor = Color.DarkRed;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label11);
            groupBox1.Controls.Add(comboBox2);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(dateTimePicker2);
            groupBox1.Controls.Add(dateTimePicker1);
            groupBox1.Controls.Add(monthCalendar1);
            groupBox1.Location = new Point(22, 39);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(276, 458);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Datos de Reserva";
            // 
            // button1
            // 
            button1.ForeColor = Color.Black;
            button1.Location = new Point(151, 22);
            button1.Name = "button1";
            button1.Size = new Size(113, 23);
            button1.TabIndex = 8;
            button1.Text = "Ver disponibilidad";
            button1.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = SystemColors.WindowText;
            label3.Location = new Point(16, 165);
            label3.Name = "label3";
            label3.Size = new Size(38, 15);
            label3.TabIndex = 6;
            label3.Text = "Salida";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.WindowText;
            label1.Location = new Point(16, 123);
            label1.Name = "label1";
            label1.Size = new Size(39, 15);
            label1.TabIndex = 6;
            label1.Text = "Arrivo";
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.CustomFormat = "dddd, dd/MM/yyyy";
            dateTimePicker2.Format = DateTimePickerFormat.Custom;
            dateTimePicker2.Location = new Point(82, 159);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(171, 23);
            dateTimePicker2.TabIndex = 4;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CustomFormat = "dddd, dd/MM/yyyy";
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.Location = new Point(82, 117);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(171, 23);
            dateTimePicker1.TabIndex = 3;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(button2);
            groupBox2.Controls.Add(textBox4);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(textBox3);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(textBox2);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(numericUpDown2);
            groupBox2.Controls.Add(numericUpDown1);
            groupBox2.Controls.Add(textBox1);
            groupBox2.Controls.Add(label6);
            groupBox2.Location = new Point(311, 39);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(287, 458);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            groupBox2.Text = "Datos del Huésped";
            // 
            // button2
            // 
            button2.Location = new Point(226, 26);
            button2.Name = "button2";
            button2.Size = new Size(40, 24);
            button2.TabIndex = 8;
            button2.Text = "...";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(73, 138);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(193, 23);
            textBox4.TabIndex = 7;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.ForeColor = SystemColors.WindowText;
            label9.Location = new Point(13, 144);
            label9.Name = "label9";
            label9.Size = new Size(34, 15);
            label9.TabIndex = 6;
            label9.Text = "Telef.";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.WindowText;
            label2.Location = new Point(170, 192);
            label2.Name = "label2";
            label2.Size = new Size(38, 15);
            label2.TabIndex = 6;
            label2.Text = "Niños";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(73, 101);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(193, 23);
            textBox3.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = SystemColors.WindowText;
            label4.Location = new Point(14, 192);
            label4.Name = "label4";
            label4.Size = new Size(48, 15);
            label4.TabIndex = 6;
            label4.Text = "Adultos";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.ForeColor = SystemColors.WindowText;
            label8.Location = new Point(13, 106);
            label8.Name = "label8";
            label8.Size = new Size(36, 15);
            label8.TabIndex = 4;
            label8.Text = "Email";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(73, 64);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(193, 23);
            textBox2.TabIndex = 3;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.ForeColor = SystemColors.WindowText;
            label7.Location = new Point(13, 68);
            label7.Name = "label7";
            label7.Size = new Size(51, 15);
            label7.TabIndex = 2;
            label7.Text = "Nombre";
            // 
            // numericUpDown2
            // 
            numericUpDown2.Location = new Point(214, 187);
            numericUpDown2.Name = "numericUpDown2";
            numericUpDown2.Size = new Size(52, 23);
            numericUpDown2.TabIndex = 5;
            numericUpDown2.TextAlign = HorizontalAlignment.Center;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(73, 187);
            numericUpDown1.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(52, 23);
            numericUpDown1.TabIndex = 5;
            numericUpDown1.TextAlign = HorizontalAlignment.Center;
            numericUpDown1.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // textBox1
            // 
            textBox1.Location = new Point(73, 27);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(147, 23);
            textBox1.TabIndex = 1;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = SystemColors.WindowText;
            label6.Location = new Point(13, 30);
            label6.Name = "label6";
            label6.Size = new Size(27, 15);
            label6.TabIndex = 0;
            label6.Text = "DNI";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(comboBox1);
            groupBox3.Controls.Add(textBox6);
            groupBox3.Controls.Add(label10);
            groupBox3.Controls.Add(textBox5);
            groupBox3.Controls.Add(label5);
            groupBox3.Location = new Point(612, 39);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(276, 458);
            groupBox3.TabIndex = 4;
            groupBox3.TabStop = false;
            groupBox3.Text = "Datos del Pago";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.ForeColor = SystemColors.WindowText;
            label11.Location = new Point(16, 79);
            label11.Name = "label11";
            label11.Size = new Size(58, 15);
            label11.TabIndex = 11;
            label11.Text = "Nro. Hab.";
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(82, 75);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(171, 23);
            comboBox2.TabIndex = 10;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(123, 105);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(120, 23);
            textBox5.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = SystemColors.WindowText;
            label5.Location = new Point(6, 108);
            label5.Name = "label5";
            label5.Size = new Size(95, 15);
            label5.TabIndex = 9;
            label5.Text = "Pago Anticipado";
            // 
            // textBox6
            // 
            textBox6.Location = new Point(59, 266);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(120, 23);
            textBox6.TabIndex = 12;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.ForeColor = SystemColors.WindowText;
            label10.Location = new Point(6, 159);
            label10.Name = "label10";
            label10.Size = new Size(87, 15);
            label10.TabIndex = 11;
            label10.Text = "Forma de Pago";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(123, 159);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(120, 23);
            comboBox1.TabIndex = 12;
            // 
            // NewReservationForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(904, 532);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            ForeColor = SystemColors.WindowText;
            Name = "NewReservationForm";
            Padding = new Padding(5);
            Text = "NewReservationForm";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private MonthCalendar monthCalendar1;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private Label label2;
        private Label label1;
        private NumericUpDown numericUpDown2;
        private NumericUpDown numericUpDown1;
        private DateTimePicker dateTimePicker2;
        private DateTimePicker dateTimePicker1;
        private Label label4;
        private Label label3;
        private Label label6;
        private TextBox textBox3;
        private Label label8;
        private TextBox textBox2;
        private Label label7;
        private TextBox textBox1;
        private TextBox textBox4;
        private Label label9;
        private Button button1;
        private Button button2;
        private Label label11;
        private ComboBox comboBox2;
        private ComboBox comboBox1;
        private TextBox textBox6;
        private Label label10;
        private TextBox textBox5;
        private Label label5;
    }
}