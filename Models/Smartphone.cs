using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaPOO.Models
{
    public abstract class Smartphone
    {
        public string Numero { get; set; }
        private string Modelo { get; set; }
        private string IMEI { get; set; }
        private int Memoria { get; set; }

        public Smartphone(string numero, string modelo, string IMEI, int Memoria)
        {
            Numero = numero;
            Modelo = modelo;
            this.IMEI = IMEI;
            this.Memoria = Memoria;
        }

        public void Ligar()
        {
            Console.WriteLine("Ligando");
        }

        public void ReceberLigacao()
        {
            Console.WriteLine("Recebendo ligação");
        }

        public void InformacaoDeDispositivo()
        {
            Console.WriteLine($"Informações do dispositivo:");
            Console.WriteLine($"Modelo: {Modelo}");
            Console.WriteLine($"Número: {Numero}");
            Console.WriteLine($"IMEI: {IMEI}");
            Console.WriteLine($"Memória: {Memoria}");
        }

        public abstract void InstalarAplicativo(string nome);

    }
}