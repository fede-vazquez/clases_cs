int n1, n2;

Console.Write("Ingrese un número: ");
int.TryParse(Console.ReadLine(), out n1);

Console.Write("Ingrese otro núero: ");
int.TryParse(Console.ReadLine(), out n2);

int result = n1 + n2;
Console.WriteLine($"La suma de los números es: {result}");

result = n1 - n2;
Console.WriteLine($"La resta de los números es: {result}");

result = n1 * n2;
Console.WriteLine($"La multiplicación de los números es: {result}");

if (n2 == 0)
{
    Console.WriteLine($"Él segundo número es cero, no se puede dividir.");
}
else
{
    float r = (float)n1 / (float)n2;
    Console.WriteLine($"La división de los números es: {r}");
}