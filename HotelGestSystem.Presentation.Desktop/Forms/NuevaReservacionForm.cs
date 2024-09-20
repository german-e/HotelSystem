using HotelGestSystem.Domain.Receptionist.Contracts;
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
    public partial class NuevaReservacionForm : Form
    {
        private readonly IHabitacionRepository _repository;

        public NuevaReservacionForm(IHabitacionRepository repository)
        {
            InitializeComponent();
            _repository = repository;



           


        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void NuevaReservacionForm_Load(object sender, EventArgs e)
        {
            cboHabitacion.DataSource = _repository.ObtenerTodas();
            cboHabitacion.DisplayMember = "Numero";
            cboHabitacion.ValueMember = "Id";
            cboHabitacion.SelectedIndex = -1;
        }
    }
}
