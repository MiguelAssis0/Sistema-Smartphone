
using SistemaPOO.Models;

internal class Program
{
    private static void Main(string[] args)
    {
        Iphone iphone15 = new Iphone("11987654321", "Iphone 15", "123456789", 64);
        iphone15.InformacaoDeDispositivo();
        iphone15.InstalarAplicativo("Telegram");

        Nokia Nokia = new Nokia("11987654321", "Nokia 3310", "123456789", 64);
        Nokia.InformacaoDeDispositivo();
        Nokia.InstalarAplicativo("Whatsapp");

    }
}