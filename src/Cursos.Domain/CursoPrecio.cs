namespace Cursos.Domain;

/// <summary>
/// Representa la tabla intermedia entre muchos a muchos de curson con precio
/// </summary>
public class CursoPrecio
{
    /// <summary>
    /// Representa 
    /// </summary>
    public Guid CursoId { get; set; }

    /// <summary>
    /// Curso
    /// </summary>
    public Curso? Curso { get; set; }

    /// <summary>
    /// Representa 
    /// </summary>
    public Guid PrecioId { get; set; }

    /// <summary>
    /// Precio
    /// </summary>
    public Precio? Precio { get; set; }
}