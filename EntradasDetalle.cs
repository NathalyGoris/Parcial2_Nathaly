using System.ComponentModel.DataAnnotations;

public class EntradasDetalle
{
    [Key]

    public int DetalleId { get; set; }

    [Required (ErrorMessage = "El Id de la entrada es obligatorio")]
    public Entradas EntradaId { get; set; }

    [Required (ErrorMessage = "El Id del producto es obligatorio")]
    public Productos ProductoId { get; set; }

    [Required (ErrorMessage = "La cantidad utilizada es obligatoria")]
    public int CantidadUtilizada { get; set; }

}