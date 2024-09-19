using HotelGestSystem.Presentation.Desktop.Forms.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelGestSystem.Presentation.Desktop.UserControls
{
    public partial class EstadiaInfo : UserControl
    {
        public EstadiaInfo()
        {
            InitializeComponent();
        }

        private void lblGuestName_MouseDown(object sender, MouseEventArgs e)
        {
            
                
            MenuContextualReservacion contextual = new();
            contextual.Top = e.X;
            contextual.ShowDialog();
        }
    }
}
