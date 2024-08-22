using HotelGestSystem.Presentation.Desktop.Enums;
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
    public partial class CardRoom : UserControl
    {
        public Color Color { get; set; }
        public string RoomNumber { get; set; }
        public string RoomCategory { get; set; }
        public Image Icon { get; set; }
        public RoomStatus RoomStatus { get; set; }
        public CardRoom(Color color, string roomNumber, string roomCategory, RoomStatus status)
        {
            InitializeComponent();

            Color = color;
            RoomNumber = roomNumber;
            RoomCategory = roomCategory;
            Icon = Properties.Resources.room_occupied_black;
            RoomStatus = status;

        }

        private void CardRoom_Load(object sender, EventArgs e)
        {



            switch (RoomStatus)
            {
                case RoomStatus.Occupied:
                    BackColor = Color.FromArgb(125, 10, 10);
                    Icon = Properties.Resources.room_occupied_red;
                    panelStatus.BackColor = Color.FromArgb(191, 49, 49);
                    break;
                case RoomStatus.Vacancy:
                    BackColor = Color.FromArgb(54, 94, 50);
                    panelStatus.BackColor = Color.FromArgb(129, 162, 99);
                    Icon = Properties.Resources.room_empty_green;
                    break;
            }


            lblCategoryRoom.Text = RoomCategory;
            lblRoomNumber.Text = RoomNumber;
            lblRoomStatus.Text = RoomStatus.ToString();
            picRoomIcon.Image = Icon;


        }

        private void CardRoom_Click(object sender, EventArgs e)
        {
            MenuContextualRoom menu = new MenuContextualRoom(RoomStatus);
            menu.ShowDialog();
        }
    }
}
