using System.Diagnostics.CodeAnalysis;

int num1, num2;
int suma, resta, multi, divi;
float sumD, resD, mulD, divD;
float dec1, dec2;

Console.WriteLine("Ingrese el primer valor entero: ");
num1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Ingrese el segundo valor entero: ");
num2 = Convert.ToInt32(Console.ReadLine());

suma = num1 + num2;
resta = num1 - num2;
multi = num1 * num2;
divi = num1 / num2;

Console.WriteLine("\nLa suma de los valores es: " + suma + "\nLa resta de los valores es: " + resta + "\nLa multiplicación de los valores es: " + multi + "\nLa división de los valores es: " + divi);

Console.WriteLine("\nIngrese el primer valor decimal: ");
dec1 = Convert.ToSingle(Console.ReadLine());

Console.WriteLine("\nIngrese el segundo valor decimal: ");
dec2 = Convert.ToSingle(Console.ReadLine());

sumD = dec1 + dec2;
resD = dec1 - dec2;
mulD = dec1 * dec2;
divD = dec1 / dec2;

Console.WriteLine("\nLa suma de los valores es: " + sumD + "\nLa resta de los valores es: " + resD + "\nLa multiplicación de los valores es: " + mulD + "\nLa división de los valores es: " + divD);