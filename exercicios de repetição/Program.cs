/*
Console.WriteLine("TABUADA");
Console.WriteLine(" insira um numero");
string numero = Console.ReadLine();
int numtabuada= int.Parse(numero);

for (int cont = 0; cont < 10; cont++)
{
    Console.WriteLine($"{numtabuada} X {cont} = {numtabuada * cont}");

}
*/



Console.WriteLine(" insira uma nota de zero a dez ");
string numero = Console.ReadLine();
int nota = int .Parse(numero);

for (; nota > 0 || nota > 10; nota++) ;
{ 
Console.WriteLine(nota + " invalida");
    {
        const string AMARELO = "AMARELO";
        const string AZUL = "AZUL";
        const string VERDE = "VERDE";
        const string MSG_VOTO = "Qual é o seu voto? (AMARELO, AZUL ou VERDE)";
        string voto;
        int votosAmarelo = 0;
        int votosVerde = 0;
        int votosAzul = 0;
        int abs = 0;
        for (int cont = 0; cont < 5; cont++)
        {
            Console.WriteLine(MSG_VOTO);
            voto = Console.ReadLine();
            // Apuração
            switch (voto)
            {
                case AMARELO:
                    votosAmarelo++;
                    break;
                case AZUL:
                    votosAzul++;
                    break;
                case VERDE:
                    votosVerde++;
                    break;
                default:
                    abs++;
                    break;

            }
        }

        int vencedor = 0;
        if (vencedor < votosAmarelo)
        {
            vencedor = votosAmarelo;
        }
        if (vencedor < votosAzul)
        {
            vencedor = votosAzul;
        }
        if (vencedor < votosVerde)
        {
            vencedor = votosVerde;
        }
        if (vencedor < abs)
        {
            vencedor = abs;
        }
        if (vencedor == votosAmarelo)
        {
            Console.WriteLine("O Amarelo é o vencedor.");
        }
        if (vencedor == votosAzul)
        {
            Console.WriteLine("O Azul é o vencedor.");
        }
        if (vencedor == votosVerde)
        {
            Console.WriteLine("O Verde é o vencedor.");
        }
        if (vencedor == abs)
        {
            Console.WriteLine("Não há vencedor dado o número de abstenções.");
        }
        const string AMARELO = "AMARELO";
        const string AZUL = "AZUL";
        const string VERDE = "VERDE";
        const string MSG_VOTO = "Qual é o seu voto? (AMARELO, AZUL ou VERDE)";
        string voto;
        int votosAmarelo = 0;
        int votosVerde = 0;
        int votosAzul = 0;
        int abs = 0;
        for (int cont = 0; cont < 5; cont++)
        {
            Console.WriteLine(MSG_VOTO);
            voto = Console.ReadLine();
            // Apuração
            switch (voto)
            {
                case AMARELO:
                    votosAmarelo++;
                    break;
                case AZUL:
                    votosAzul++;
                    break;
                case VERDE:
                    votosVerde++;
                    break;
                default:
                    abs++;
                    break;

            }
        }

        int vencedor = 0;
        if (vencedor < votosAmarelo)
        {
            vencedor = votosAmarelo;
        }
        if (vencedor < votosAzul)
        {
            vencedor = votosAzul;
        }
        if (vencedor < votosVerde)
        {
            vencedor = votosVerde;
        }
        if (vencedor < abs)
        {
            vencedor = abs;
        }
        if (vencedor == votosAmarelo)
        {
            Console.WriteLine("O Amarelo é o vencedor.");
        }
        if (vencedor == votosAzul)
        {
            Console.WriteLine("O Azul é o vencedor.");
        }
        if (vencedor == votosVerde)
        {
            Console.WriteLine("O Verde é o vencedor.");
        }
        if (vencedor == abs)
        {
            Console.WriteLine("Não há vencedor dado o número de abstenções.");
        }
    }







