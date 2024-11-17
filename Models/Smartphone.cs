namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        // Propriedade pública que guarda o número do telefone
        public string Numero { get; set; }
        // Propriedades privadas que guardam modelo, IMEI e memória do telefone
        private string modelo;
        private string imei;
        private int memoria;

        // Construtor da classe que inicializa todas as propriedades
        public Smartphone(string numero, string modelo, string imei, int memoria)
        {
            Numero = numero;
            this.modelo = modelo;
            this.imei = imei;
            this.memoria = memoria;

        }

        // Propriedades públicas somente leitura para acessar os valores privados
        public string Modelo
        {
            get { return modelo; }
        }
        public string IMEI
        {
            get{ return imei; }
        }
        public int Memoria
        {
            get{ return memoria; }
        }

        // Método que simula a ação de ligar o telefone
        public void Ligar()
        {
            Console.WriteLine("Ligando...");
        }

        // Método que simula a ação de receber uma ligação
        public void ReceberLigacao()
        {
            Console.WriteLine("Recebendo ligação...");
        }

        // Método abstrato que deve ser implementado nas classes derivadas para instalar um aplicativo
        public abstract void InstalarAplicativo(string nomeApp);
    }
}