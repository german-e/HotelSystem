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
    public partial class StayDetailForm : Form
    {
        public StayDetailForm()
        {
            InitializeComponent();


          


        }

        private void BtnEliminar_Click(object? sender, EventArgs e)
        {
            MessageBox.Show("Boton Elimnar");
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
