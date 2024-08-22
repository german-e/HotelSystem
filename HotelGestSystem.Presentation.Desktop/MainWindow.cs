using HotelGestSystem.Presentation.Desktop.Forms;

namespace HotelGestSystem.Presentation.Desktop
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();


            DashboardForm dashboard = new DashboardForm();
            dashboard.TopLevel = false;
            dashboard.FormBorderStyle = FormBorderStyle.None;
            dashboard.Dock = DockStyle.Fill;
            MainConteiner.Controls.Add(dashboard);

            dashboard.Show();


        }

        private void btnCheckRoomAvailable_Click(object sender, EventArgs e)
        {
            CheckAvailableForm checkAvailableForm = new CheckAvailableForm(dateCheckRoomAvailableFrom.Value, dateCheckRoomAvailableTo.Value, cboCheckRoomAvailableType.SelectedText);

            checkAvailableForm.Show();
        }
    }
}
