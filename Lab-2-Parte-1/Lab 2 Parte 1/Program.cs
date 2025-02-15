int num1;

double dec;

string str;

bool vof;

Console.Write("Ingrese un numero entero: ");
num1 = int.Parse(Console.ReadLine());

Console.Write("Ingrese un numero decimal: ");
dec = double.Parse(Console.ReadLine());

Console.Write("Ingrese un texto: ");
str = Console.ReadLine();

Console.Write("Ingrese un valor booleano 'true' ó 'false' : ");
vof = bool.Parse(Console.ReadLine());


Console.WriteLine("\nEl numero entero es: " + num1 + "\nEl numero decimal es: " + dec + "\nEl texto es: " + str + "\nEl valor booleano es: " + vof);




