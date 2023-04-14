// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hola, el siguiente programa solicitará dos números para realizar las diferentes operaciones suma, resta, multiplicación y división");
Console.WriteLine("Insertar el primer número");
var primernumero = Console.ReadLine();
int Numero1 = int.Parse(primernumero);
Console.WriteLine("Insertar el segundo número");
var segundonumero = Console.ReadLine();
int Numero2 = int.Parse(segundonumero);
var suma = Numero1 + Numero2;
Console.WriteLine("El resultado obtenido de sumar dos números " + primernumero + " + " + segundonumero + " es: " + suma);
var resta = Numero1 - Numero2;
Console.WriteLine("El resultado obtenido de restar dos números " + primernumero + " - " + segundonumero + " es: " + resta);
var producto = Numero1 * Numero2;
Console.WriteLine("El resultado obtenido de multiplicar dos números " + primernumero + " x " + segundonumero + " es: " + producto);
var division = Numero1 / Numero2;
Console.WriteLine("El resultado obtenido de dividir dos números " + primernumero + " / " + segundonumero + " es: " + division);