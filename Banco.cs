using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioInterfaces
{
    internal class Banco
    {
        public string Depositos { get; set; }
        public string Retiros { get; set; }
        public Double Intereses { get; set; }
        public int SaldoMinimo { get; set; }
    }
}
