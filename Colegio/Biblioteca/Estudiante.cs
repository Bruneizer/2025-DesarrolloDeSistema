namespace Biblioteca;
public class Estudiante
{        
    public string Nombre { get; set;}
    public string Apellido { get; set; }
    public int Legajo { get; set; } 
    public List<Materia> Materias { get; set; }
    public Estudiante(string nombre, string apellido, int legajo)
    {
        Nombre = nombre;
        Apellido = apellido;
        Legajo = legajo;
        Materias = new List<Materia>();
    }

}
