namespace HotelGestSystem.Presentation.Desktop.UserControls
{
    partial class CardRoom
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            picRoomIcon = new PictureBox();
            lblRoomNumber = new Label();
            lblRoomStatus = new Label();
            panelStatus = new Panel();
            lblCategoryRoom = new Label();
            ((System.ComponentModel.ISupportInitialize)picRoomIcon).BeginInit();
            panelStatus.SuspendLayout();
            SuspendLayout();
            // 
            // picRoomIcon
            // 
            picRoomIcon.Image = Properties.Resources.room_occupied_red;
            picRoomIcon.Location = new Point(55, 7);
            picRoomIcon.Name = "picRoomIcon";
            picRoomIcon.Size = new Size(56, 38);
            picRoomIcon.SizeMode = PictureBoxSizeMode.Zoom;
            picRoomIcon.TabIndex = 0;
            picRoomIcon.TabStop = false;
            // 
            // lblRoomNumber
            // 
            lblRoomNumber.AutoSize = true;
            lblRoomNumber.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblRoomNumber.ForeColor = Color.White;
            lblRoomNumber.Location = new Point(4, -3);
            lblRoomNumber.Name = "lblRoomNumber";
            lblRoomNumber.Size = new Size(42, 32);
            lblRoomNumber.TabIndex = 1;
            lblRoomNumber.Text = "10";
            // 
            // lblRoomStatus
            // 
            lblRoomStatus.ForeColor = Color.White;
            lblRoomStatus.Location = new Point(4, 0);
            lblRoomStatus.Name = "lblRoomStatus";
            lblRoomStatus.Size = new Size(107, 21);
            lblRoomStatus.TabIndex = 2;
            lblRoomStatus.Text = "Ocupado";
            lblRoomStatus.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panelStatus
            // 
            panelStatus.BackColor = Color.DarkRed;
            panelStatus.Controls.Add(lblRoomStatus);
            panelStatus.Dock = DockStyle.Bottom;
            panelStatus.Location = new Point(0, 45);
            panelStatus.Name = "panelStatus";
            panelStatus.Size = new Size(113, 21);
            panelStatus.TabIndex = 3;
            // 
            // lblCategoryRoom
            // 
            lblCategoryRoom.AutoSize = true;
            lblCategoryRoom.ForeColor = Color.White;
            lblCategoryRoom.Location = new Point(6, 26);
            lblCategoryRoom.Name = "lblCategoryRoom";
            lblCategoryRoom.Size = new Size(43, 15);
            lblCategoryRoom.TabIndex = 3;
            lblCategoryRoom.Text = "Simple";
            // 
            // CardRoom
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Salmon;
            Controls.Add(lblCategoryRoom);
            Controls.Add(panelStatus);
            Controls.Add(lblRoomNumber);
            Controls.Add(picRoomIcon);
            Name = "CardRoom";
            Size = new Size(113, 66);
            Load += CardRoom_Load;
            ((System.ComponentModel.ISupportInitialize)picRoomIcon).EndInit();
            panelStatus.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox picRoomIcon;
        private Label lblRoomNumber;
        private Label lblRoomStatus;
        private Panel panelStatus;
        private Label lblCategoryRoom;
    }
}
