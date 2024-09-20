using HotelGestSystem.Presentation.Desktop.Forms;
using Microsoft.Extensions.DependencyInjection;

namespace HotelGestSystem.Presentation.Desktop
{
    public partial class MainWindow : Form
    {
        private readonly IServiceProvider _serviceProvider;

        public MainWindow(IServiceProvider serviceProvider)
        {
            InitializeComponent();

            _serviceProvider = serviceProvider;

            DashboardForm dashboard = new DashboardForm();
            dashboard.TopLevel = false;
            dashboard.FormBorderStyle = FormBorderStyle.None;
            dashboard.Dock = DockStyle.Fill;
            MainConteiner.Controls.Add(dashboard);

            dashboard.Show();


        }

        private void btnCheckRoomAvailable_Click(object sender, EventArgs e)
        {
            ConsultarDisponibilidadForm checkAvailableForm = new ConsultarDisponibilidadForm(dateCheckRoomAvailableFrom.Value, dateCheckRoomAvailableTo.Value, cboCheckRoomAvailableType.SelectedText);

            checkAvailableForm.Show();
        }

        private void BtnMenuNuevaReservacion_Click(object sender, EventArgs e)
        {
            var formNuevaReservacion = _serviceProvider.GetRequiredService<NuevaReservacionForm>();

            formNuevaReservacion.Show();
        }
    }
}
