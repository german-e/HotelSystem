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
    public partial class InfoHabitacion : UserControl
    {

        public string Status { get; set; }
        public int Total { get; set; }
        public Color Color { get; set; }
        

        public InfoHabitacion(string status, int total, Color color)
        {
            InitializeComponent();

            Status = status;
            Total = total;
            Color = color;
        }

        private void RoomInfo_Load(object sender, EventArgs e)
        {
            lblQuantity.Text = Total.ToString();
            lblRoomState.Text = Status;
            BackColor = Color;
        }
    }
}
