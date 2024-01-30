Double lado1, lado2, Perimetro = 0, Base;
int Opcion;

Console.WriteLine("TRIANGULOS");
Console.WriteLine("Cual desea resolver?");
Console.WriteLine("1. Equilatero");
Console.WriteLine("2. Isoceles");
Console.WriteLine("3. Rectangulo");
Console.WriteLine("Ingrese una opcion: ");

Opcion = int.Parse(Console.ReadLine());

if (Opcion < 1 || Opcion > 3)
{
    Console.WriteLine("Opcion incorrecta");
}
else
{
    switch (Opcion)
    {
        case 1:
            Console.WriteLine("EQUILATERO");
            Console.WriteLine("Ingrese el tamaño del lado 1");
            lado1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el tamaño del lado 2");
            lado2 = double.Parse(Console.ReadLine());
            Perimetro = 3 * lado1;
            break;
        case 2:
            Console.WriteLine("ISOCELES");
            Console.WriteLine("Ingrese el tamaño del lado 1");
            lado1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la base");
            Base = double.Parse(Console.ReadLine());
            Perimetro = (2 * lado1) + Base;
            break;
        case 3:
            Console.WriteLine("RECTANGULO");
            Console.WriteLine("Ingrese el tamaño del lado 1");
            lado1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el tamaño del lado 2");
            lado2 = double.Parse(Console.ReadLine());
            Perimetro = lado1 + lado2 + (Math.Sqrt((lado1 + lado1) + (lado2 + lado2)));
            break;
            default:
            break;
    }
    Console.WriteLine("El perimetro es: " + Perimetro);
}