namespace Cursos.Domain;

public class Curso
{
    /// <summary>
    /// Representa el identificador
    /// </summary>
    public Guid Id { get; set; }

    /// <summary>
    /// Titulo del curso
    /// </summary>
    public string? Titulo { get; set; }

    /// <summary>
    /// Descripcion del curso
    /// </summary>
    public string? Descripcion { get; set; }
}