using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Smartphone Nokia:");
        Smartphone nokia = new Nokia("123456", "Nokia Modelo 1", "1111111111", 64);
        nokia.Ligar();
        nokia.InstalarAplicativo("whatsApp");
        
        Console.WriteLine();

        Console.WriteLine("Smartphone Iphone:");
        Smartphone iphone = new Iphone("564321", "Iphone 16", "2222222222", 128);
        iphone.ReceberLigacao();
        iphone.InstalarAplicativo("Telegran");
        

    }
}