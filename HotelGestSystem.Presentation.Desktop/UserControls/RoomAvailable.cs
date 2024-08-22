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
    public partial class RoomAvailable : UserControl
    {
        public RoomAvailable(RoomInfo info, int daysToShow = 15  )
        {
            InitializeComponent();



            tableLayoutPanel.ColumnCount = daysToShow;


        }

        
    }
}
