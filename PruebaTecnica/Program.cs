using PruebaTecnica.Repositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaTecnica
{
    public class Program
    {
         private static readonly ServicioGestor _ServicioGestor=new ServicioGestor();
        static void Main(string[] args)
        {
            var modelo= _ServicioGestor.GetAsignacionSaldos();

            foreach (var item in modelo) {
                Console.WriteLine($"Gestor {item.GestorId} - Saldo: {item.Saldos}");

            }

            Console.WriteLine("Presiona una tecla para salir");
            Console.ReadKey();

        }
    }
}
