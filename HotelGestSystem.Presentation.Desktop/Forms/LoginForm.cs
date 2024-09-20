using HotelGestSystem.Aplication.Seguridad;
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
    public partial class LoginForm : Form
    {
        
        public LoginForm()
        {
            InitializeComponent();
        }

        private void BtnIniciarSesion_Click(object sender, EventArgs e)
        {
            var manager = new UserManager();

            bool esCorrecto = manager.Login(txtUsername.Text, txtPassword.Text);
            

            if (esCorrecto)
            {
                MessageBox.Show("Bravo!! Login");
            }
            else
            {
                MessageBox.Show("Acceso Incorrecto");
            }
        }
    }
}
