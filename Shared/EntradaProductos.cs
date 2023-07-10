using System.ComponentModel.DataAnnotations;

public class EntradaProductos
{
    [Key]
    public int EntradaId { get; set; }

    public DateTime Fecha { get; set; } = DateTime.Today;

    public string? Concepto { get; set; }

    public int MyProperty { get; set; }

}





