namespace Biblioteca;

public class Estudiante
{
    public string Nombre { get; set; }
    public string Apellido { get; set; }
    public int Legajo { get; set; }
    public List<Materia> Materias { get; set; } = new List<Materia>();

    public Estudiante(string nombre, string apellido, int legajo)
    {
        Nombre = nombre;
        Apellido = apellido;
        Legajo = legajo;
    }
    public void AgregarMateria(Materia materia)
    {
        Materias.Add(materia);
    }


}