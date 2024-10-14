using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaPOO.Models
{
    public class Nokia : Smartphone
    {
        public Nokia(string numero, string modelo, string IMEI, int Memoria) : base(numero, modelo, IMEI, Memoria)
        {
        }

        public override void InstalarAplicativo(string nome)
        {
            Console.WriteLine($"Instalando aplicativo {nome} no Nokia");
        }

        
    }
}