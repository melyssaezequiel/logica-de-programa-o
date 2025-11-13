/*Console.WriteLine("escreva um numero inteiro e descubra o dobro ");

string numero = Console.ReadLine();

int num = int .Parse(numero);

int dobro = num* 2;

Console.WriteLine( " o dobro do numero " + numero + " é " + dobro );
*/


/*
Console.WriteLine(" digite o tamanho do lado do quadrado  ");
string tamanho = Console.ReadLine();
int tam = int.Parse(tamanho);
int perimetro = tam * 4;
int area = tam* 2;

Console.WriteLine(" o perimetro do seu quadrado é " + perimetro + " e a area " + area);

    if (area >= 1000)
    {
        Console.WriteLine(" quadrado grande");

    }
    else
    {
        Console.WriteLine(" quadrado pequeno");
    }
    */
/*
Console.WriteLine(" digite o tamanho do lado do quadrado  ");
string tamanho = Console.ReadLine();
double tam = double.Parse(tamanho);
double perimetro = tam * 4;
double area = tam * 2;

Console.WriteLine(" o perimetro do seu quadrado é " + perimetro + " e a area " + area);

    if (area >= 1000)
    {
        Console.WriteLine(" quadrado grande");

    }
    else
    {
        Console.WriteLine(" quadrado pequeno");
    }
    */


using System.ComponentModel.Design;

Console.WriteLine(" digite um numero e descubra se ele é impar ou par");
string numero = Console.ReadLine();
int num = int.Parse(numero);

if (num % 2 == 0)
{
    Console.WriteLine(" entao ele é par ");

}
else
{
    Console.WriteLine(" entao ele é impar");

}
