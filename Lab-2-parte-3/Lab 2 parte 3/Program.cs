int num1, num2;

Console.WriteLine("Ingrese el primer valor: ");
num1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Ingrese el segundo valor: ");
num2 = Convert.ToInt32(Console.ReadLine());

if (num1 > num2)
{
    Console.WriteLine("El primer valor es mayor que el segundo");
}
else if (num1 < num2)
{
    Console.WriteLine("El primer valor es menor que el segundo");
}
else
{
    Console.WriteLine("Los valores son iguales");
}



