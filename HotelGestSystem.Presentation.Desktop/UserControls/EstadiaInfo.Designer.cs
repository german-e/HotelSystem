namespace HotelGestSystem.Presentation.Desktop.UserControls
{
    partial class EstadiaInfo
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
            lblGuestName = new Label();
            SuspendLayout();
            // 
            // lblGuestName
            // 
            lblGuestName.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblGuestName.BackColor = Color.Transparent;
            lblGuestName.Font = new Font("Segoe UI", 8F);
            lblGuestName.ForeColor = Color.DarkGray;
            lblGuestName.Location = new Point(3, 0);
            lblGuestName.Name = "lblGuestName";
            lblGuestName.Size = new Size(173, 25);
            lblGuestName.TabIndex = 0;
            lblGuestName.Text = "German Leonel Espindola";
            lblGuestName.TextAlign = ContentAlignment.MiddleCenter;
            lblGuestName.MouseDown += lblGuestName_MouseDown;
            // 
            // StayInfo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(lblGuestName);
            Name = "StayInfo";
            Size = new Size(179, 25);
            ResumeLayout(false);
        }

        #endregion

        private Label lblGuestName;
    }
}
