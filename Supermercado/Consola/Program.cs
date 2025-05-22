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
    Console.WriteLine("Precio del producto: ");
    decimal precioUnitario = Convert.ToDecimal(Console.ReadLine());
    Console.WriteLine("Cantidad de Stock: ");
    int cantidadStock = Convert.ToInt32(Console.ReadLine());
    Producto producto1 = new Producto(nombre, precioUnitario, cantidadStock);
    gestion.CrearProductos(producto1);
    break;
    case "2":
    gestion.EliminarProducto();
    break;
    case "4":
    Console.WriteLine("Productos en la tienda");
    gestion.VerProductos();
    break;
    


}
}

