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

    /// <summary>
    /// Clasificaciones del curso
    /// </summary>
    public ICollection<Clasificacion>? Clasificaciones { get; set; }

    /// <summary>
    /// 
    /// </summary>
    public ICollection<Precio>? Precios { get; set; }

    /// <summary>
    /// 
    /// </summary>
    public ICollection<CursoPrecio>? CursoPrecios { get; set; }

    /// <summary>
    /// Representa los instructores de este curso
    /// </summary>
    public ICollection<Instructor>? Instructores { get; set; }

    /// <summary>
    /// Representa los cursos
    /// </summary>
    public ICollection<CursoInstructor>? CursoInstructores { get; set; }

    /// <summary>
    /// 
    /// </summary>
    public ICollection<Imagen>? Fotos { get; set; }
}