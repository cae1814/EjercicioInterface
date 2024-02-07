using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace EjercicioInterfaces
{
    internal class Retirable : Banco, IBanco
    {
        public void ListarOperaciones() {
            Console.WriteLine("*********************************************");
            Console.WriteLine("Cuenta Retirables: ");
            Console.WriteLine("Retiros: " + Retiros);
            Console.WriteLine("Depositos: " + Depositos);
            Console.WriteLine("Intereses: " + Intereses);
            Console.WriteLine("Saldo Minimo: " + SaldoMinimo);
            Console.WriteLine("*********************************************");
            Console.WriteLine("");
        }
    }
}
