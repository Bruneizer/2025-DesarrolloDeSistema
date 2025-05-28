namespace Biblioteca;

public class Materia
{
public string Nombre {get; set;}
public int Nota { get; set; }
List<Materia> Materia = new List<Materia>();
public Materia(string nombre, int nota)
{
    Nombre = nombre;
    Nota = nota;
}
}
