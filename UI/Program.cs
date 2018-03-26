using System.Windows.Forms;

namespace UI
{
    class Program
    {
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Dominio.DTOsAutoMapper.AutoMapper.Mapear();
            Application.Run(new VentanaArranque());
        }
    }
}
