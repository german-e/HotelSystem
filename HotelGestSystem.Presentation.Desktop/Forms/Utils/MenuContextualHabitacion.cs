using HotelGestSystem.Aplication.DTOs;
using HotelGestSystem.Presentation.Desktop.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelGestSystem.Presentation.Desktop.Forms.Utils
{
    public partial class MenuContextualHabitacion : Form
    {

        public string HabitacionNro { get; set; }
        public List<string> Opciones { get; set; } = new();
        


        public MenuContextualHabitacion(EstadoHabitacion roomStatus)
        {
            InitializeComponent();



            switch (roomStatus)
            {
                case EstadoHabitacion.Occupied:
                    Opciones.AddRange(new string[] { "Agregar Servicio", "Cambiar Habitacion", "Check-out" });
                    break;
                case EstadoHabitacion.Vacancy:
                    Opciones.AddRange(["Reservar", "Cambiar Estado"]);
                    break;
            }

            Opciones.ForEach(opc =>
            {
                LinkLabel link = new LinkLabel();
                link.Text = opc.ToString();
                link.Click += (s, e) => ExecuteCommand(opc);
                panelContainerOptions.Controls.Add(link);
            });





        }

        private void ExecuteCommand(string opc)
        {
            switch (opc)
            {
                case "Agregar Servicio":
                    MessageBox.Show("Se selecciono Agregar Servicio");
                    break;
                case "Cambiar Habitacion":
                    MessageBox.Show("Se selecciono " + opc);
                    break;

            }

        }

        
    }
}
