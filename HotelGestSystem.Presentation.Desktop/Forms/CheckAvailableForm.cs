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
    public partial class CheckAvailableForm : Form
    {

        public DateTime DateCheckFrom { get; set; }
        public DateTime DateCheckTo { get; set; }
        public string RoomType { get; set; }
        public CheckAvailableForm()
        {
            InitializeComponent();
        }

        public CheckAvailableForm(DateTime dateCheckFrom, DateTime dateCheckTo, string roomType)
        {
            InitializeComponent();

            DateCheckFrom = dateCheckFrom;
            DateCheckTo = dateCheckTo;
            RoomType = roomType;




        }

        private void CheckAvailableForm_Load(object sender, EventArgs e)
        {
            dateCheckFrom.Value = DateCheckFrom; dateCheckTo.Value = DateCheckTo; cboRoomType.SelectedText= RoomType;
        }
    }
}
