/*
Crie um programa que peça ao usuário uma senha. O programa deve permitir até 3 tentativas.
A senha correta é "12345".
Se o usuário digitar a senha correta E tiver mais de 18 anos (idade informada previamente), o acesso é liberado.
Caso contrário, o programa informa que o acesso foi negado */

Console.WriteLine("Insira sua idade");

string idade = Console.ReadLine();

int id = int.Parse(idade);


if (id < 18)

{

    Console.WriteLine("Acesso Negado, Menor de idade");

}

else

{

    string senha = "12345";

    bool acesso = false;



    for (int i = 3; i > 0; i--)

    {

        Console.WriteLine($"Informe a senha (Tentativas restantes: {i})");

        string senhaP = Console.ReadLine();

        if (senha == senhaP)

        {

            Console.WriteLine("Acesso Aprovado!");

            acesso = true;

            break;

        }

        else

        {

            Console.WriteLine("Senha incorreta!");

        }

    }

    if (!acesso)

    {

        Console.WriteLine("Acesso Negado! Número de tentativas excedido.");

    }

}









