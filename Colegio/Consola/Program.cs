using System.Xml;
using Biblioteca;
using Microsoft.VisualBasic;

bool activo = true;
Logica logica = new Logica();

while (activo)
{
    // - El nombre de un curso
    Console.WriteLine("Presione 1 para agregar un curso: ");
    Console.WriteLine("Presione 2 para agregar un estudiante a un curso: ");
    // - Los estudiantes de un curso
    // - Los nombres de los estudiantes de un curso
    Console.WriteLine("Presione 3 para saber los nombres de los estudiantes de un curso: ");
    Console.WriteLine("Presione 4 para agregar una materia: ");
    Console.WriteLine("Presione 5 para agregar materia a un estudiante");
    // - Las notas de un estudiante en un curso.
    Console.WriteLine("Presione 6 para saber la nota de un estudiante de un curso: ");
    // - Las notas de los estudiantes de un curso.
    Console.WriteLine("Presione 7 para saber las notas los estudiante de un curso: ");
    // - La nota de un estudiante en una materia.
    Console.WriteLine("Presione 8 para saber la nota de un estudiante en una materia.");
    // - La lista de materias de un estudiante.
    Console.WriteLine("Presione 9 para saber la lista de materias de un estudiante");
    // - Las notas de los estudiantes desaprobados.
    Console.WriteLine("Presione 10 para saber las notas de los estudiantes desaprobados: ");
    // - La cantidad de desaprobados de un curso.
    Console.WriteLine("Presione 11 para saber la cantidad de desaprobados de un curso: ");
    int ingresado = Convert.ToInt32(Console.ReadLine());
    switch (ingresado)
    {
        case 1:
            Console.Write("Ingrese el nombre del curso: ");
            string nombreCurso = Console.ReadLine();
            Curso curso = new Curso(nombreCurso);
            logica.AgregarCurso(curso);
            Console.WriteLine("Curso agregado correctamente");
            break;
        case 2:
            Console.Write("Ingrese el nombre del estudiante: ");
            string nombre = Console.ReadLine();
            Console.Write("Ingrese el apellido del estudiante: ");
            string apellido = Console.ReadLine();
            Console.Write("Ingrese el legajo del estudiante: ");
            int legajo = Convert.ToInt32(Console.ReadLine());
            Estudiante estudiante = new Estudiante(nombre, apellido, legajo);
            logica.InformarCursos();
            Console.Write("¿A qué curso desea agregar?: ");
            nombreCurso = Console.ReadLine();
            Curso? cursoSeleccionado = logica.BuscarCursoPorNombre(nombreCurso);
            if (cursoSeleccionado == null)
            {
                Console.WriteLine("El curso no existe. Verifique el nombre ingresado.");
                break;
            }
            logica.AgregarEstudianteAunCurso(estudiante, cursoSeleccionado);
            Console.WriteLine("Estudiante inscripto correctamente.");
            break;
        case 3:
            Console.WriteLine("Alumnos de que curso desea saber: ");
            logica.InformarCursos();
            string cursoooo = Console.ReadLine();
            Curso cursoBuscar = logica.BuscarCursoPorNombre(cursoooo);
            logica.InformarEstudiantesDentroDeUnCurso(cursoBuscar);
            break;
        case 4:
            Console.Write("Que materia desea agregar: ");
            string materiaCase4 = Console.ReadLine();
            Materia nuevaMateria = new Materia(materiaCase4);
            logica.AgregarMateria(nuevaMateria);
            Console.WriteLine("Materia Agregada correctamente");
            break;
        case 5:
            Console.Write("Ingrese el nombre del estudiante: ");
            string nombreEst = Console.ReadLine();
            Console.Write("Ingrese el apellido del estudiante: ");
            string apellidoEst = Console.ReadLine();

            Estudiante? est = logica.BuscarEstudiantePorNombreYApellido(nombreEst, apellidoEst);
            if (est == null)
            {
                Console.WriteLine("Estudiante no encontrado.");
                break;
            }

            Console.WriteLine("Materias disponibles:");
            logica.InformarMaterias();
            Console.Write("¿Qué materia desea agregar?: ");
            string nombreMateria = Console.ReadLine();

            Materia? materiaSeleccionada = logica.BuscarMateriaPorNombre(nombreMateria);
            if (materiaSeleccionada == null)
            {
                Console.WriteLine("Materia no encontrada.");
                break;
            }
            Console.Write("Ingrese la nota para la materia: ");
            int nota = Convert.ToInt32(Console.ReadLine());
            Materia materiaAsignada = new Materia(materiaSeleccionada.Nombre, nota);
            est.Materias.Add(materiaAsignada);
            Console.WriteLine("Materia agregada correctamente al estudiante.");
            break;
        case 6:
            Console.Write("Ingrese Curso: ");
            string cursoCase6 = Console.ReadLine();
            Console.Write("Ingrese el nombre del estudiante: ");
            string nombreCase6 = Console.ReadLine();
            Console.Write("Ingrese apellido del estudiante: ");
            string apellidoCase6 = Console.ReadLine();
            logica.InformarNotasDeUnEstudianteEnCurso(nombreCase6, apellidoCase6);
            break;
        case 7:
            Console.Write("Ingrese curso: ");
            string cursoCase7 = Console.ReadLine();
            Curso cursoCase77 = logica.BuscarCursoPorNombre(cursoCase7);
            logica.InformarNotasDeLosEstudianteEnCurso(cursoCase77);
            break;
        case 8:
            Console.WriteLine("Ingrese el nombre: ");
            string nombreCase8 = Console.ReadLine();
            Console.WriteLine("Ingrese el apellido: ");
            string apellidoCase8 = Console.ReadLine();
            logica.InformarNotaEstudianteEnUnaMateria(nombreCase8, apellidoCase8);
            break;
        case 9:
            Console.Write("Ingrese el nombre del estudiante: ");
            string nombreCase9 = Console.ReadLine();
            Console.Write("Ingrese el apellido del estudiante: ");
            string apellidoCase9 = Console.ReadLine();
            logica.InformarMateriadDeUnEstudiante(nombreCase9, apellidoCase9);
            break;
        case 10:
            Console.Write("Ingrese curso: ");
            string cursoCase10 = Console.ReadLine();
            logica.InformarNotasEstudiantesDesaprobados(cursoCase10);
            break;
        case 11:
            Console.WriteLine("Ingrese curso");
            string cursoCase11 = Console.ReadLine();
            logica.CantidadDesaprobadosCurso(cursoCase11);
            break;

    }
}
