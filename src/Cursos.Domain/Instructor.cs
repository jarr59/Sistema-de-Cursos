namespace Cursos.Domain;

public class Instructor : BaseEntity
{
    /// <summary>
    /// Primer y segundo nombres del instructor
    /// </summary>
    public string? Nombre { get; set; }

    /// <summary>
    /// Apellidos del instructor
    /// </summary>
    public string? Apellidos { get; set; }

    /// <summary>
    /// Grado academico del instructor
    /// </summary>
    public string? Grado { get; set; }
}