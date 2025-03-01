namespace Cursos.Domain;

public class Curso : BaseEntity
{
    /// <summary>
    /// Titulo del curso
    /// </summary>
    public string? Titulo { get; set; }

    /// <summary>
    /// Descripcion del curso
    /// </summary>
    public string? Descripcion { get; set; }
}