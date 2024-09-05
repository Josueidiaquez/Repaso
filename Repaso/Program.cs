using System;
using System.Numerics;

class Repaso
{
    static void Main(string[] args)
    {
        string Nombre;
        int Edad, cantidad;
        int Opcion;
        double precio = 0;
        double Porcentajeimpuesto = 0;
        double subtotal; 
        double impuesto;
        double Total = 0;
        Console.WriteLine("Bienvenido al sistema de ventas");
        Console.WriteLine("Ingrese su nombre;");
        Nombre = Console.ReadLine();
        Console.WriteLine("Ingrese su edad");
        Edad = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Seleccione el producto del que desea informacion");
        Console.WriteLine("1. Kit de aduino Basico");
        Console.WriteLine("2. kit de aduino intermedio");
        Console.WriteLine("3. Kit de aduino avanzado");
        Opcion = Convert.ToInt32(Console.ReadLine());

        switch (Opcion)

        {
            case 1:
            Console.WriteLine("Kit basico");
                precio = 700;
                Porcentajeimpuesto = 0.015;
            break;

            case 2:
            Console.WriteLine("Kit intermedio");
                precio = 1100;
                Porcentajeimpuesto = 0.015;
            break;

            case 3:
            Console.WriteLine("Kit avanzado");
                precio = 2000;
                Porcentajeimpuesto = 0;
            break;

            default:
            Console.WriteLine("Opcion no valida");
            break;
        }
        Console.WriteLine("Ingrese la cantidad deseada");
        cantidad = Convert.ToInt32(Console.ReadLine());
        impuesto = precio + cantidad + Porcentajeimpuesto;
        subtotal = precio + cantidad + impuesto;

        Console.WriteLine("El total es: " + Total );
    }
}