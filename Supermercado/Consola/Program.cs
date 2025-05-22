using Biblioteca;

Gestion gestion = new Gestion();
while (true)
{
Console.WriteLine("Hola,Ingrese la operacion que desea hacer: ");
Console.WriteLine("1 =  Dar de alta ");
Console.WriteLine("2 =  Dar de baja ");
Console.WriteLine("3  = Modificar producto ");
Console.WriteLine("4 = Mostrar la lista de producto");
Console.WriteLine("Para salir presione cualquier tecla");
string ingresado = Console.ReadLine();
switch (ingresado)
{
    case "1":
    Console.WriteLine("Nombre del producto: ");
    string nombre = Console.ReadLine();
    Console.WriteLine("No: ");
    decimal precioUnitario = Convert.ToDecimal(Console.ReadLine());
    Console.WriteLine("Nombre del producto: ");
    int cantidadStock = Convert.ToInt32(Console.ReadLine());
    Producto producto1 = new Producto(nombre, precioUnitario, cantidadStock);
    gestion.DarDeAlta(producto1);
    break;


}
}

