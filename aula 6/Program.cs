using System.ComponentModel.Design;

Console.WriteLine(" Qual a sua idade ?");

string resposta = Console.ReadLine();
const int DEZOITO = 18;
const int ZERO = 0;
int idade = int.Parse(resposta);
bool ehvalido = int . TryParse(resposta, out idade);

if (ehvalido)

    if (idade >= 18)
    {

        Console.WriteLine(" Usuario é maior de idade ");
       
    }
    else
    {
        Console.WriteLine("usuario é menor de idade");


    }
    else 
    Console.WriteLine( "Valor informado não corresponde");