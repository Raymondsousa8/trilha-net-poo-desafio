namespace DesafioPOO.Models
{
    // Classe Iphone que herda da classe abstrata Smartphone
    public class Iphone : Smartphone
    {

        // Construtor da classe Iphone que chama o construtor da classe base (Smartphone)
        public Iphone(string numero, string modelo, string imei, int memoria)
            : base(numero, modelo, imei, memoria)
        {
        }

        // Método sobrescrito para instalar um aplicativo específico no Iphone
        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Instalando aplicativo {nomeApp} no Iphone.");
        }
    }
}