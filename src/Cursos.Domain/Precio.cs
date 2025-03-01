namespace Cursos.Domain;

public class Precio : BaseEntity
{
    /// <summary>
    /// Nombre de precio relacionado al curso
    /// </summary>
    public string? Nombre { get; set; }

    /// <summary>
    /// Representa el precio actual
    /// </summary>
    public decimal PrecioActual { get; set; }

    /// <summary>
    /// Representa el precio en promocion
    /// </summary>
    public decimal PrecioPromocion { get; set; }
}