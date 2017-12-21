using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dominio;

namespace UI
{
    public partial class AgregarServicio : Form
    {
        public Alojamiento iAloj_Seleccionado;
        public AgregarServicio()
        {
            InitializeComponent();
        }

        public void CargarAlojamientoSeccionado(DataGridViewCellCollection fila)
        {
            dGV_ListadoAlojamientos.Rows.Clear();
            dGV_ListadoAlojamientos.Rows.Add(fila[0].Value, fila[1].Value, fila[2].Value, fila[3].Value);
        }

        private void btn_BuscarAlojamiento_Click(object sender, EventArgs e)
        {
            BuscarAlojamiento BuscarAlojamiento = new BuscarAlojamiento();
            BuscarAlojamiento.ShowDialog();
            iAloj_Seleccionado = BuscarAlojamiento.iAloj_Seleccionado;
            CargarAlojamientoSeccionado(BuscarAlojamiento.iFilaSeleccionada);
        }

        private void btn_Aceptar_Click(object sender, EventArgs e)
        {
            ControladorAlojamiento iControladorAloj = new ControladorAlojamiento();
            iControladorAloj.AgregarServicio(cBox_Servicios.SelectedItem.ToString(), Convert.ToByte(cant_Servicio.Value), iAloj_Seleccionado);
            MessageBox.Show("¡ Servicio Agregado !");
            Close();
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
