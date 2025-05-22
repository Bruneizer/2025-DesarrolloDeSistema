
namespace Biblioteca;
public class Gestion
{      
List<Producto> productos = new List< Producto>();
public void CrearProductos(Producto producto)
{
    productos.Add(producto);
}
public void EliminarProducto(string nombre)
{
    Producto ProductoEliminar = productos.FirstOrDefault(p => p.Nombre == nombre);
    if(ProductoEliminar == null)
    {
        Console.WriteLine("No existe el producto que quiere eliminar");
    }
    else
    {
        productos.Remove(ProductoEliminar);
    }

    {
  productos.Clear();
    }
}
public void VerProductos()
{
if(productos.Count == 0)
{
    Console.WriteLine("No hay productos cargados");
}
foreach(var producto in productos)
{
    Console.WriteLine("---------------------------------------------");
    Console.WriteLine($"Nombre: {producto.Nombre}");
    Console.WriteLine($"Precio unitario: {producto.PrecioUnitario}");
    Console.WriteLine($"Cantidad de stock: {producto.CantidadStock}");
    Console.WriteLine("---------------------------------------------");
}
}
}