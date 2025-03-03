namespace Cursos.Domain;

public class Clasificacion : BaseEntity
{
    /// <summary>
    /// Alumno asociado
    /// </summary>
    public string? Alumno { get; set; }

    /// <summary>
    /// Puntos logrados
    /// </summary>
    public int Puntaje { get; set; }

    /// <summary>
    /// Comentario para esta clasificacion
    /// </summary>
    public string? Comentario { get; set; }

    /// <summary>
    /// Llave foreana que representa el curso que tiene esta calicacion
    /// </summary>
    public Guid? CursoId { get; set; }

    /// <summary>
    /// Representa el curso relacionado a esta calicacion
    /// </summary>
    public Curso? Curso { get; set; }
}