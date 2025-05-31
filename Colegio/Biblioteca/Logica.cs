namespace Biblioteca;

public class Logica
{
    // List<Colegio> colegios = new List<Colegio>();
    List<Curso> cursos = new List<Curso>();
    List<Materia> materias = new List<Materia>();
    List<Estudiante> estudiantes = new List<Estudiante>();
    // public void AgregarColegio(Colegio colegio)
    // {
    //     colegios.Add(colegio);
    // }
    // public void InformarColegios()
    // {
    //     foreach (Colegio colegioss in colegios)
    //     {
    //         Console.WriteLine($"Colegios registrados: {colegioss.Nombre}");

    //     }
    // }
    public void AgregarCurso(Curso curso)
    {
        cursos.Add(curso);
    }
    public void InformarCursos()
    {
        foreach (Curso cursoss in cursos)
        {
            Console.WriteLine($"Curso registrado/s:{cursoss.Nombre}");
        }
    }
    public void AgregarMateria(Materia materia)
    {
        materias.Add(materia);
    }
    public void InformarMaterias()
    {
        foreach (var materiass in materias)
        {
            Console.WriteLine($"{materiass.Nombre}");
        }
    }
    public void AgregarEstudianteAunCurso(Estudiante estudiante, Curso curso)
    {
        estudiantes.Add(estudiante);
        curso.AgregarEstudiante(estudiante);
    }
    public void InformarEstudiantesDentroDeUnCurso(Curso curso)
    {
        foreach (var estudiante in curso.Estudiantes)
        {
            Console.WriteLine($"{estudiante.Nombre} {estudiante.Apellido}");
        }
    }
    public Curso? BuscarCursoPorNombre(string nombre)
    {
        return cursos.FirstOrDefault(c => c.Nombre.Equals(nombre, StringComparison.OrdinalIgnoreCase));
    }
    public Estudiante? BuscarEstudiantePorNombreYApellido(string nombre, string apellido)
    {
        foreach (var cursoss in cursos)
        {

            var estudiante = cursoss.Estudiantes.FirstOrDefault(e => e.Nombre.Equals(nombre, StringComparison.OrdinalIgnoreCase) &&
                                                       e.Apellido.Equals(apellido, StringComparison.OrdinalIgnoreCase));
            if (estudiante != null)
                return estudiante;
        }
        return null;
    }
    public Materia? BuscarMateriaPorNombre(string nombre)
    {
        return materias.FirstOrDefault(m => m.Nombre == nombre);
    }
    public void InformarNotasDeUnEstudianteEnCurso(string nombre, string apellido)
    {
        var estudiante = BuscarEstudiantePorNombreYApellido(nombre, apellido);
        if (estudiante == null)
        {
            Console.WriteLine("No existe el estudiante:");
            return;
        }
        Console.WriteLine($"La nota del estudiante {estudiante.Nombre} {estudiante.Apellido}:");
        if (estudiante.Materias.Count == 0)
        {
            Console.WriteLine("El estudiante no tiene materias asignadas");
            return;
        }
        Console.WriteLine($"Nota de {estudiante.Nombre} {estudiante.Apellido}");
        foreach (var materia in estudiante.Materias)
        {
            Console.WriteLine($"{materia.Nombre}: {materia.Nota}");
        }
    }
    public void InformarNotasDeLosEstudianteEnCurso(Curso curso)
    {
        if (curso == null)
        {
            Console.WriteLine("No existe el curso");
            return;
        }
        if (curso.Estudiantes.Count == 0)
        {
            Console.WriteLine("No hay estudiantes dentro del curso");
            return;
        }
        foreach (var estudiante in curso.Estudiantes)
        {
            if (estudiante.Materias.Count == 0)
            {
                Console.WriteLine("Los estudiantes no tienen materia asignadas");
                continue;
            }
            Console.WriteLine($"Estudiante {estudiante.Nombre} {estudiante.Apellido}");
            foreach (var materia in estudiante.Materias)
            {
                Console.WriteLine($"  {materia.Nombre}: {materia.Nota}");
            }
        }
    }
    public void InformarNotaEstudianteEnUnaMateria(string nombre, string apellido)
    {
        foreach (var cursoss in cursos)
        {
            var estudiante = cursoss.Estudiantes.FirstOrDefault(e => e.Nombre.Equals(nombre, StringComparison.OrdinalIgnoreCase) &&
                                                                     e.Apellido.Equals(apellido, StringComparison.OrdinalIgnoreCase));
            if (estudiante != null)
            {
                Console.WriteLine($"La nota del estudiante {estudiante.Nombre} {estudiante.Apellido}");
            if (estudiante.Materias.Count == 0)
            {
                Console.WriteLine(" El estudiante no tiene materias");
            }
            else
            {
                foreach (var materiasss in estudiante.Materias)
                {
                    Console.Write($"{materiasss.Nombre}: {materiasss.Nota}");
                }
            }
            return;
            }
        }
        Console.WriteLine("Estudiante no encontrado");
    }
    public void InformarMateriadDeUnEstudiante(string nombre, string apellido)
    {
        var estudiante = BuscarEstudiantePorNombreYApellido(nombre, apellido);
        if (estudiante == null)
        {
            Console.WriteLine($"No se encontro al estudiante");
            return;
        }
        if (estudiante.Materias.Count == 0)
        {
            Console.WriteLine($"El estudiante {estudiante.Nombre} {estudiante.Apellido} no tiene materias asignadas.");
            return;
        }
        Console.WriteLine($"Materias de {estudiante.Nombre} {estudiante.Apellido}: ");
        foreach (var materia in estudiante.Materias)
        {
            Console.WriteLine($"- {materia.Nombre}");
        }
    }

    public void InformarNotasEstudiantesDesaprobados(string curso)
    {
        var cursogh = BuscarCursoPorNombre(curso);
        if (cursogh == null)
        {
            Console.WriteLine("No existe el curso");
            return;
        }
        bool Desaprobados = false;
        foreach (var estudiante in cursogh.Estudiantes)
        {
            if (estudiante.Materias.Count == 0)
                continue;
            foreach (var materia in estudiante.Materias)
            {
                if (materia.Nota < 6)
                {
                    Console.WriteLine($"Estudiante: {estudiante.Nombre} {estudiante.Apellido} - Materia: {materia.Nombre} - Nota: {materia.Nota}");
                    Desaprobados = true;
                }
            }
        }
        if (!Desaprobados)
        {
            Console.WriteLine("No hay estudiantes desaprobados en este curso.");
        }
    }
    public void CantidadDesaprobadosCurso(string nombreCurso)
    {
        Curso curso = BuscarCursoPorNombre(nombreCurso);
        if (curso == null)
        {
            Console.WriteLine("Curso no encontrado.");
            return;
        }

        int cantidadDesaprobados = 0;

        foreach (var estudiante in curso.Estudiantes)
        {
            foreach (var materia in estudiante.Materias)
            {
                if (materia.Nota < 6)
                {
                    cantidadDesaprobados++;
                    break;
                }
            }
        }

        Console.WriteLine($"Cantidad de estudiantes desaprobados en el curso {nombreCurso}: {cantidadDesaprobados}");
    }
}