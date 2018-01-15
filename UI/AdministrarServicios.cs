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
    public partial class AdministrarServicios : Form
    {
        public AdministrarServicios()
        {
            InitializeComponent();
            CargarServicios();
        }

        private void CargarServicios()
        {
            ControladorExtra iControladorExtra = new ControladorExtra();
            foreach (var serv in iControladorExtra.ObtenerServicios())
            {
                dGV_Servicios.Rows.Add(serv.ServicioId,serv.Nombre,serv.CostoBase);
            }
            
        }
    }
}
