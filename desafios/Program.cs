//Tabuada: Faça um programa que receba um número e,
//usando laços de repetição, calcule e mostre
//a tabuada desse número

/*
Console.WriteLine(" Insira um numero inteiro :");
string entradaUsuario  = Console.ReadLine();

bool valido = int.TryParse(entradaUsuario, out int numero);


if (valido)
{
    int contador = 0;
    while (contador <= 10)
    {
        Console.WriteLine(contador + "* " + numero + ( contador * numero ) );   

        contador++;
    }

}
else
{
    Console.WriteLine(" valor inserido não é um numero inteiro");

}
*/

///Tabuada
/*Console.WriteLine("Tabuada");
Console.WriteLine("insira um numero:");
string numRece = Console.ReadLine();
int numTab = int.Parse(numRece);
 
for (int cont = 0; cont <= 10; cont++)
{
    Console.WriteLine($"{numTab} x {cont} = {numTab * cont}");  
}*/

//Mostre uma mensagem caso o valor seja inválido e continue
//pedindo até que o usuário
//informe um valor válido.


//Tabuada 2.0

/*Console.WriteLine("Tabuada");

Console.WriteLine("insira um numero:");

string numRece = Console.ReadLine();

int numTab = int.Parse(numRece);
 
for (int cont = 0; cont <= 10; cont++)

{

    Console.WriteLine($"{numTab} x {cont} = {numTab * cont}");  

}*/
// SEGUNDO EXERCICO
//Validação de Nota: Faça um programa que peça uma nota entre zero e dez.

//Mostre uma mensagem caso o valor seja inválido e continue pedindo até que o usuário informe um valor válido.
/*
Console.WriteLine("insira uma nota de Zero a Dez");
string numero = Console.ReadLine();
int nota = int.Parse(numero);

for (; nota < 0 || nota > 10;)

{

   Console.WriteLine("Nota inválida! Digite uma entre Zero e Dez:");
   nota = int.Parse(Console.ReadLine());
   ;

   Console.WriteLine($"Nota válida: {nota}");
}

/* MODO 02
bool invalido = true;

while (invalido)
{
   Console.WriteLine("Insira sua nota (ENTRE 0 e 10):");
   string entradaUsuario  = Console.ReadLine();
   bool valido = int.TryParse(entradaUsuario, out int nota);

   invalido = !valido || nota < 0 || nota > 10;

   if (invalido)
   {
       Console.WriteLine("Informe uma nota válida");
   }
   else
   {
       Console.WriteLine(nota + " é uma nota válida.");
   }
   Console.WriteLine("---");
}
*/


const int QTD_PESSOAS = 7;
int contadorPessoas90Kg = 0;
int somaIdadePessoas = 0;
string entradaUsuario;
for (int contador = 0; contador < QTD_PESSOAS; contador++)
{
    Console.WriteLine("Insira sua idade:");
    entradaUsuario = Console.ReadLine();
    int.TryParse(entradaUsuario, out int idade);
    Console.WriteLine("Insira seu peso:");
    entradaUsuario = Console.ReadLine();
    int.TryParse(entradaUsuario, out int peso);
    somaIdadePessoas += idade;
    if (peso > 90)
    {
        contadorPessoas90Kg++;
    }
}
Console.WriteLine("A quantidade de pessoas com mais de 90 Kg é: " + contadorPessoas90Kg);
Console.WriteLine("A média das idades é: " + (somaIdadePessoas / QTD_PESSOAS));
