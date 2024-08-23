namespace HotelGestSystem.Presentation.Desktop.Forms.Utils
{
    partial class MenuContextualRoom
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
            panel1 = new Panel();
            btnCancelar = new Button();
            label1 = new Label();
            panelContainerOptions = new FlowLayoutPanel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.DeepSkyBlue;
            panel1.Controls.Add(btnCancelar);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(201, 39);
            panel1.TabIndex = 0;
            // 
            // btnCancelar
            // 
            btnCancelar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnCancelar.DialogResult = DialogResult.Cancel;
            btnCancelar.FlatAppearance.BorderSize = 0;
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancelar.ForeColor = Color.Firebrick;
            btnCancelar.Location = new Point(167, 5);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(28, 29);
            btnCancelar.TabIndex = 1;
            btnCancelar.Text = "X";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 11);
            label1.Name = "label1";
            label1.Size = new Size(56, 15);
            label1.TabIndex = 0;
            label1.Text = "Hab. 105";
            // 
            // panelContainerOptions
            // 
            panelContainerOptions.FlowDirection = FlowDirection.TopDown;
            panelContainerOptions.Location = new Point(12, 45);
            panelContainerOptions.Name = "panelContainerOptions";
            panelContainerOptions.Size = new Size(170, 103);
            panelContainerOptions.TabIndex = 1;
            // 
            // MenuContextualRoom
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnCancelar;
            ClientSize = new Size(201, 163);
            Controls.Add(panelContainerOptions);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "MenuContextualRoom";
            Text = "MenuContextualRoom";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnCancelar;
        private Label label1;
        private FlowLayoutPanel panelContainerOptions;
    }
}