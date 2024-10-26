namespace S10
{
    public partial class Form1 : Form
    {
        private ProgramaAcademicoGestor _programaAcademicoGestor;

        public Form1()
        {
            InitializeComponent();

            _programaAcademicoGestor = new ProgramaAcademicoGestor();
        }

        private void btnMostrarEstudiantes_Click(object sender, EventArgs e)
        {
            // Obtenemos el programa académico y los estudiantes
            var programaAcademico = _programaAcademicoGestor.ObtenerProgramaAcademico();
            var estudiantes = programaAcademico.Estudiantes;

            // Filtrar estudiantes que nacieron despúes del año 2000 y que lleven más de 1 asignatura
            var estudiantesFiltrados = estudiantes
                .Where(e => e.FechaDeNacimiento.Year >= 2000 && e.Asignaturas.Count > 1);

            lstEstudiantes.Items.Clear();
            lstEstudiantes.Items.Add("Estudiantes que nacieron despúes del año 2000 y que lleven más de 1 asignatura");
            foreach (var estudiante in estudiantesFiltrados)
            {
                lstEstudiantes.Items.Add(estudiante);
            }

        }

        private void btnMostrarAsignaturas_Click(object sender, EventArgs e)
        {
            // Obtenemos el programa académico y los estudiantes
            var programaAcademico = _programaAcademicoGestor.ObtenerProgramaAcademico();
            var estudiantes = programaAcademico.Estudiantes;

            // Filtrar asignaturas con notas mayores a 85
            var asignaturasFiltradas = estudiantes
                .SelectMany(e => e.Asignaturas)
                .Where(a => a.Nota > 85);

            lstAsignaturas.Items.Clear();
            lstAsignaturas.Items.Add("Asignaturas con notas mayores a 85");

            foreach (var asignatura in asignaturasFiltradas)
            {
                lstAsignaturas.Items.Add(asignatura);
            }
        }
    }
}
