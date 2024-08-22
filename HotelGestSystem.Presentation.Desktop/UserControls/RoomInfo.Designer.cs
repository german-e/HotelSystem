namespace HotelGestSystem.Presentation.Desktop.UserControls
{
    partial class RoomInfo
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
            lblQuantity = new Label();
            lblRoomState = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lblQuantity
            // 
            lblQuantity.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblQuantity.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblQuantity.Location = new Point(76, -3);
            lblQuantity.Name = "lblQuantity";
            lblQuantity.Size = new Size(83, 47);
            lblQuantity.TabIndex = 0;
            lblQuantity.Text = "12";
            lblQuantity.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblRoomState
            // 
            lblRoomState.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            lblRoomState.Location = new Point(76, 42);
            lblRoomState.Name = "lblRoomState";
            lblRoomState.Size = new Size(83, 18);
            lblRoomState.TabIndex = 1;
            lblRoomState.Text = "Disponible";
            lblRoomState.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            pictureBox1.Image = Properties.Resources.room_hotel;
            pictureBox1.Location = new Point(8, 7);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(62, 50);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // RoomInfo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(pictureBox1);
            Controls.Add(lblRoomState);
            Controls.Add(lblQuantity);
            Margin = new Padding(10, 5, 15, 5);
            MinimumSize = new Size(140, 60);
            Name = "RoomInfo";
            Size = new Size(159, 64);
            Load += RoomInfo_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label lblQuantity;
        private Label lblRoomState;
        private PictureBox pictureBox1;
    }
}
