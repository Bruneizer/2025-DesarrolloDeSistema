namespace Biblioteca;

public class Curso
{
    public string Nombre { get; set; }
    List<Estudiante> estudiantes = new List<Estudiante>();
    public List<Estudiante> Estudiantes => estudiantes;

    public Curso(string nombre)
    {
        Nombre = nombre;

    }
    public void AgregarEstudiante(Estudiante estudiante)
    {
        estudiantes.Add(estudiante);
    }
}
