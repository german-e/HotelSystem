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
    public partial class StayInfo : UserControl
    {
        public StayInfo()
        {
            InitializeComponent();
        }

        private void lblGuestName_MouseDown(object sender, MouseEventArgs e)
        {
            
                
            MenuContextualReservation contextual = new();
            contextual.Top = e.X;
            contextual.ShowDialog();
        }
    }
}
