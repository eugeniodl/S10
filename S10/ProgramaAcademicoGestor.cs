public class ProgramaAcademicoGestor
{
    private ProgramaAcademico _programaAcademico;

    public ProgramaAcademicoGestor()
    {
        // Inicializamos el programa académico con algunos estudiantes y asignaturas
        _programaAcademico = new ProgramaAcademico("Ingeniería de Sistemas");

        var estudiante1 = new Estudiante("Juan", new DateTime(2001, 5, 15));
        estudiante1.Asignaturas.Add(new Asignatura("Matemática", 85));
        estudiante1.Asignaturas.Add(new Asignatura("Contabilidad de Costos", 90));

        var estudiante2 = new Estudiante("María", new DateTime(2003, 7, 22));
        estudiante2.Asignaturas.Add(new Asignatura("Álgebra Lineal", 88));
        estudiante2.Asignaturas.Add(new Asignatura("Sociología", 92));

        var estudiante3 = new Estudiante("Pedro", new DateTime(1999, 7, 22));
        estudiante3.Asignaturas.Add(new Asignatura("Sociología", 56));

        _programaAcademico.Estudiantes.Add(estudiante1);
        _programaAcademico.Estudiantes.Add(estudiante2);
        _programaAcademico.Estudiantes.Add(estudiante3);
    }

    // Devuelve el programa académico
    public ProgramaAcademico ObtenerProgramaAcademico()
    {
        return _programaAcademico;
    }
}

