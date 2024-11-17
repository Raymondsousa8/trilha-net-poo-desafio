namespace DesafioPOO.Models
{
    // A classe Nokia que herdar da classe  abstrata "Smartphone"
    public class Nokia : Smartphone
    {

        // Construtor da classe Nokia que chama o construtor da classe base (Smartphone)

        public Nokia(string numero, string modelo, string imei, int memoria) 
        : base(numero, modelo, imei, memoria)
        {
        }

        // Método sobrescrito para instalar um aplicativo específico no Nokia
        public override void InstalarAplicativo(string nomeApp)
        { 
            Console.WriteLine($"Instalando aplicativo {nomeApp} no Nokia ");
        }
    }
}