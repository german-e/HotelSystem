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


            InfoHabitacion roomInfoAvailable = new InfoHabitacion("Disponible", 10, Color.DarkSeaGreen);
            InfoHabitacion roomInfoOccupied = new InfoHabitacion("Ocupadas", 10, Color.Crimson);
            InfoHabitacion roomInfoOutService = new InfoHabitacion("Fuera de Servicio", 10, Color.DarkGray);
            
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
            HabitacionCard room1 = new HabitacionCard(Color.LightGreen, "01", "Simple", Enums.EstadoHabitacion.Occupied);
            HabitacionCard room2 = new HabitacionCard(Color.LightGreen, "02", "Simple", Enums.EstadoHabitacion.Vacancy);
            HabitacionCard room3 = new HabitacionCard(Color.LightGreen, "03", "Triple", Enums.EstadoHabitacion.Occupied);
            HabitacionCard room4 = new HabitacionCard(Color.LightGreen, "04", "Doble", Enums.EstadoHabitacion.Occupied);


            panelRoomView.Controls.Add(room1);
            panelRoomView.Controls.Add(room2);
            panelRoomView.Controls.Add(room3);
            panelRoomView.Controls.Add(room4);
        }

        private void ListRoomsGrid()
        {
            EstadiaInfo info = new EstadiaInfo();
            info.BackColor = Color.Green;
            info.Dock = DockStyle.Fill;
            info.Margin = new Padding(5);
            info.Height = 50;
            tableLayoutPanel2.Controls.Add(info);
            
            tableLayoutPanel2.SetCellPosition(info, new TableLayoutPanelCellPosition(5, 1));
            tableLayoutPanel2.SetColumnSpan(info, 3);
            

            EstadiaInfo info2 = new EstadiaInfo();
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
