namespace Biblioteca;

public class Curso
{
    public string Nombre { get; set; }
    List<Estudiante> Estudiantes = new List<Estudiante>();
    public Curso();
    {
    Estudiantes = new List<Estudiante>();
    }
}