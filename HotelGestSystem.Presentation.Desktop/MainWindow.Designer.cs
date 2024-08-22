namespace HotelGestSystem.Presentation.Desktop
{
    partial class MainWindow
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tableLayoutPanel1 = new TableLayoutPanel();
            MainConteiner = new Panel();
            flowLayoutPanel1 = new FlowLayoutPanel();
            button4 = new Button();
            button3 = new Button();
            button1 = new Button();
            button2 = new Button();
            panelTop = new Panel();
            pictureBox1 = new PictureBox();
            panelCheckRoomAvailable = new Panel();
            dateCheckRoomAvailableFrom = new DateTimePicker();
            dateCheckRoomAvailableTo = new DateTimePicker();
            btnCheckRoomAvailable = new Button();
            cboCheckRoomAvailableType = new ComboBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            tableLayoutPanel1.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panelCheckRoomAvailable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 200F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(MainConteiner, 1, 1);
            tableLayoutPanel1.Controls.Add(panelTop, 1, 0);
            tableLayoutPanel1.Controls.Add(flowLayoutPanel1, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 45F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutPanel1.Size = new Size(969, 611);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // MainConteiner
            // 
            MainConteiner.BackColor = Color.Linen;
            MainConteiner.Dock = DockStyle.Fill;
            MainConteiner.Location = new Point(203, 48);
            MainConteiner.Name = "MainConteiner";
            MainConteiner.Size = new Size(763, 530);
            MainConteiner.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = Color.DarkRed;
            flowLayoutPanel1.Controls.Add(button4);
            flowLayoutPanel1.Controls.Add(button3);
            flowLayoutPanel1.Controls.Add(button1);
            flowLayoutPanel1.Controls.Add(button2);
            flowLayoutPanel1.Controls.Add(panelCheckRoomAvailable);
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.Location = new Point(3, 3);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            tableLayoutPanel1.SetRowSpan(flowLayoutPanel1, 2);
            flowLayoutPanel1.Size = new Size(194, 575);
            flowLayoutPanel1.TabIndex = 1;
            // 
            // button4
            // 
            button4.BackColor = Color.PaleVioletRed;
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Location = new Point(0, 55);
            button4.Margin = new Padding(0, 55, 5, 3);
            button4.Name = "button4";
            button4.Size = new Size(192, 35);
            button4.TabIndex = 5;
            button4.Text = "Nueva Reservación";
            button4.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = Color.PaleVioletRed;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.ImageAlign = ContentAlignment.MiddleLeft;
            button3.Location = new Point(0, 108);
            button3.Margin = new Padding(0, 15, 0, 3);
            button3.Name = "button3";
            button3.Size = new Size(194, 35);
            button3.TabIndex = 2;
            button3.Text = "Check In";
            button3.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = Color.PaleVioletRed;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(0, 151);
            button1.Margin = new Padding(0, 5, 3, 3);
            button1.Name = "button1";
            button1.Size = new Size(192, 35);
            button1.TabIndex = 3;
            button1.Text = "Check out";
            button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.PaleVioletRed;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Location = new Point(0, 204);
            button2.Margin = new Padding(0, 15, 3, 3);
            button2.Name = "button2";
            button2.Size = new Size(192, 35);
            button2.TabIndex = 4;
            button2.Text = "Huéspedes";
            button2.UseVisualStyleBackColor = false;
            // 
            // panelTop
            // 
            panelTop.Controls.Add(pictureBox1);
            panelTop.Dock = DockStyle.Fill;
            panelTop.Location = new Point(203, 3);
            panelTop.Name = "panelTop";
            panelTop.Size = new Size(763, 39);
            panelTop.TabIndex = 2;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBox1.Image = Properties.Resources.user;
            pictureBox1.Location = new Point(723, 7);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(37, 27);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panelCheckRoomAvailable
            // 
            panelCheckRoomAvailable.BackColor = Color.DarkSalmon;
            panelCheckRoomAvailable.Controls.Add(pictureBox4);
            panelCheckRoomAvailable.Controls.Add(pictureBox3);
            panelCheckRoomAvailable.Controls.Add(pictureBox2);
            panelCheckRoomAvailable.Controls.Add(cboCheckRoomAvailableType);
            panelCheckRoomAvailable.Controls.Add(btnCheckRoomAvailable);
            panelCheckRoomAvailable.Controls.Add(dateCheckRoomAvailableTo);
            panelCheckRoomAvailable.Controls.Add(dateCheckRoomAvailableFrom);
            panelCheckRoomAvailable.Location = new Point(3, 245);
            panelCheckRoomAvailable.Name = "panelCheckRoomAvailable";
            panelCheckRoomAvailable.Size = new Size(189, 183);
            panelCheckRoomAvailable.TabIndex = 6;
            // 
            // dateCheckRoomAvailableFrom
            // 
            dateCheckRoomAvailableFrom.CustomFormat = "dddd dd MMM";
            dateCheckRoomAvailableFrom.Format = DateTimePickerFormat.Custom;
            dateCheckRoomAvailableFrom.Location = new Point(40, 21);
            dateCheckRoomAvailableFrom.Name = "dateCheckRoomAvailableFrom";
            dateCheckRoomAvailableFrom.Size = new Size(137, 23);
            dateCheckRoomAvailableFrom.TabIndex = 0;
            // 
            // dateCheckRoomAvailableTo
            // 
            dateCheckRoomAvailableTo.CustomFormat = "dddd dd MMM";
            dateCheckRoomAvailableTo.Format = DateTimePickerFormat.Custom;
            dateCheckRoomAvailableTo.Location = new Point(40, 56);
            dateCheckRoomAvailableTo.Name = "dateCheckRoomAvailableTo";
            dateCheckRoomAvailableTo.Size = new Size(137, 23);
            dateCheckRoomAvailableTo.TabIndex = 1;
            // 
            // btnCheckRoomAvailable
            // 
            btnCheckRoomAvailable.BackColor = Color.LightSeaGreen;
            btnCheckRoomAvailable.FlatStyle = FlatStyle.Flat;
            btnCheckRoomAvailable.Location = new Point(13, 143);
            btnCheckRoomAvailable.Name = "btnCheckRoomAvailable";
            btnCheckRoomAvailable.Size = new Size(164, 25);
            btnCheckRoomAvailable.TabIndex = 2;
            btnCheckRoomAvailable.Text = "Ver Disponibilidad";
            btnCheckRoomAvailable.UseVisualStyleBackColor = false;
            btnCheckRoomAvailable.Click += btnCheckRoomAvailable_Click;
            // 
            // cboCheckRoomAvailableType
            // 
            cboCheckRoomAvailableType.FormattingEnabled = true;
            cboCheckRoomAvailableType.Location = new Point(40, 91);
            cboCheckRoomAvailableType.Name = "cboCheckRoomAvailableType";
            cboCheckRoomAvailableType.Size = new Size(137, 23);
            cboCheckRoomAvailableType.TabIndex = 3;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.room_hotel;
            pictureBox2.Location = new Point(13, 90);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(21, 24);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 4;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.check_in;
            pictureBox3.Location = new Point(13, 20);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(21, 24);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 5;
            pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.check_out_black;
            pictureBox4.Location = new Point(13, 56);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(21, 24);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 6;
            pictureBox4.TabStop = false;
            // 
            // MainWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(969, 611);
            Controls.Add(tableLayoutPanel1);
            Name = "MainWindow";
            Text = "Hoter Gest Sistema";
            WindowState = FormWindowState.Maximized;
            tableLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.ResumeLayout(false);
            panelTop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panelCheckRoomAvailable.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Panel MainConteiner;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button button3;
        private Button button1;
        private Button button2;
        private Button button4;
        private Panel panelTop;
        private PictureBox pictureBox1;
        private Panel panelCheckRoomAvailable;
        private Button btnCheckRoomAvailable;
        private DateTimePicker dateCheckRoomAvailableTo;
        private DateTimePicker dateCheckRoomAvailableFrom;
        private PictureBox pictureBox2;
        private ComboBox cboCheckRoomAvailableType;
        private PictureBox pictureBox4;
        private PictureBox pictureBox3;
    }
}
