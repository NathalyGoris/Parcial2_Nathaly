using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class EntradasDetalle
{
    [Key]
    public int DetalleId { get; set; }

     [ForeignKey("EntradaId")]
    public Entradas? EntradaId { get; set; }

     [ForeignKey("ProductoId")]
    public Productos? ProductoId { get; set; }

    [Required (ErrorMessage = "La cantidad utilizada es obligatoria")]
    public int CantidadUtilizada { get; set; }

}