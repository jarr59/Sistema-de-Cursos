namespace Cursos.Domain;

public class CursoInstructor
{
    /// <summary>
    /// Representa el id de curso
    /// </summary>
    public Guid CursoId { get; set; }

    /// <summary>
    /// Representa el curso
    /// </summary>
    public Curso? Curso { get; set; }

    /// <summary>
    /// Representa el id de instructor
    /// </summary>
    public Guid InstructorId { get; set; }

    /// <summary>
    /// Representa el instructor
    /// </summary>
    public Instructor? Instructor { get; set; }
}