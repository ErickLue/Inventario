using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SysInventario.EntidadNegocio;

public partial class Producto
{
    [Key]
    public int Id { get; set; }

    [Required(ErrorMessage = "Codigo es obligatorio")]
    [StringLength(70)]
    public string? Codigo { get; set; } 

    [Required(ErrorMessage = "Nombre es obligatorio")]
    [StringLength(70)]
    public string? Nombre { get; set; } 

    [Required(ErrorMessage = "Precio es obligatorio")]
    [Column(TypeName = "decimal(30, 2)")]
    public decimal Precio { get; set; }

    [Required(ErrorMessage = "Stock es obligatorio")]
    public int Stock { get; set; }

    [Required(ErrorMessage = "Imagen es obligatorio")]
    public string? Foto { get; set; } 

    [NotMapped]
    public int Top_Aux { get; set; }

    [ForeignKey("Usuario")]
    public int IdUsuario { get; set; }
    [ForeignKey("Categoria")]
    public int IdCategoria { get; set; }

    public Categoria? Categoria { get; set; } 

    public Usuario? Usuario { get; set; } 




}
