using System.Runtime.CompilerServices;

namespace Biblioteca;
public class Ticket
{
    public string NombreProductoTicket { get; set;}
    public int CantidadProductoTicket { get; set;}
    public decimal PrecioTotalPorProducto {get; set;}
    public decimal PrecioTotalProducto {get; set;}

    public Ticket(string nombreProductoTicket,int cantidadProductoTicket,decimal precioTotalPorProducto,decimal precioTotalProducto)
    {
        NombreProductoTicket = nombreProductoTicket;
        CantidadProductoTicket = cantidadProductoTicket;
        PrecioTotalPorProducto = precioTotalPorProducto;
        PrecioTotalProducto = precioTotalProducto;
    }

}