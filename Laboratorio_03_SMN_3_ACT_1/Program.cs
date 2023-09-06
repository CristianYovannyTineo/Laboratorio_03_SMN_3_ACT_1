// See https://aka.ms/new-console-template for more information
//Una empresa de carga realiza el transporte de frutas,
//el precio por la carga está enfunción al tipo de fruta a transportar y la distancia en kilómetros que debe recorrer,
//los precios que se muestran en la tabla es por cada caja de frutas:
//Sólo se realiza la carga de un solo tipo de fruta. Calcular el pago que debe realizarse por esa carga.

Console.WriteLine(" 1) Naranja");
Console.WriteLine(" 2) Fresa");
Console.WriteLine(" 3) Mango");

Console.WriteLine("Seleccione la fruta ");
int fruta = int.Parse(Console.ReadLine());
Console.WriteLine("Indique kilometraje recorrido");
int kilometraje = int.Parse(Console.ReadLine());

double Naranja, Fresa, Mango;

switch (fruta)
{
    case 1:
        if (kilometraje < 30)
        {
            Naranja = kilometraje * 2.00;
            Console.WriteLine("El precio de la caja es: " + Naranja);
        }
        else if (kilometraje > 30)
        {
            Naranja = kilometraje * 4.00;
            Console.WriteLine("El precio de la caja es: " + Naranja);
        }


        break;
    case 2:
        if (kilometraje < 30)
        {
            Fresa = kilometraje * 6.00;
            Console.WriteLine("El precio de la caja es: " + Fresa);
        }
        else if (kilometraje > 30)
        {
            Fresa = kilometraje * 9.00;
            Console.WriteLine("El precio de la caja es: " + Fresa);
        }
        break;
    case 3:
        if (kilometraje < 30)
        {
            Mango = kilometraje * 3.00;
            Console.WriteLine("El precio de la caja es: " + Mango);
        }
        else if (kilometraje > 30)
        {
            Mango = kilometraje * 5.00;
            Console.WriteLine("El precio de la caja es: " + Mango);
        }
        break;
    default:
        Console.WriteLine("Ingrese la fruta valida");
        break;
}