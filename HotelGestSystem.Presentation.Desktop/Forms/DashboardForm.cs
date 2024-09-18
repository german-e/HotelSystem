using HotelGestSystem.Presentation.Desktop.Enums;
using HotelGestSystem.Presentation.Desktop.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelGestSystem.Presentation.Desktop.Forms
{
    public partial class DashboardForm : Form
    {
        public DashboardForm()
        {
            InitializeComponent();

            InitConfig();

            ListRoomsCard();

            ListRoomsGrid();


            RoomInfo roomInfoAvailable = new RoomInfo("Disponible", 10, Color.DarkSeaGreen);
            RoomInfo roomInfoOccupied = new RoomInfo("Ocupadas", 10, Color.Crimson);
            RoomInfo roomInfoOutService = new RoomInfo("Fuera de Servicio", 10, Color.DarkGray);
            
            roomInfoAvailable.Margin = new Padding(10);
            roomInfoOccupied.Margin = new Padding(10);
            roomInfoOutService.Margin = new Padding(10);

            flowLayoutRoomQty.Controls.Add(roomInfoAvailable);
            flowLayoutRoomQty.Controls.Add(roomInfoOutService);
            flowLayoutRoomQty.Controls.Add(roomInfoOccupied);

        }


        private void InitConfig()
        {
            int todayIs = DateTime.Now.Day;



            int row = 0;
            int col = 1;
            for (int i = todayIs; i < (todayIs + 15); i++)
            {


                Label label = new Label();
                label.AutoSize = false;
                label.Dock = DockStyle.Fill;
                label.Text = DateTime.Now.AddDays(i).Day.ToString();
                tableLayoutPanel2.Controls.Add(label);
                tableLayoutPanel2.SetCellPosition(label, new TableLayoutPanelCellPosition(col, row));

                col++;
            }
        }
        private void ListRoomsCard()
        {
            CardRoom room1 = new CardRoom(Color.LightGreen, "01", "Simple", Enums.RoomStatus.Occupied);
            CardRoom room2 = new CardRoom(Color.LightGreen, "02", "Simple", Enums.RoomStatus.Vacancy);
            CardRoom room3 = new CardRoom(Color.LightGreen, "03", "Triple", Enums.RoomStatus.Occupied);
            CardRoom room4 = new CardRoom(Color.LightGreen, "04", "Doble", Enums.RoomStatus.Occupied);


            panelRoomView.Controls.Add(room1);
            panelRoomView.Controls.Add(room2);
            panelRoomView.Controls.Add(room3);
            panelRoomView.Controls.Add(room4);
        }

        private void ListRoomsGrid()
        {
            StayInfo info = new StayInfo();
            info.BackColor = Color.Green;
            info.Dock = DockStyle.Fill;
            info.Margin = new Padding(5);
            info.Height = 50;
            tableLayoutPanel2.Controls.Add(info);
            
            tableLayoutPanel2.SetCellPosition(info, new TableLayoutPanelCellPosition(5, 1));
            tableLayoutPanel2.SetColumnSpan(info, 3);
            

            StayInfo info2 = new StayInfo();
            info2.BackColor = Color.YellowGreen;
            info2.Dock = DockStyle.Fill;
            info2.Margin = new Padding(5);
            info2.Height = 50;
            tableLayoutPanel2.Controls.Add(info2);
            tableLayoutPanel2.SetCellPosition(info2, new TableLayoutPanelCellPosition(3, 2));
            tableLayoutPanel2.SetColumnSpan(info2, 5);

           
        }




        private void DashboardForm_Load(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
