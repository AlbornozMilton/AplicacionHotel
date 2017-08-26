using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    class Program
    {
        static void Main(string[] args)
        {
            Habitacion lHabitacion = new Habitacion(1, 0, false);
            foreach (var cupo in lHabitacion.Cupos)
            {
                Console.WriteLine("{0} - {1} - {2}",cupo.CodCupo,cupo.TipoCupo,cupo.Disponible);
            }
            lHabitacion.OcuparCupos2(1,3);
            Console.WriteLine();
            Console.WriteLine("OCUPACION");

            foreach (var cupo in lHabitacion.Cupos)
            {
                Console.WriteLine("{0} - {1} - {2}", cupo.CodCupo, cupo.TipoCupo, cupo.Disponible);
            }

            List<Cupo> lCuposEsperados = new List<Cupo>()
            {
                new Cupo(1, TipoCupo.simple, false),
                new Cupo(2, TipoCupo.doble, false),
                new Cupo(3, TipoCupo.simple, false),
                new Cupo(4, TipoCupo.doble, true)
            };

            Console.WriteLine();
            Console.WriteLine("CUPOS ESPERADOS");

            foreach (var cupo in lCuposEsperados)
            {
                Console.WriteLine("{0} - {1} - {2}", cupo.CodCupo, cupo.TipoCupo, cupo.Disponible);
            }

            Console.WriteLine();
            Console.WriteLine("Coparando");
            for (int i = 0; i < lHabitacion.Cupos.Count; i++)
            {
                if (lHabitacion.Cupos[i].CodCupo == lCuposEsperados[i].CodCupo &
                            lHabitacion.Cupos[i].TipoCupo == lCuposEsperados[i].TipoCupo &
                            lHabitacion.Cupos[i].Disponible == lCuposEsperados[i].Disponible)
                {
                    Console.WriteLine(true);
                }
                else
                {
                    Console.WriteLine(false);
                }

            }
            Console.ReadKey();
        }
    }
}
