namespace Biblioteca;

public class Materia
{
    public string Nombre { get; set; }
    public double Nota { get; set; }
    public Materia(string nombre, double nota = 0)
    {
        Nombre = nombre;
        Nota = nota;
    }

}