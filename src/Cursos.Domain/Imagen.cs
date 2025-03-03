namespace Cursos.Domain;

public class Imagen : BaseEntity
{
    /// <summary>
    /// Url de la imagen
    /// </summary>
    public string? Url { get; set; }

    /// <summary>
    /// Identificador del curso que pertenece esta imagen
    /// </summary>
    public Guid CursoId { get; set; }

    /// <summary>
    /// 
    /// </summary>
    public Curso? Curso { get; set; }
}