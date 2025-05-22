namespace Biblioteca;

public class  Producto
{
    public string Nombre {get; set;}
    public decimal PrecioUnitario {get; set;}
    public int Cantidad {get; set;}

public Producto(string nombre, decimal precioUnitario,int cantidadStock)
{
    Nombre = nombre;
    PrecioUnitario = precioUnitario;
    Cantidad = cantidadStock;

}

}
