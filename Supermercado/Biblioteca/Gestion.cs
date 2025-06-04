
namespace Biblioteca;

public class Gestion
{
    List<Producto> productos = new List<Producto>();
    List<Ticket> tickets= new List<Ticket>();
    public void CrearProductos(Producto producto)
    {
        productos.Add(producto);
    }
    public void EliminarProducto(string nombre)
    {
        Producto productoEliminar = productos.FirstOrDefault(p => p.Nombre == nombre);
        if (productoEliminar == null)
        {
            Console.WriteLine("No existe el producto que quiere eliminar");
        }
        else
        {
            productos.Remove(productoEliminar);
            Console.WriteLine("Producto eliminado correctamente");
        }
    }
    public bool ExisteProducto(string nombre)
    {
        return productos.Any(p =>!string.IsNullOrEmpty(p.Nombre) &&
        p.Nombre.Trim().Equals(nombre.Trim(), StringComparison.OrdinalIgnoreCase));
    }
    public void ModificarProducto(string nombreActual, string nuevoNombre, decimal nuevoPrecio, int nuevoStock)
    {
        Producto producto = productos.FirstOrDefault(p => p.Nombre.Equals(nombreActual,StringComparison.OrdinalIgnoreCase));
        if (producto == null)
        {
            Console.WriteLine("No existe el producto");
            // return;
        }
        else
        {
            producto.Nombre = nuevoNombre;
            producto.PrecioUnitario = nuevoPrecio;
            producto.CantidadStock = nuevoStock;
            Console.WriteLine("Producto modificado correctamente");
        }
    }

    public void VerProductos()
    {
        if (productos.Count == 0)
        {
            Console.WriteLine("No hay productos cargados");
        }
        foreach (var producto in productos)
        {
            Console.WriteLine("---------------------------------------------");
            Console.WriteLine($"Nombre: {producto.Nombre}");
            Console.WriteLine($"Precio unitario: {producto.PrecioUnitario}");
            Console.WriteLine($"Cantidad de stock: {producto.CantidadStock}");
            Console.WriteLine("---------------------------------------------");
        }
    }
    public void ComprarProducto(string nombre)
    {
        bool productoComprar = ExisteProducto(nombre);
        if(productoComprar == null)
        {
            Console.WriteLine("El producto no se encuentra o no existe");
            return;
        }
        else
        {  
            tickets.Add(productos);

            Console.WriteLine("Producto comprado con exito");
            Console.WriteLine("Ticket:");
        }

    }
}